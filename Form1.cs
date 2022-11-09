using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nova.Mars.SDK;
using System.IO.Ports;
using Nova.Diagnostics;
using System.Diagnostics;
using System.Reflection;
using Nova.LCT.GigabitSystem.Common;
using System.Collections;
using Nova.LCT.GigabitSystem.Monitor;
using System.IO;
using Nova.LCT.GigabitSystem.Files;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Nova.LCT.GigabitSystem.HWConfigAccessor;
using Microsoft.Win32;
using System.Windows.Forms.VisualStyles;
using MySqlConnector;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using Nova.LCT.GigabitSystem.HWPointDetect;
using static System.Windows.Forms.AxHost;
using static System.Net.WebRequestMethods;
using System.Runtime.Remoting.Contexts;
using System.Xml;

namespace led_test_using_form
{



    public partial class Form1 : Form
    {
        #region controller variable
        private MarsControlSystem _marsCtrlSystem = null;
        private MarsHardwareEnumerator _marsHWEnumerator = null;
        private MarsFunctionCardInCOM _marsFCInComm = null;
        int nScreenCnt = -1;
        int nscanCnt = -1;
        int nSenderCnt = -1;
        bool service_ready = false; //true when NOVA system service is ready
        bool ctrl_connected = false;    //true when connected to controller
        List<int> temp_list = new List<int>();  //storing temperature of each scan board
        List<bool> status_list = new List<bool>();  //storing status of each scan board
        int cycle = 0;
        List<int> faulty_ic = new List<int>();
        List<int> abormal_board = new List<int>();
        int port_number = 0;    //network port of connected LED screen at the controller 
        #endregion
        string com_name = "10.4.0.202:5200";    //controller ip

        bool refresh_completed = false;
        #region sql parameter
        int threshold1 = 0;//the threshold1 read in db
        int threshold2 = 0; //the threshold2 read in db
        //database credential
        string server_address = "Server=10.4.0.200;";   //db ip
        string username = "uid=new;";   //db user name
        string pass = "pwd=1234;";  //db password
        string dbname = "database=IPS;";  //the default db if the server has multiple db
        int last_brightness;
        MySqlConnection con;
        #endregion 

        Thread t1;
        public Form1()
        {
            InitializeComponent();
            _marsHWEnumerator = new MarsHardwareEnumerator();
            _marsCtrlSystem = new MarsControlSystem(_marsHWEnumerator);
            _marsFCInComm = new MarsFunctionCardInCOM(_marsHWEnumerator);
            _marsCtrlSystem.RefreshHardwareStatusFinishEvent += new RefreshResultEventHandler(MarsCtrlSystem_RefreshHardwareStatusFinishEvent);
        }
        private void Nova_serivce_init()
        {
            con = new MySqlConnection(server_address + username + pass + dbname);
            service_ready = _marsHWEnumerator.Initialize();
            if (service_ready == true)
            {
                Trace.WriteLine("Service initalized!");
                service_ready = true;
                //_marsHWEnumerator.GetComNameOfControlSystem(0, out com_name);
            }
            else
            {
                Trace.WriteLine("Failed to initalize Service !");
            }
        }
        private void Ctrl_sys_connect()
        {
            if (com_name != "")
            {
                MessageBox.Show("Connecting to " + com_name);
                ctrl_connected = _marsCtrlSystem.Initialize(com_name, out nScreenCnt, out nSenderCnt);
                if (ctrl_connected == true)
                {
                    Trace.WriteLine("Successfully connected to the control system!");
                    ctrl_connected = true;
                    _marsCtrlSystem.GetScanBoardCount(0, out nscanCnt);
                    Trace.WriteLine("Number of scan card" + nscanCnt.ToString());
                    generate_time_parameter(out int t, out string time_var);
                    if (sql_op("insert into ALARM(alarm_id, alarm_name, alarm_description, alarm_reading, date_added,time_index) VALUES(4, 'IPS', 'Operation start', 'N/A','" + time_var + "','" + t + "')", false))
                    {
                        Trace.WriteLine("Written start operation");
                    }
                    else
                    {
                        Trace.WriteLine("Failed to write start operation");
                    }
                }
                else
                {
                    Trace.WriteLine("Failed to connect to the control system!");
                    _marsHWEnumerator.UnInitialize();
                    Nova_serivce_init();
                }
            }
            else
            {
                MessageBox.Show("Failed to detect ctrl system at any port!");
                _marsHWEnumerator.UnInitialize();
                Nova_serivce_init();
                Ctrl_sys_connect();
            }
        }
        private bool reconnect_sql()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con = new MySqlConnection(server_address + username + pass + dbname);
                    con.Open();
                    Trace.WriteLine("establish connection to database successful!");
                    return true;
                    //con.Close();
                }
                else
                {
                    Trace.WriteLine("Skipping test_sql() due to already connected to database");
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + ", Error code = " + ex.Number.ToString());
                return false;
            }
        }
        private bool sql_op(string op, bool IsRead=false)
        {
            Trace.WriteLine("op = " + op);
            if (con.State == ConnectionState.Open)
            {
                try
                {
                    //con = new MySqlConnection(server_address + username + pass + dbname);
                    //con.Open();
                    switch (IsRead)
                    {
                        case true: //read threshold,target brightness
                            MySqlCommand cmd = new MySqlCommand("select * from THRESHOLD_1", con);
                            MySqlDataReader myreader;
                            myreader = cmd.ExecuteReader();
                            while (myreader.Read())
                            {
                                threshold1 = myreader.GetInt32(0);
                                //MessageBox.Show("threshold1= " + threshold1.ToString());
                            }
                            myreader.Close();
                            Trace.WriteLine("Done read threshold1 = " + threshold1.ToString());
                            //threshold 2
                            cmd = new MySqlCommand("select * from THRESHOLD_2", con);
                            myreader = cmd.ExecuteReader();
                            while (myreader.Read())
                            {
                                threshold2 = myreader.GetInt32(0);
                                //MessageBox.Show("threshold2 = " + threshold2.ToString());

                            }
                            myreader.Close();
                            return true;
                        case false://write
                            cmd = new MySqlCommand(op, con);
                            int row_affected = cmd.ExecuteNonQuery();
                            Trace.WriteLine(row_affected.ToString() + " Recorded affected");
                            return true;
                        default:
                            Trace.WriteLine("sql_op fell into unwanted location!");
                            return false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + ", Error code = " + ex.Number.ToString());
                    return false;
                }
            }
            else
            {
                if (reconnect_sql() == true && sql_op(op, IsRead) == true)
                {
                    return true;//reconnected, run the function again and succeded
                }

                else return false; //failed to reconnect or the operation failed 
            }
        }

        private void init_sql()
        {
            try
            {
                reconnect_sql();
                if (con.State == ConnectionState.Open)
                {
                    sql_op("", true);
                    string cmd_str = "update LED_INTERNAL_TEMP set temperature=0";
                    if (sql_op(cmd_str, false))
                    {
                        Trace.WriteLine("Initalized the ITEMP table");
                    }
                    else Trace.WriteLine("faied to run " + cmd_str+".SQL exception not triggered!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + ", Error code = " + ex.Number.ToString());
            }
        }
        private void MarsCtrlSystem_RefreshHardwareStatusFinishEvent(object sender, RefreshResultEventArgs e)
        {
            //label_RefreshResult.Text = "New Invoke";
            if (!this.InvokeRequired)
            {
                if (!e.bFinishSucceed)
                {
                    Trace.WriteLine("Refresh failed.");
                    refresh_completed = false;

                }
                else
                {
                    Trace.WriteLine("Refresh succeeded.");
                    refresh_completed = true;

                }
            }
            else
            {
                RefreshResultEventHandler re = new RefreshResultEventHandler(MarsCtrlSystem_RefreshHardwareStatusFinishEvent);
                this.Invoke(re, new object[] { sender, e });
            }
        }
        void update_temp_status(int scan_idx, out float temp_out, out bool status_out)
        {
            Nova.Mars.SDK.ValueInfo temp;        
            Nova.Mars.SDK.StatusType status;
            _marsCtrlSystem.IsScanBoardWorkOK(port_number, scan_idx, out status);
            
                if (status == StatusType.OK)
                {
                    status_out = true;
                Trace.WriteLine("After out stat");
                    _marsCtrlSystem.GetScanBoardTemperature(port_number, scan_idx, out temp);
                    temp_out = temp.Value;
                Trace.WriteLine("After out temp");
            }
                else
                {
                    status_out = false;
                    abormal_board.Add(scan_idx);

                    Trace.WriteLine("Detected abnormal status at board " + scan_idx);
                    temp_out = (float)-1; //-1 means abnormal temp reader
                Trace.WriteLine("After out temp");
            }
        }

        void refresh_parameters()
        {
            while(ctrl_connected == false)
            {
                MessageBox.Show("Failed! Reconnecting to controller!");
                Ctrl_sys_connect();
                generate_time_parameter(out int t, out string datetime);
                string cmd_string = "INSERT INTO ALARM(alarm_id, alarm_name, alarm_description, alarm_reading, date_added, time_index)VALUES(1, 'Failed to connect Primary led controller', 'Failed to connect Primary led controller','N/A','" + datetime + "'," + t.ToString() + ")";
                sql_op(cmd_string);

                Thread.Sleep(5000);
            }
            while (con.State != ConnectionState.Open) //blocking function until database is ready
            {
                Trace.WriteLine("Reconnecting to database!");
                reconnect_sql();
            }
            while (ctrl_connected == true)
            {
               // MessageBox.Show("Getting data!");
                if (_marsCtrlSystem.GetBrightness(port_number, out byte brightness, out _, out _, out _))
                {
                    brightness = (byte)(brightness * 100 / 255+1);
                    Trace.WriteLine("Brightness = "+brightness.ToString());
                    brightness_label.Invoke((MethodInvoker)delegate
                    {
                        brightness_label.Text = brightness.ToString();
                    });
                    if(last_brightness!= brightness)
                    {
                        sql_op("update BRIGHTNESS set brightness = " + brightness + " ;");
                    }
                    last_brightness = brightness;
                    MySqlCommand cmd = new MySqlCommand("select brightness from BRIGHTNESS", con);
                    MySqlDataReader myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {
                        float target_brightness = (float)Math.Ceiling(myreader.GetFloat(0));
                        Trace.WriteLine("float ready");
                        _marsCtrlSystem.SetBrightness(0, (byte)(target_brightness / 100 * 255));
                        Trace.WriteLine("brightness set");
                    }
                    myreader.Close();
                }
                else
                {
                    brightness_label.Invoke((MethodInvoker)delegate
                    {
                        brightness_label.Text ="Fail to read";
                    });
                    Trace.WriteLine("Done Brightness!");
                };
                if (_marsCtrlSystem.BeginRefreshHardwareStatus())
                {
                    Trace.WriteLine("began refresh");
                    while(refresh_completed == false)
                    {
                        //block until finished refresh
                    }
                    for(int j =0;j<nscanCnt;j++)
                    //for (int j = 0; j <= nscanCnt; j++)
                    {
                        update_temp_status(j, out float temp, out bool status);
                        Trace.WriteLine("after update stat");
                        temp_list.Add((int)temp);
                        status_list.Add(status);
                    }
                    Trace.WriteLine("Dumping the content of temp list");
                    int i = 0;
                    foreach (int item in temp_list)
                    {
                        Trace.WriteLine(i.ToString() + " " + item.ToString());
                        i++;
                    }
                    Trace.WriteLine("Dumping the content of status list");
                    i = 0;
                    foreach (bool item in status_list)
                    {
                        Trace.WriteLine(i.ToString() + " " + item.ToString());
                        i++;
                    }
                    i = 0;
                    if (abormal_board.Count != 0)
                    {
                        Trace.WriteLine("Dumping the content of abnormal board");
                        foreach (var item in abormal_board)
                        {
                            Trace.WriteLine(i.ToString() + " " + item.ToString());
                            i++;
                        }
                    }
                    else Trace.WriteLine("no abnormal board detected!");
                    i = 0;
                    if (faulty_ic.Count != 0)
                    {
                        Trace.WriteLine("Dumping the content of fail ic");
                        foreach (var item in faulty_ic)
                        {
                            Trace.WriteLine(i.ToString() + " " + item.ToString());
                            i++;
                        }
                        Trace.WriteLine("Ended fail ic");
                    }
                    else Trace.WriteLine("no faulty ic detected!");
                }
                //done fetching,turn saved list into display
                update_ui();
                //send to db
                foreach(var item in temp_list)
                {
                    string cmd_str = "update LED_INTERNAL_TEMP set temperature='" + item + "'where module_id='" + temp_list.IndexOf(item) + 1+"';";
                    Trace.WriteLine(cmd_str);
                    sql_op(cmd_str);
                }
                foreach(var item in status_list)
                {
                    string item_toint;
                    if (item == true)
                        item_toint = "1";
                    else item_toint = "0";
                    string cmd_str = "update LED_INTERNAL_TEMP set status='" + item_toint + "'where module_id='" + status_list.IndexOf(item) + 1+"';";
                 //   MessageBox.Show(cmd_str);
                    sql_op(cmd_str);
                }
                if(abormal_board.Any()== false && faulty_ic.Any() == false)
                {
                    string cmd_str = "update STATUS set status = 'OK'";
                    sql_op(cmd_str);
                    Trace.WriteLine(cmd_str);
                }
                else if(abormal_board.Any() == true)
                {
                    string cmd_str = "update STATUS set status = 'ABNORMAL'";
                }
                if(temp_list.Max()>=threshold1)
                {
                   // MessageBox.Show("Max = " + temp_list.Max().ToString() + " Threshold1 = " + threshold1.ToString());
                    generate_time_parameter(out int t, out string datetime);
                    //overheat,no need shutdown
                    string cmd_str = "insert into ALARM(alarm_id,alarm_name,alarm_description,alarm_reading,date_added,time_index) VALUES (1,'Temperature over first threshold','first threshold=" + threshold1.ToString() + "', 'temperature=" + temp_list.Max().ToString() + "', '" + datetime + "'," + t.ToString() + ")";
                    Trace.WriteLine(cmd_str);
                    sql_op(cmd_str);
                    cmd_str = "update STATUS set status= 'The system is overheat but still working'";
                    sql_op(cmd_str);
                }
                if(temp_list.Max()>=threshold2)
                {
                   // MessageBox.Show("Max = " + temp_list.Max().ToString() + " Threshold2 = " + threshold2.ToString());
                    //overheat,need shutdown
                    generate_time_parameter(out int t, out string datetime);
                    string cmd_str = "insert into ALARM(alarm_id,alarm_name,alarm_description,alarm_reading,date_added,time_index) VALUES (1,'Temperature over second threshold','second threshold=" + threshold2.ToString() + "', 'temperature=" + temp_list.Max().ToString() + "', '" + datetime + "'," + t.ToString() + ")";
                    Trace.WriteLine(cmd_str);
                    sql_op(cmd_str);
                    cmd_str = "update STATUS set status= 'Overheat. Power is being cut'";
                    sql_op(cmd_str);
                    //cut power??
                }
                reset_alllist();
                Trace.WriteLine("all list resetted");
                cycle++;
                Trace.WriteLine("Cycle = :"+cycle);
                Thread.Sleep(5000); // wait 5s
                
            }
        }
        void Form1_Load(object sender, EventArgs e)
        {
            Nova_serivce_init();
           Ctrl_sys_connect();
            reconnect_sql();
            init_sql(); //initalize the table
            Trace.WriteLine("Passed initalization!");
           t1 = new Thread(refresh_parameters);
            t1.Start();
        }
       void update_ui()
       {
            List<GroupBox> groupbox_list = this.Controls.OfType<GroupBox>().ToList();
            groupbox_list.OrderBy(e => e.Name);
            groupbox_list.Reverse();
            foreach (int temp in temp_list)
            {
                var idx = temp_list.IndexOf(temp);
                groupbox_list[idx].Invoke((MethodInvoker)delegate
                {
                    groupbox_list[idx].Controls[0].Text = temp.ToString();
                });
                Trace.WriteLine(groupbox_list[idx].Controls[0].Name+" = "+temp.ToString());
            }
            foreach (bool stat in status_list)
            {
                var idx = status_list.IndexOf(stat);
                groupbox_list[idx].Invoke((MethodInvoker)delegate
                {
                    // groupbox_list[idx].Controls[1].Text = stat.ToString();
                    if(stat== true)
                    {
                        groupbox_list[idx].Controls[1].Text = "OK";
                    }
                    else
                    {
                        groupbox_list[idx].Controls[1].Text = "Abnormal";
                    }
                });
                Trace.WriteLine(groupbox_list[idx].Controls[1].Name + " = " + stat.ToString());
            }
       }


        void generate_time_parameter(out int t,out string datetime)
        {
            TimeSpan time = DateTime.UtcNow - new DateTime(1970, 1, 1);
            t = (int)time.TotalSeconds;
            DateTime now = DateTime.Now;
            datetime = now.ToString("yyyy-MM-dd H:mm:ss");
        }
        void reset_alllist()    // reset all list after updating database
        {
            temp_list = new List<int>();
            status_list = new List<bool>();
            abormal_board = new List<int>();
            faulty_ic = new List<int>();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_marsCtrlSystem.UnInitialize())
            {
                MessageBox.Show("Control system disconnected!");
            }
            if (_marsHWEnumerator.UnInitialize())
            {
                MessageBox.Show("Mars service uninitalized!");
            }
            try
            {
                con.Close();
                Process[] proc = Process.GetProcessesByName("MarsServerProvider");
                proc[0].Kill();
                System.Environment.Exit(0);
            }
            catch
            {
                //nothing to do
            }

        }
    }
}
