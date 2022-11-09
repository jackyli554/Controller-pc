using System.Collections.Generic;
using System.Reflection.Emit;

namespace led_test_using_form
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.brightness_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.temp0_11 = new System.Windows.Forms.Label();
            this.status0_11 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.temp0_10 = new System.Windows.Forms.Label();
            this.status0_10 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.temp0_9 = new System.Windows.Forms.Label();
            this.status0_9 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.temp0_8 = new System.Windows.Forms.Label();
            this.status0_8 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.temp0_7 = new System.Windows.Forms.Label();
            this.status0_7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.temp0_6 = new System.Windows.Forms.Label();
            this.status0_6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.temp0_5 = new System.Windows.Forms.Label();
            this.status0_5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.temp0_4 = new System.Windows.Forms.Label();
            this.status0_4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.temp0_3 = new System.Windows.Forms.Label();
            this.status0_3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.temp0_2 = new System.Windows.Forms.Label();
            this.status0_2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.temp0_1 = new System.Windows.Forms.Label();
            this.status0_1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temp0_0 = new System.Windows.Forms.Label();
            this.status0 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.groupBox43 = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox45 = new System.Windows.Forms.GroupBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.groupBox46 = new System.Windows.Forms.GroupBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.groupBox47 = new System.Windows.Forms.GroupBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.groupBox48 = new System.Windows.Forms.GroupBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.groupBox49 = new System.Windows.Forms.GroupBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox50 = new System.Windows.Forms.GroupBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.groupBox51 = new System.Windows.Forms.GroupBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.groupBox52 = new System.Windows.Forms.GroupBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.groupBox53 = new System.Windows.Forms.GroupBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.groupBox54 = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.groupBox55 = new System.Windows.Forms.GroupBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.groupBox56 = new System.Windows.Forms.GroupBox();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.groupBox57 = new System.Windows.Forms.GroupBox();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.groupBox58 = new System.Windows.Forms.GroupBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.groupBox59 = new System.Windows.Forms.GroupBox();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.groupBox60 = new System.Windows.Forms.GroupBox();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.groupBox61 = new System.Windows.Forms.GroupBox();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.groupBox62 = new System.Windows.Forms.GroupBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.groupBox63 = new System.Windows.Forms.GroupBox();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.groupBox64 = new System.Windows.Forms.GroupBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.groupBox65 = new System.Windows.Forms.GroupBox();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.groupBox66 = new System.Windows.Forms.GroupBox();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.groupBox67 = new System.Windows.Forms.GroupBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.groupBox68 = new System.Windows.Forms.GroupBox();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.groupBox69 = new System.Windows.Forms.GroupBox();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.groupBox70 = new System.Windows.Forms.GroupBox();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.groupBox71 = new System.Windows.Forms.GroupBox();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.groupBox72 = new System.Windows.Forms.GroupBox();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.groupBox40.SuspendLayout();
            this.groupBox41.SuspendLayout();
            this.groupBox42.SuspendLayout();
            this.groupBox43.SuspendLayout();
            this.groupBox44.SuspendLayout();
            this.groupBox45.SuspendLayout();
            this.groupBox46.SuspendLayout();
            this.groupBox47.SuspendLayout();
            this.groupBox48.SuspendLayout();
            this.groupBox49.SuspendLayout();
            this.groupBox50.SuspendLayout();
            this.groupBox51.SuspendLayout();
            this.groupBox52.SuspendLayout();
            this.groupBox53.SuspendLayout();
            this.groupBox54.SuspendLayout();
            this.groupBox55.SuspendLayout();
            this.groupBox56.SuspendLayout();
            this.groupBox57.SuspendLayout();
            this.groupBox58.SuspendLayout();
            this.groupBox59.SuspendLayout();
            this.groupBox60.SuspendLayout();
            this.groupBox61.SuspendLayout();
            this.groupBox62.SuspendLayout();
            this.groupBox63.SuspendLayout();
            this.groupBox64.SuspendLayout();
            this.groupBox65.SuspendLayout();
            this.groupBox66.SuspendLayout();
            this.groupBox67.SuspendLayout();
            this.groupBox68.SuspendLayout();
            this.groupBox69.SuspendLayout();
            this.groupBox70.SuspendLayout();
            this.groupBox71.SuspendLayout();
            this.groupBox72.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightness_label
            // 
            this.brightness_label.AutoSize = true;
            this.brightness_label.Location = new System.Drawing.Point(124, 20);
            this.brightness_label.Name = "brightness_label";
            this.brightness_label.Size = new System.Drawing.Size(11, 12);
            this.brightness_label.TabIndex = 259;
            this.brightness_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 258;
            this.label1.Text = "brightness:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.temp0_11);
            this.groupBox12.Controls.Add(this.status0_11);
            this.groupBox12.Location = new System.Drawing.Point(592, 46);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(42, 62);
            this.groupBox12.TabIndex = 194;
            this.groupBox12.TabStop = false;
            // 
            // temp0_11
            // 
            this.temp0_11.AutoSize = true;
            this.temp0_11.Location = new System.Drawing.Point(6, 18);
            this.temp0_11.Name = "temp0_11";
            this.temp0_11.Size = new System.Drawing.Size(11, 12);
            this.temp0_11.TabIndex = 12;
            this.temp0_11.Text = "0";
            // 
            // status0_11
            // 
            this.status0_11.AutoSize = true;
            this.status0_11.Location = new System.Drawing.Point(5, 42);
            this.status0_11.Name = "status0_11";
            this.status0_11.Size = new System.Drawing.Size(22, 12);
            this.status0_11.TabIndex = 22;
            this.status0_11.Text = "Fail";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.temp0_10);
            this.groupBox11.Controls.Add(this.status0_10);
            this.groupBox11.Location = new System.Drawing.Point(544, 46);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(42, 62);
            this.groupBox11.TabIndex = 193;
            this.groupBox11.TabStop = false;
            // 
            // temp0_10
            // 
            this.temp0_10.AutoSize = true;
            this.temp0_10.Location = new System.Drawing.Point(6, 18);
            this.temp0_10.Name = "temp0_10";
            this.temp0_10.Size = new System.Drawing.Size(11, 12);
            this.temp0_10.TabIndex = 12;
            this.temp0_10.Text = "0";
            // 
            // status0_10
            // 
            this.status0_10.AutoSize = true;
            this.status0_10.Location = new System.Drawing.Point(5, 42);
            this.status0_10.Name = "status0_10";
            this.status0_10.Size = new System.Drawing.Size(22, 12);
            this.status0_10.TabIndex = 22;
            this.status0_10.Text = "Fail";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.temp0_9);
            this.groupBox10.Controls.Add(this.status0_9);
            this.groupBox10.Location = new System.Drawing.Point(496, 46);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(42, 62);
            this.groupBox10.TabIndex = 192;
            this.groupBox10.TabStop = false;
            // 
            // temp0_9
            // 
            this.temp0_9.AutoSize = true;
            this.temp0_9.Location = new System.Drawing.Point(6, 18);
            this.temp0_9.Name = "temp0_9";
            this.temp0_9.Size = new System.Drawing.Size(11, 12);
            this.temp0_9.TabIndex = 12;
            this.temp0_9.Text = "0";
            // 
            // status0_9
            // 
            this.status0_9.AutoSize = true;
            this.status0_9.Location = new System.Drawing.Point(5, 42);
            this.status0_9.Name = "status0_9";
            this.status0_9.Size = new System.Drawing.Size(22, 12);
            this.status0_9.TabIndex = 22;
            this.status0_9.Text = "Fail";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.temp0_8);
            this.groupBox9.Controls.Add(this.status0_8);
            this.groupBox9.Location = new System.Drawing.Point(448, 46);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(42, 62);
            this.groupBox9.TabIndex = 191;
            this.groupBox9.TabStop = false;
            // 
            // temp0_8
            // 
            this.temp0_8.AutoSize = true;
            this.temp0_8.Location = new System.Drawing.Point(6, 18);
            this.temp0_8.Name = "temp0_8";
            this.temp0_8.Size = new System.Drawing.Size(11, 12);
            this.temp0_8.TabIndex = 12;
            this.temp0_8.Text = "0";
            // 
            // status0_8
            // 
            this.status0_8.AutoSize = true;
            this.status0_8.Location = new System.Drawing.Point(5, 42);
            this.status0_8.Name = "status0_8";
            this.status0_8.Size = new System.Drawing.Size(22, 12);
            this.status0_8.TabIndex = 22;
            this.status0_8.Text = "Fail";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.temp0_7);
            this.groupBox8.Controls.Add(this.status0_7);
            this.groupBox8.Location = new System.Drawing.Point(400, 46);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(42, 62);
            this.groupBox8.TabIndex = 190;
            this.groupBox8.TabStop = false;
            // 
            // temp0_7
            // 
            this.temp0_7.AutoSize = true;
            this.temp0_7.Location = new System.Drawing.Point(6, 18);
            this.temp0_7.Name = "temp0_7";
            this.temp0_7.Size = new System.Drawing.Size(11, 12);
            this.temp0_7.TabIndex = 12;
            this.temp0_7.Text = "0";
            // 
            // status0_7
            // 
            this.status0_7.AutoSize = true;
            this.status0_7.Location = new System.Drawing.Point(5, 42);
            this.status0_7.Name = "status0_7";
            this.status0_7.Size = new System.Drawing.Size(22, 12);
            this.status0_7.TabIndex = 22;
            this.status0_7.Text = "Fail";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.temp0_6);
            this.groupBox7.Controls.Add(this.status0_6);
            this.groupBox7.Location = new System.Drawing.Point(352, 46);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(42, 62);
            this.groupBox7.TabIndex = 189;
            this.groupBox7.TabStop = false;
            // 
            // temp0_6
            // 
            this.temp0_6.AutoSize = true;
            this.temp0_6.Location = new System.Drawing.Point(6, 18);
            this.temp0_6.Name = "temp0_6";
            this.temp0_6.Size = new System.Drawing.Size(11, 12);
            this.temp0_6.TabIndex = 12;
            this.temp0_6.Text = "0";
            // 
            // status0_6
            // 
            this.status0_6.AutoSize = true;
            this.status0_6.Location = new System.Drawing.Point(5, 42);
            this.status0_6.Name = "status0_6";
            this.status0_6.Size = new System.Drawing.Size(22, 12);
            this.status0_6.TabIndex = 22;
            this.status0_6.Text = "Fail";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.temp0_5);
            this.groupBox6.Controls.Add(this.status0_5);
            this.groupBox6.Location = new System.Drawing.Point(304, 46);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(42, 62);
            this.groupBox6.TabIndex = 188;
            this.groupBox6.TabStop = false;
            // 
            // temp0_5
            // 
            this.temp0_5.AutoSize = true;
            this.temp0_5.Location = new System.Drawing.Point(6, 18);
            this.temp0_5.Name = "temp0_5";
            this.temp0_5.Size = new System.Drawing.Size(11, 12);
            this.temp0_5.TabIndex = 12;
            this.temp0_5.Text = "0";
            // 
            // status0_5
            // 
            this.status0_5.AutoSize = true;
            this.status0_5.Location = new System.Drawing.Point(5, 42);
            this.status0_5.Name = "status0_5";
            this.status0_5.Size = new System.Drawing.Size(22, 12);
            this.status0_5.TabIndex = 22;
            this.status0_5.Text = "Fail";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.temp0_4);
            this.groupBox5.Controls.Add(this.status0_4);
            this.groupBox5.Location = new System.Drawing.Point(256, 46);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(42, 62);
            this.groupBox5.TabIndex = 187;
            this.groupBox5.TabStop = false;
            // 
            // temp0_4
            // 
            this.temp0_4.AutoSize = true;
            this.temp0_4.Location = new System.Drawing.Point(6, 18);
            this.temp0_4.Name = "temp0_4";
            this.temp0_4.Size = new System.Drawing.Size(11, 12);
            this.temp0_4.TabIndex = 12;
            this.temp0_4.Text = "0";
            // 
            // status0_4
            // 
            this.status0_4.AutoSize = true;
            this.status0_4.Location = new System.Drawing.Point(5, 42);
            this.status0_4.Name = "status0_4";
            this.status0_4.Size = new System.Drawing.Size(22, 12);
            this.status0_4.TabIndex = 22;
            this.status0_4.Text = "Fail";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.temp0_3);
            this.groupBox4.Controls.Add(this.status0_3);
            this.groupBox4.Location = new System.Drawing.Point(208, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(42, 62);
            this.groupBox4.TabIndex = 197;
            this.groupBox4.TabStop = false;
            // 
            // temp0_3
            // 
            this.temp0_3.AutoSize = true;
            this.temp0_3.Location = new System.Drawing.Point(6, 18);
            this.temp0_3.Name = "temp0_3";
            this.temp0_3.Size = new System.Drawing.Size(11, 12);
            this.temp0_3.TabIndex = 12;
            this.temp0_3.Text = "0";
            // 
            // status0_3
            // 
            this.status0_3.AutoSize = true;
            this.status0_3.Location = new System.Drawing.Point(5, 42);
            this.status0_3.Name = "status0_3";
            this.status0_3.Size = new System.Drawing.Size(22, 12);
            this.status0_3.TabIndex = 22;
            this.status0_3.Text = "Fail";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.temp0_2);
            this.groupBox3.Controls.Add(this.status0_2);
            this.groupBox3.Location = new System.Drawing.Point(156, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(42, 62);
            this.groupBox3.TabIndex = 196;
            this.groupBox3.TabStop = false;
            // 
            // temp0_2
            // 
            this.temp0_2.AutoSize = true;
            this.temp0_2.Location = new System.Drawing.Point(6, 18);
            this.temp0_2.Name = "temp0_2";
            this.temp0_2.Size = new System.Drawing.Size(11, 12);
            this.temp0_2.TabIndex = 12;
            this.temp0_2.Text = "0";
            // 
            // status0_2
            // 
            this.status0_2.AutoSize = true;
            this.status0_2.Location = new System.Drawing.Point(5, 42);
            this.status0_2.Name = "status0_2";
            this.status0_2.Size = new System.Drawing.Size(22, 12);
            this.status0_2.TabIndex = 22;
            this.status0_2.Text = "Fail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.temp0_1);
            this.groupBox2.Controls.Add(this.status0_1);
            this.groupBox2.Location = new System.Drawing.Point(108, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(42, 62);
            this.groupBox2.TabIndex = 195;
            this.groupBox2.TabStop = false;
            // 
            // temp0_1
            // 
            this.temp0_1.AutoSize = true;
            this.temp0_1.Location = new System.Drawing.Point(6, 18);
            this.temp0_1.Name = "temp0_1";
            this.temp0_1.Size = new System.Drawing.Size(11, 12);
            this.temp0_1.TabIndex = 12;
            this.temp0_1.Text = "0";
            // 
            // status0_1
            // 
            this.status0_1.AutoSize = true;
            this.status0_1.Location = new System.Drawing.Point(5, 42);
            this.status0_1.Name = "status0_1";
            this.status0_1.Size = new System.Drawing.Size(22, 12);
            this.status0_1.TabIndex = 22;
            this.status0_1.Text = "Fail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.temp0_0);
            this.groupBox1.Controls.Add(this.status0);
            this.groupBox1.Location = new System.Drawing.Point(60, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(42, 62);
            this.groupBox1.TabIndex = 186;
            this.groupBox1.TabStop = false;
            // 
            // temp0_0
            // 
            this.temp0_0.AutoSize = true;
            this.temp0_0.Location = new System.Drawing.Point(6, 18);
            this.temp0_0.Name = "temp0_0";
            this.temp0_0.Size = new System.Drawing.Size(11, 12);
            this.temp0_0.TabIndex = 12;
            this.temp0_0.Text = "0";
            // 
            // status0
            // 
            this.status0.AutoSize = true;
            this.status0.Location = new System.Drawing.Point(5, 42);
            this.status0.Name = "status0";
            this.status0.Size = new System.Drawing.Size(22, 12);
            this.status0.TabIndex = 22;
            this.status0.Text = "Fail";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label2);
            this.groupBox13.Controls.Add(this.label3);
            this.groupBox13.Location = new System.Drawing.Point(60, 114);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(42, 62);
            this.groupBox13.TabIndex = 187;
            this.groupBox13.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fail";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label4);
            this.groupBox14.Controls.Add(this.label5);
            this.groupBox14.Location = new System.Drawing.Point(108, 114);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(42, 62);
            this.groupBox14.TabIndex = 196;
            this.groupBox14.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fail";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label6);
            this.groupBox15.Controls.Add(this.label7);
            this.groupBox15.Location = new System.Drawing.Point(156, 114);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(42, 62);
            this.groupBox15.TabIndex = 196;
            this.groupBox15.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fail";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label8);
            this.groupBox16.Controls.Add(this.label9);
            this.groupBox16.Location = new System.Drawing.Point(208, 114);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(42, 62);
            this.groupBox16.TabIndex = 196;
            this.groupBox16.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fail";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label10);
            this.groupBox17.Controls.Add(this.label11);
            this.groupBox17.Location = new System.Drawing.Point(256, 114);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(42, 62);
            this.groupBox17.TabIndex = 197;
            this.groupBox17.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fail";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label12);
            this.groupBox18.Controls.Add(this.label13);
            this.groupBox18.Location = new System.Drawing.Point(304, 114);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(42, 62);
            this.groupBox18.TabIndex = 197;
            this.groupBox18.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "Fail";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label14);
            this.groupBox19.Controls.Add(this.label15);
            this.groupBox19.Location = new System.Drawing.Point(352, 114);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(42, 62);
            this.groupBox19.TabIndex = 197;
            this.groupBox19.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 12);
            this.label15.TabIndex = 22;
            this.label15.Text = "Fail";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.label16);
            this.groupBox20.Controls.Add(this.label17);
            this.groupBox20.Location = new System.Drawing.Point(400, 114);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(42, 62);
            this.groupBox20.TabIndex = 197;
            this.groupBox20.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 12;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 12);
            this.label17.TabIndex = 22;
            this.label17.Text = "Fail";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label18);
            this.groupBox21.Controls.Add(this.label19);
            this.groupBox21.Location = new System.Drawing.Point(448, 114);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(42, 62);
            this.groupBox21.TabIndex = 197;
            this.groupBox21.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "Fail";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.label20);
            this.groupBox22.Controls.Add(this.label21);
            this.groupBox22.Location = new System.Drawing.Point(496, 114);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(42, 62);
            this.groupBox22.TabIndex = 197;
            this.groupBox22.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 12);
            this.label20.TabIndex = 12;
            this.label20.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 12);
            this.label21.TabIndex = 22;
            this.label21.Text = "Fail";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label22);
            this.groupBox23.Controls.Add(this.label23);
            this.groupBox23.Location = new System.Drawing.Point(544, 114);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(42, 62);
            this.groupBox23.TabIndex = 197;
            this.groupBox23.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 12);
            this.label22.TabIndex = 12;
            this.label22.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 12);
            this.label23.TabIndex = 22;
            this.label23.Text = "Fail";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.label24);
            this.groupBox24.Controls.Add(this.label25);
            this.groupBox24.Location = new System.Drawing.Point(592, 114);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(42, 62);
            this.groupBox24.TabIndex = 197;
            this.groupBox24.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(11, 12);
            this.label24.TabIndex = 12;
            this.label24.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 12);
            this.label25.TabIndex = 22;
            this.label25.Text = "Fail";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.label26);
            this.groupBox25.Controls.Add(this.label27);
            this.groupBox25.Location = new System.Drawing.Point(60, 182);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(42, 62);
            this.groupBox25.TabIndex = 197;
            this.groupBox25.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(11, 12);
            this.label26.TabIndex = 12;
            this.label26.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 12);
            this.label27.TabIndex = 22;
            this.label27.Text = "Fail";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.label28);
            this.groupBox26.Controls.Add(this.label29);
            this.groupBox26.Location = new System.Drawing.Point(108, 182);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(42, 62);
            this.groupBox26.TabIndex = 197;
            this.groupBox26.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(11, 12);
            this.label28.TabIndex = 12;
            this.label28.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 42);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 12);
            this.label29.TabIndex = 22;
            this.label29.Text = "Fail";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.label30);
            this.groupBox27.Controls.Add(this.label31);
            this.groupBox27.Location = new System.Drawing.Point(156, 182);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(42, 62);
            this.groupBox27.TabIndex = 197;
            this.groupBox27.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 18);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(11, 12);
            this.label30.TabIndex = 12;
            this.label30.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 42);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(22, 12);
            this.label31.TabIndex = 22;
            this.label31.Text = "Fail";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.label32);
            this.groupBox28.Controls.Add(this.label33);
            this.groupBox28.Location = new System.Drawing.Point(208, 182);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(42, 62);
            this.groupBox28.TabIndex = 197;
            this.groupBox28.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(11, 12);
            this.label32.TabIndex = 12;
            this.label32.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(5, 42);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(22, 12);
            this.label33.TabIndex = 22;
            this.label33.Text = "Fail";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.label34);
            this.groupBox29.Controls.Add(this.label35);
            this.groupBox29.Location = new System.Drawing.Point(256, 182);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(42, 62);
            this.groupBox29.TabIndex = 197;
            this.groupBox29.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 18);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(11, 12);
            this.label34.TabIndex = 12;
            this.label34.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(5, 42);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(22, 12);
            this.label35.TabIndex = 22;
            this.label35.Text = "Fail";
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.label36);
            this.groupBox30.Controls.Add(this.label37);
            this.groupBox30.Location = new System.Drawing.Point(304, 182);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(42, 62);
            this.groupBox30.TabIndex = 197;
            this.groupBox30.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 18);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(11, 12);
            this.label36.TabIndex = 12;
            this.label36.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(5, 42);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(22, 12);
            this.label37.TabIndex = 22;
            this.label37.Text = "Fail";
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.label38);
            this.groupBox31.Controls.Add(this.label39);
            this.groupBox31.Location = new System.Drawing.Point(352, 182);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(42, 62);
            this.groupBox31.TabIndex = 197;
            this.groupBox31.TabStop = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(11, 12);
            this.label38.TabIndex = 12;
            this.label38.Text = "0";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(5, 42);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(22, 12);
            this.label39.TabIndex = 22;
            this.label39.Text = "Fail";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.label40);
            this.groupBox32.Controls.Add(this.label41);
            this.groupBox32.Location = new System.Drawing.Point(400, 182);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(42, 62);
            this.groupBox32.TabIndex = 197;
            this.groupBox32.TabStop = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 18);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(11, 12);
            this.label40.TabIndex = 12;
            this.label40.Text = "0";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(5, 42);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(22, 12);
            this.label41.TabIndex = 22;
            this.label41.Text = "Fail";
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.label42);
            this.groupBox33.Controls.Add(this.label43);
            this.groupBox33.Location = new System.Drawing.Point(448, 182);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(42, 62);
            this.groupBox33.TabIndex = 197;
            this.groupBox33.TabStop = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 18);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(11, 12);
            this.label42.TabIndex = 12;
            this.label42.Text = "0";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(5, 42);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(22, 12);
            this.label43.TabIndex = 22;
            this.label43.Text = "Fail";
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.label44);
            this.groupBox34.Controls.Add(this.label45);
            this.groupBox34.Location = new System.Drawing.Point(496, 182);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(42, 62);
            this.groupBox34.TabIndex = 197;
            this.groupBox34.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 18);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(11, 12);
            this.label44.TabIndex = 12;
            this.label44.Text = "0";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(5, 42);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(22, 12);
            this.label45.TabIndex = 22;
            this.label45.Text = "Fail";
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.label46);
            this.groupBox35.Controls.Add(this.label47);
            this.groupBox35.Location = new System.Drawing.Point(544, 182);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(42, 62);
            this.groupBox35.TabIndex = 197;
            this.groupBox35.TabStop = false;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 18);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(11, 12);
            this.label46.TabIndex = 12;
            this.label46.Text = "0";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(5, 42);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(22, 12);
            this.label47.TabIndex = 22;
            this.label47.Text = "Fail";
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.label48);
            this.groupBox36.Controls.Add(this.label49);
            this.groupBox36.Location = new System.Drawing.Point(592, 182);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(42, 62);
            this.groupBox36.TabIndex = 197;
            this.groupBox36.TabStop = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 18);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(11, 12);
            this.label48.TabIndex = 12;
            this.label48.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(5, 42);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(22, 12);
            this.label49.TabIndex = 22;
            this.label49.Text = "Fail";
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.label50);
            this.groupBox37.Controls.Add(this.label51);
            this.groupBox37.Location = new System.Drawing.Point(60, 259);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(42, 62);
            this.groupBox37.TabIndex = 197;
            this.groupBox37.TabStop = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 18);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(11, 12);
            this.label50.TabIndex = 12;
            this.label50.Text = "0";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(5, 42);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(22, 12);
            this.label51.TabIndex = 22;
            this.label51.Text = "Fail";
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.label52);
            this.groupBox38.Controls.Add(this.label53);
            this.groupBox38.Location = new System.Drawing.Point(108, 259);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(42, 62);
            this.groupBox38.TabIndex = 197;
            this.groupBox38.TabStop = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 18);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(11, 12);
            this.label52.TabIndex = 12;
            this.label52.Text = "0";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(5, 42);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(22, 12);
            this.label53.TabIndex = 22;
            this.label53.Text = "Fail";
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.label54);
            this.groupBox39.Controls.Add(this.label55);
            this.groupBox39.Location = new System.Drawing.Point(156, 259);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(42, 62);
            this.groupBox39.TabIndex = 197;
            this.groupBox39.TabStop = false;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 18);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(11, 12);
            this.label54.TabIndex = 12;
            this.label54.Text = "0";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(5, 42);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(22, 12);
            this.label55.TabIndex = 22;
            this.label55.Text = "Fail";
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.label56);
            this.groupBox40.Controls.Add(this.label57);
            this.groupBox40.Location = new System.Drawing.Point(208, 259);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Size = new System.Drawing.Size(42, 62);
            this.groupBox40.TabIndex = 197;
            this.groupBox40.TabStop = false;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 18);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(11, 12);
            this.label56.TabIndex = 12;
            this.label56.Text = "0";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(5, 42);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(22, 12);
            this.label57.TabIndex = 22;
            this.label57.Text = "Fail";
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.label58);
            this.groupBox41.Controls.Add(this.label59);
            this.groupBox41.Location = new System.Drawing.Point(256, 259);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Size = new System.Drawing.Size(42, 62);
            this.groupBox41.TabIndex = 197;
            this.groupBox41.TabStop = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 18);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(11, 12);
            this.label58.TabIndex = 12;
            this.label58.Text = "0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(5, 42);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(22, 12);
            this.label59.TabIndex = 22;
            this.label59.Text = "Fail";
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.label60);
            this.groupBox42.Controls.Add(this.label61);
            this.groupBox42.Location = new System.Drawing.Point(304, 259);
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.Size = new System.Drawing.Size(42, 62);
            this.groupBox42.TabIndex = 197;
            this.groupBox42.TabStop = false;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(6, 18);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(11, 12);
            this.label60.TabIndex = 12;
            this.label60.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(5, 42);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(22, 12);
            this.label61.TabIndex = 22;
            this.label61.Text = "Fail";
            // 
            // groupBox43
            // 
            this.groupBox43.Controls.Add(this.label62);
            this.groupBox43.Controls.Add(this.label63);
            this.groupBox43.Location = new System.Drawing.Point(352, 259);
            this.groupBox43.Name = "groupBox43";
            this.groupBox43.Size = new System.Drawing.Size(42, 62);
            this.groupBox43.TabIndex = 197;
            this.groupBox43.TabStop = false;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 18);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(11, 12);
            this.label62.TabIndex = 12;
            this.label62.Text = "0";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(5, 42);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(22, 12);
            this.label63.TabIndex = 22;
            this.label63.Text = "Fail";
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.label64);
            this.groupBox44.Controls.Add(this.label65);
            this.groupBox44.Location = new System.Drawing.Point(400, 259);
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.Size = new System.Drawing.Size(42, 62);
            this.groupBox44.TabIndex = 197;
            this.groupBox44.TabStop = false;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 18);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(11, 12);
            this.label64.TabIndex = 12;
            this.label64.Text = "0";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(5, 42);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(22, 12);
            this.label65.TabIndex = 22;
            this.label65.Text = "Fail";
            // 
            // groupBox45
            // 
            this.groupBox45.Controls.Add(this.label66);
            this.groupBox45.Controls.Add(this.label67);
            this.groupBox45.Location = new System.Drawing.Point(448, 259);
            this.groupBox45.Name = "groupBox45";
            this.groupBox45.Size = new System.Drawing.Size(42, 62);
            this.groupBox45.TabIndex = 197;
            this.groupBox45.TabStop = false;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 18);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(11, 12);
            this.label66.TabIndex = 12;
            this.label66.Text = "0";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(5, 42);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(22, 12);
            this.label67.TabIndex = 22;
            this.label67.Text = "Fail";
            // 
            // groupBox46
            // 
            this.groupBox46.Controls.Add(this.label68);
            this.groupBox46.Controls.Add(this.label69);
            this.groupBox46.Location = new System.Drawing.Point(496, 259);
            this.groupBox46.Name = "groupBox46";
            this.groupBox46.Size = new System.Drawing.Size(42, 62);
            this.groupBox46.TabIndex = 197;
            this.groupBox46.TabStop = false;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 18);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(11, 12);
            this.label68.TabIndex = 12;
            this.label68.Text = "0";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(5, 42);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(22, 12);
            this.label69.TabIndex = 22;
            this.label69.Text = "Fail";
            // 
            // groupBox47
            // 
            this.groupBox47.Controls.Add(this.label70);
            this.groupBox47.Controls.Add(this.label71);
            this.groupBox47.Location = new System.Drawing.Point(544, 259);
            this.groupBox47.Name = "groupBox47";
            this.groupBox47.Size = new System.Drawing.Size(42, 62);
            this.groupBox47.TabIndex = 197;
            this.groupBox47.TabStop = false;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(6, 18);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(11, 12);
            this.label70.TabIndex = 12;
            this.label70.Text = "0";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(5, 42);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(22, 12);
            this.label71.TabIndex = 22;
            this.label71.Text = "Fail";
            // 
            // groupBox48
            // 
            this.groupBox48.Controls.Add(this.label72);
            this.groupBox48.Controls.Add(this.label73);
            this.groupBox48.Location = new System.Drawing.Point(592, 259);
            this.groupBox48.Name = "groupBox48";
            this.groupBox48.Size = new System.Drawing.Size(42, 62);
            this.groupBox48.TabIndex = 197;
            this.groupBox48.TabStop = false;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(6, 18);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(11, 12);
            this.label72.TabIndex = 12;
            this.label72.Text = "0";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(5, 42);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(22, 12);
            this.label73.TabIndex = 22;
            this.label73.Text = "Fail";
            // 
            // groupBox49
            // 
            this.groupBox49.Controls.Add(this.label74);
            this.groupBox49.Controls.Add(this.label75);
            this.groupBox49.Location = new System.Drawing.Point(60, 338);
            this.groupBox49.Name = "groupBox49";
            this.groupBox49.Size = new System.Drawing.Size(42, 62);
            this.groupBox49.TabIndex = 197;
            this.groupBox49.TabStop = false;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(6, 18);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(11, 12);
            this.label74.TabIndex = 12;
            this.label74.Text = "0";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(5, 42);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(22, 12);
            this.label75.TabIndex = 22;
            this.label75.Text = "Fail";
            // 
            // groupBox50
            // 
            this.groupBox50.Controls.Add(this.label76);
            this.groupBox50.Controls.Add(this.label77);
            this.groupBox50.Location = new System.Drawing.Point(108, 338);
            this.groupBox50.Name = "groupBox50";
            this.groupBox50.Size = new System.Drawing.Size(42, 62);
            this.groupBox50.TabIndex = 197;
            this.groupBox50.TabStop = false;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(6, 18);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(11, 12);
            this.label76.TabIndex = 12;
            this.label76.Text = "0";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(5, 42);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(22, 12);
            this.label77.TabIndex = 22;
            this.label77.Text = "Fail";
            // 
            // groupBox51
            // 
            this.groupBox51.Controls.Add(this.label78);
            this.groupBox51.Controls.Add(this.label79);
            this.groupBox51.Location = new System.Drawing.Point(156, 338);
            this.groupBox51.Name = "groupBox51";
            this.groupBox51.Size = new System.Drawing.Size(42, 62);
            this.groupBox51.TabIndex = 197;
            this.groupBox51.TabStop = false;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(6, 18);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(11, 12);
            this.label78.TabIndex = 12;
            this.label78.Text = "0";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(5, 42);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(22, 12);
            this.label79.TabIndex = 22;
            this.label79.Text = "Fail";
            // 
            // groupBox52
            // 
            this.groupBox52.Controls.Add(this.label80);
            this.groupBox52.Controls.Add(this.label81);
            this.groupBox52.Location = new System.Drawing.Point(208, 338);
            this.groupBox52.Name = "groupBox52";
            this.groupBox52.Size = new System.Drawing.Size(42, 62);
            this.groupBox52.TabIndex = 197;
            this.groupBox52.TabStop = false;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(6, 18);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(11, 12);
            this.label80.TabIndex = 12;
            this.label80.Text = "0";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(5, 42);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(22, 12);
            this.label81.TabIndex = 22;
            this.label81.Text = "Fail";
            // 
            // groupBox53
            // 
            this.groupBox53.Controls.Add(this.label82);
            this.groupBox53.Controls.Add(this.label83);
            this.groupBox53.Location = new System.Drawing.Point(256, 338);
            this.groupBox53.Name = "groupBox53";
            this.groupBox53.Size = new System.Drawing.Size(42, 62);
            this.groupBox53.TabIndex = 197;
            this.groupBox53.TabStop = false;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(6, 18);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(11, 12);
            this.label82.TabIndex = 12;
            this.label82.Text = "0";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(5, 42);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(22, 12);
            this.label83.TabIndex = 22;
            this.label83.Text = "Fail";
            // 
            // groupBox54
            // 
            this.groupBox54.Controls.Add(this.label84);
            this.groupBox54.Controls.Add(this.label85);
            this.groupBox54.Location = new System.Drawing.Point(304, 338);
            this.groupBox54.Name = "groupBox54";
            this.groupBox54.Size = new System.Drawing.Size(42, 62);
            this.groupBox54.TabIndex = 197;
            this.groupBox54.TabStop = false;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(6, 18);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(11, 12);
            this.label84.TabIndex = 12;
            this.label84.Text = "0";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(5, 42);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(22, 12);
            this.label85.TabIndex = 22;
            this.label85.Text = "Fail";
            // 
            // groupBox55
            // 
            this.groupBox55.Controls.Add(this.label86);
            this.groupBox55.Controls.Add(this.label87);
            this.groupBox55.Location = new System.Drawing.Point(352, 338);
            this.groupBox55.Name = "groupBox55";
            this.groupBox55.Size = new System.Drawing.Size(42, 62);
            this.groupBox55.TabIndex = 197;
            this.groupBox55.TabStop = false;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(6, 18);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(11, 12);
            this.label86.TabIndex = 12;
            this.label86.Text = "0";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(5, 42);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(22, 12);
            this.label87.TabIndex = 22;
            this.label87.Text = "Fail";
            // 
            // groupBox56
            // 
            this.groupBox56.Controls.Add(this.label88);
            this.groupBox56.Controls.Add(this.label89);
            this.groupBox56.Location = new System.Drawing.Point(400, 338);
            this.groupBox56.Name = "groupBox56";
            this.groupBox56.Size = new System.Drawing.Size(42, 62);
            this.groupBox56.TabIndex = 197;
            this.groupBox56.TabStop = false;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(6, 18);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(11, 12);
            this.label88.TabIndex = 12;
            this.label88.Text = "0";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(5, 42);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(22, 12);
            this.label89.TabIndex = 22;
            this.label89.Text = "Fail";
            // 
            // groupBox57
            // 
            this.groupBox57.Controls.Add(this.label90);
            this.groupBox57.Controls.Add(this.label91);
            this.groupBox57.Location = new System.Drawing.Point(448, 338);
            this.groupBox57.Name = "groupBox57";
            this.groupBox57.Size = new System.Drawing.Size(42, 62);
            this.groupBox57.TabIndex = 197;
            this.groupBox57.TabStop = false;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(6, 18);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(11, 12);
            this.label90.TabIndex = 12;
            this.label90.Text = "0";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(5, 42);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(22, 12);
            this.label91.TabIndex = 22;
            this.label91.Text = "Fail";
            // 
            // groupBox58
            // 
            this.groupBox58.Controls.Add(this.label92);
            this.groupBox58.Controls.Add(this.label93);
            this.groupBox58.Location = new System.Drawing.Point(496, 338);
            this.groupBox58.Name = "groupBox58";
            this.groupBox58.Size = new System.Drawing.Size(42, 62);
            this.groupBox58.TabIndex = 197;
            this.groupBox58.TabStop = false;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(6, 18);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(11, 12);
            this.label92.TabIndex = 12;
            this.label92.Text = "0";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(5, 42);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(22, 12);
            this.label93.TabIndex = 22;
            this.label93.Text = "Fail";
            // 
            // groupBox59
            // 
            this.groupBox59.Controls.Add(this.label94);
            this.groupBox59.Controls.Add(this.label95);
            this.groupBox59.Location = new System.Drawing.Point(544, 338);
            this.groupBox59.Name = "groupBox59";
            this.groupBox59.Size = new System.Drawing.Size(42, 62);
            this.groupBox59.TabIndex = 197;
            this.groupBox59.TabStop = false;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(6, 18);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(11, 12);
            this.label94.TabIndex = 12;
            this.label94.Text = "0";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(5, 42);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(22, 12);
            this.label95.TabIndex = 22;
            this.label95.Text = "Fail";
            // 
            // groupBox60
            // 
            this.groupBox60.Controls.Add(this.label96);
            this.groupBox60.Controls.Add(this.label97);
            this.groupBox60.Location = new System.Drawing.Point(592, 338);
            this.groupBox60.Name = "groupBox60";
            this.groupBox60.Size = new System.Drawing.Size(42, 62);
            this.groupBox60.TabIndex = 197;
            this.groupBox60.TabStop = false;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(6, 18);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(11, 12);
            this.label96.TabIndex = 12;
            this.label96.Text = "0";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(5, 42);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(22, 12);
            this.label97.TabIndex = 22;
            this.label97.Text = "Fail";
            // 
            // groupBox61
            // 
            this.groupBox61.Controls.Add(this.label98);
            this.groupBox61.Controls.Add(this.label99);
            this.groupBox61.Location = new System.Drawing.Point(60, 415);
            this.groupBox61.Name = "groupBox61";
            this.groupBox61.Size = new System.Drawing.Size(42, 62);
            this.groupBox61.TabIndex = 197;
            this.groupBox61.TabStop = false;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(6, 18);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(11, 12);
            this.label98.TabIndex = 12;
            this.label98.Text = "0";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(5, 42);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(22, 12);
            this.label99.TabIndex = 22;
            this.label99.Text = "Fail";
            // 
            // groupBox62
            // 
            this.groupBox62.Controls.Add(this.label100);
            this.groupBox62.Controls.Add(this.label101);
            this.groupBox62.Location = new System.Drawing.Point(108, 415);
            this.groupBox62.Name = "groupBox62";
            this.groupBox62.Size = new System.Drawing.Size(42, 62);
            this.groupBox62.TabIndex = 197;
            this.groupBox62.TabStop = false;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(6, 18);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(11, 12);
            this.label100.TabIndex = 12;
            this.label100.Text = "0";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(5, 42);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(22, 12);
            this.label101.TabIndex = 22;
            this.label101.Text = "Fail";
            // 
            // groupBox63
            // 
            this.groupBox63.Controls.Add(this.label102);
            this.groupBox63.Controls.Add(this.label103);
            this.groupBox63.Location = new System.Drawing.Point(156, 415);
            this.groupBox63.Name = "groupBox63";
            this.groupBox63.Size = new System.Drawing.Size(42, 62);
            this.groupBox63.TabIndex = 197;
            this.groupBox63.TabStop = false;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(6, 18);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(11, 12);
            this.label102.TabIndex = 12;
            this.label102.Text = "0";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(5, 42);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(22, 12);
            this.label103.TabIndex = 22;
            this.label103.Text = "Fail";
            // 
            // groupBox64
            // 
            this.groupBox64.Controls.Add(this.label104);
            this.groupBox64.Controls.Add(this.label105);
            this.groupBox64.Location = new System.Drawing.Point(208, 415);
            this.groupBox64.Name = "groupBox64";
            this.groupBox64.Size = new System.Drawing.Size(42, 62);
            this.groupBox64.TabIndex = 197;
            this.groupBox64.TabStop = false;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(6, 18);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(11, 12);
            this.label104.TabIndex = 12;
            this.label104.Text = "0";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(5, 42);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(22, 12);
            this.label105.TabIndex = 22;
            this.label105.Text = "Fail";
            // 
            // groupBox65
            // 
            this.groupBox65.Controls.Add(this.label106);
            this.groupBox65.Controls.Add(this.label107);
            this.groupBox65.Location = new System.Drawing.Point(256, 415);
            this.groupBox65.Name = "groupBox65";
            this.groupBox65.Size = new System.Drawing.Size(42, 62);
            this.groupBox65.TabIndex = 197;
            this.groupBox65.TabStop = false;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(6, 18);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(11, 12);
            this.label106.TabIndex = 12;
            this.label106.Text = "0";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(5, 42);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(22, 12);
            this.label107.TabIndex = 22;
            this.label107.Text = "Fail";
            // 
            // groupBox66
            // 
            this.groupBox66.Controls.Add(this.label108);
            this.groupBox66.Controls.Add(this.label109);
            this.groupBox66.Location = new System.Drawing.Point(304, 415);
            this.groupBox66.Name = "groupBox66";
            this.groupBox66.Size = new System.Drawing.Size(42, 62);
            this.groupBox66.TabIndex = 197;
            this.groupBox66.TabStop = false;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(6, 18);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(11, 12);
            this.label108.TabIndex = 12;
            this.label108.Text = "0";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(5, 42);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(22, 12);
            this.label109.TabIndex = 22;
            this.label109.Text = "Fail";
            // 
            // groupBox67
            // 
            this.groupBox67.Controls.Add(this.label110);
            this.groupBox67.Controls.Add(this.label111);
            this.groupBox67.Location = new System.Drawing.Point(352, 415);
            this.groupBox67.Name = "groupBox67";
            this.groupBox67.Size = new System.Drawing.Size(42, 62);
            this.groupBox67.TabIndex = 260;
            this.groupBox67.TabStop = false;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(6, 18);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(11, 12);
            this.label110.TabIndex = 12;
            this.label110.Text = "0";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(5, 42);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(22, 12);
            this.label111.TabIndex = 22;
            this.label111.Text = "Fail";
            // 
            // groupBox68
            // 
            this.groupBox68.Controls.Add(this.label112);
            this.groupBox68.Controls.Add(this.label113);
            this.groupBox68.Location = new System.Drawing.Point(400, 415);
            this.groupBox68.Name = "groupBox68";
            this.groupBox68.Size = new System.Drawing.Size(42, 62);
            this.groupBox68.TabIndex = 197;
            this.groupBox68.TabStop = false;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(6, 18);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(11, 12);
            this.label112.TabIndex = 12;
            this.label112.Text = "0";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(5, 42);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(22, 12);
            this.label113.TabIndex = 22;
            this.label113.Text = "Fail";
            // 
            // groupBox69
            // 
            this.groupBox69.Controls.Add(this.label114);
            this.groupBox69.Controls.Add(this.label115);
            this.groupBox69.Location = new System.Drawing.Point(448, 415);
            this.groupBox69.Name = "groupBox69";
            this.groupBox69.Size = new System.Drawing.Size(42, 62);
            this.groupBox69.TabIndex = 197;
            this.groupBox69.TabStop = false;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(6, 18);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(11, 12);
            this.label114.TabIndex = 12;
            this.label114.Text = "0";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(5, 42);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(22, 12);
            this.label115.TabIndex = 22;
            this.label115.Text = "Fail";
            // 
            // groupBox70
            // 
            this.groupBox70.Controls.Add(this.label116);
            this.groupBox70.Controls.Add(this.label117);
            this.groupBox70.Location = new System.Drawing.Point(496, 415);
            this.groupBox70.Name = "groupBox70";
            this.groupBox70.Size = new System.Drawing.Size(42, 62);
            this.groupBox70.TabIndex = 197;
            this.groupBox70.TabStop = false;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(6, 18);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(11, 12);
            this.label116.TabIndex = 12;
            this.label116.Text = "0";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(5, 42);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(22, 12);
            this.label117.TabIndex = 22;
            this.label117.Text = "Fail";
            // 
            // groupBox71
            // 
            this.groupBox71.Controls.Add(this.label118);
            this.groupBox71.Controls.Add(this.label119);
            this.groupBox71.Location = new System.Drawing.Point(544, 415);
            this.groupBox71.Name = "groupBox71";
            this.groupBox71.Size = new System.Drawing.Size(42, 62);
            this.groupBox71.TabIndex = 197;
            this.groupBox71.TabStop = false;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(6, 18);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(11, 12);
            this.label118.TabIndex = 12;
            this.label118.Text = "0";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(5, 42);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(22, 12);
            this.label119.TabIndex = 22;
            this.label119.Text = "Fail";
            // 
            // groupBox72
            // 
            this.groupBox72.Controls.Add(this.label120);
            this.groupBox72.Controls.Add(this.label121);
            this.groupBox72.Location = new System.Drawing.Point(592, 415);
            this.groupBox72.Name = "groupBox72";
            this.groupBox72.Size = new System.Drawing.Size(42, 62);
            this.groupBox72.TabIndex = 197;
            this.groupBox72.TabStop = false;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(6, 18);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(11, 12);
            this.label120.TabIndex = 12;
            this.label120.Text = "0";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(5, 42);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(22, 12);
            this.label121.TabIndex = 22;
            this.label121.Text = "Fail";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(699, 499);
            this.Controls.Add(this.groupBox72);
            this.Controls.Add(this.groupBox71);
            this.Controls.Add(this.groupBox70);
            this.Controls.Add(this.groupBox69);
            this.Controls.Add(this.groupBox68);
            this.Controls.Add(this.groupBox67);
            this.Controls.Add(this.groupBox66);
            this.Controls.Add(this.groupBox65);
            this.Controls.Add(this.groupBox64);
            this.Controls.Add(this.groupBox63);
            this.Controls.Add(this.groupBox62);
            this.Controls.Add(this.groupBox61);
            this.Controls.Add(this.groupBox60);
            this.Controls.Add(this.groupBox59);
            this.Controls.Add(this.groupBox58);
            this.Controls.Add(this.groupBox57);
            this.Controls.Add(this.groupBox56);
            this.Controls.Add(this.groupBox55);
            this.Controls.Add(this.groupBox54);
            this.Controls.Add(this.groupBox53);
            this.Controls.Add(this.groupBox52);
            this.Controls.Add(this.groupBox51);
            this.Controls.Add(this.groupBox50);
            this.Controls.Add(this.groupBox49);
            this.Controls.Add(this.groupBox48);
            this.Controls.Add(this.groupBox47);
            this.Controls.Add(this.groupBox46);
            this.Controls.Add(this.groupBox45);
            this.Controls.Add(this.groupBox44);
            this.Controls.Add(this.groupBox43);
            this.Controls.Add(this.groupBox42);
            this.Controls.Add(this.groupBox41);
            this.Controls.Add(this.groupBox40);
            this.Controls.Add(this.groupBox39);
            this.Controls.Add(this.groupBox38);
            this.Controls.Add(this.groupBox37);
            this.Controls.Add(this.groupBox36);
            this.Controls.Add(this.groupBox35);
            this.Controls.Add(this.groupBox34);
            this.Controls.Add(this.groupBox33);
            this.Controls.Add(this.groupBox32);
            this.Controls.Add(this.groupBox31);
            this.Controls.Add(this.groupBox30);
            this.Controls.Add(this.groupBox29);
            this.Controls.Add(this.groupBox28);
            this.Controls.Add(this.groupBox27);
            this.Controls.Add(this.groupBox26);
            this.Controls.Add(this.groupBox25);
            this.Controls.Add(this.groupBox24);
            this.Controls.Add(this.groupBox23);
            this.Controls.Add(this.groupBox22);
            this.Controls.Add(this.groupBox21);
            this.Controls.Add(this.groupBox20);
            this.Controls.Add(this.groupBox19);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.brightness_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.groupBox40.ResumeLayout(false);
            this.groupBox40.PerformLayout();
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            this.groupBox42.ResumeLayout(false);
            this.groupBox42.PerformLayout();
            this.groupBox43.ResumeLayout(false);
            this.groupBox43.PerformLayout();
            this.groupBox44.ResumeLayout(false);
            this.groupBox44.PerformLayout();
            this.groupBox45.ResumeLayout(false);
            this.groupBox45.PerformLayout();
            this.groupBox46.ResumeLayout(false);
            this.groupBox46.PerformLayout();
            this.groupBox47.ResumeLayout(false);
            this.groupBox47.PerformLayout();
            this.groupBox48.ResumeLayout(false);
            this.groupBox48.PerformLayout();
            this.groupBox49.ResumeLayout(false);
            this.groupBox49.PerformLayout();
            this.groupBox50.ResumeLayout(false);
            this.groupBox50.PerformLayout();
            this.groupBox51.ResumeLayout(false);
            this.groupBox51.PerformLayout();
            this.groupBox52.ResumeLayout(false);
            this.groupBox52.PerformLayout();
            this.groupBox53.ResumeLayout(false);
            this.groupBox53.PerformLayout();
            this.groupBox54.ResumeLayout(false);
            this.groupBox54.PerformLayout();
            this.groupBox55.ResumeLayout(false);
            this.groupBox55.PerformLayout();
            this.groupBox56.ResumeLayout(false);
            this.groupBox56.PerformLayout();
            this.groupBox57.ResumeLayout(false);
            this.groupBox57.PerformLayout();
            this.groupBox58.ResumeLayout(false);
            this.groupBox58.PerformLayout();
            this.groupBox59.ResumeLayout(false);
            this.groupBox59.PerformLayout();
            this.groupBox60.ResumeLayout(false);
            this.groupBox60.PerformLayout();
            this.groupBox61.ResumeLayout(false);
            this.groupBox61.PerformLayout();
            this.groupBox62.ResumeLayout(false);
            this.groupBox62.PerformLayout();
            this.groupBox63.ResumeLayout(false);
            this.groupBox63.PerformLayout();
            this.groupBox64.ResumeLayout(false);
            this.groupBox64.PerformLayout();
            this.groupBox65.ResumeLayout(false);
            this.groupBox65.PerformLayout();
            this.groupBox66.ResumeLayout(false);
            this.groupBox66.PerformLayout();
            this.groupBox67.ResumeLayout(false);
            this.groupBox67.PerformLayout();
            this.groupBox68.ResumeLayout(false);
            this.groupBox68.PerformLayout();
            this.groupBox69.ResumeLayout(false);
            this.groupBox69.PerformLayout();
            this.groupBox70.ResumeLayout(false);
            this.groupBox70.PerformLayout();
            this.groupBox71.ResumeLayout(false);
            this.groupBox71.PerformLayout();
            this.groupBox72.ResumeLayout(false);
            this.groupBox72.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public System.Windows.Forms.Label brightness_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox12;
        public System.Windows.Forms.Label temp0_11;
        public System.Windows.Forms.Label status0_11;
        private System.Windows.Forms.GroupBox groupBox11;
        public System.Windows.Forms.Label temp0_10;
        public System.Windows.Forms.Label status0_10;
        private System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.Label temp0_9;
        public System.Windows.Forms.Label status0_9;
        private System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.Label temp0_8;
        public System.Windows.Forms.Label status0_8;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.Label temp0_7;
        public System.Windows.Forms.Label status0_7;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.Label temp0_6;
        public System.Windows.Forms.Label status0_6;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label temp0_5;
        public System.Windows.Forms.Label status0_5;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label temp0_4;
        public System.Windows.Forms.Label status0_4;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label temp0_3;
        public System.Windows.Forms.Label status0_3;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label temp0_2;
        public System.Windows.Forms.Label status0_2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label temp0_1;
        public System.Windows.Forms.Label status0_1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label temp0_0;
        public System.Windows.Forms.Label status0;
        private System.Windows.Forms.GroupBox groupBox13;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox14;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox15;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox16;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox17;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox18;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox19;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox20;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox21;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox22;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox23;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox24;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox25;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox26;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox27;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox28;
        public System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox29;
        public System.Windows.Forms.Label label34;
        public System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox30;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox31;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox32;
        public System.Windows.Forms.Label label40;
        public System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox33;
        public System.Windows.Forms.Label label42;
        public System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox34;
        public System.Windows.Forms.Label label44;
        public System.Windows.Forms.Label label45;
        private System.Windows.Forms.GroupBox groupBox35;
        public System.Windows.Forms.Label label46;
        public System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox groupBox36;
        public System.Windows.Forms.Label label48;
        public System.Windows.Forms.Label label49;
        private System.Windows.Forms.GroupBox groupBox37;
        public System.Windows.Forms.Label label50;
        public System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox38;
        public System.Windows.Forms.Label label52;
        public System.Windows.Forms.Label label53;
        private System.Windows.Forms.GroupBox groupBox39;
        public System.Windows.Forms.Label label54;
        public System.Windows.Forms.Label label55;
        private System.Windows.Forms.GroupBox groupBox40;
        public System.Windows.Forms.Label label56;
        public System.Windows.Forms.Label label57;
        private System.Windows.Forms.GroupBox groupBox41;
        public System.Windows.Forms.Label label58;
        public System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox groupBox42;
        public System.Windows.Forms.Label label60;
        public System.Windows.Forms.Label label61;
        private System.Windows.Forms.GroupBox groupBox43;
        public System.Windows.Forms.Label label62;
        public System.Windows.Forms.Label label63;
        private System.Windows.Forms.GroupBox groupBox44;
        public System.Windows.Forms.Label label64;
        public System.Windows.Forms.Label label65;
        private System.Windows.Forms.GroupBox groupBox45;
        public System.Windows.Forms.Label label66;
        public System.Windows.Forms.Label label67;
        private System.Windows.Forms.GroupBox groupBox46;
        public System.Windows.Forms.Label label68;
        public System.Windows.Forms.Label label69;
        private System.Windows.Forms.GroupBox groupBox47;
        public System.Windows.Forms.Label label70;
        public System.Windows.Forms.Label label71;
        private System.Windows.Forms.GroupBox groupBox48;
        public System.Windows.Forms.Label label72;
        public System.Windows.Forms.Label label73;
        private System.Windows.Forms.GroupBox groupBox49;
        public System.Windows.Forms.Label label74;
        public System.Windows.Forms.Label label75;
        private System.Windows.Forms.GroupBox groupBox50;
        public System.Windows.Forms.Label label76;
        public System.Windows.Forms.Label label77;
        private System.Windows.Forms.GroupBox groupBox51;
        public System.Windows.Forms.Label label78;
        public System.Windows.Forms.Label label79;
        private System.Windows.Forms.GroupBox groupBox52;
        public System.Windows.Forms.Label label80;
        public System.Windows.Forms.Label label81;
        private System.Windows.Forms.GroupBox groupBox53;
        public System.Windows.Forms.Label label82;
        public System.Windows.Forms.Label label83;
        private System.Windows.Forms.GroupBox groupBox54;
        public System.Windows.Forms.Label label84;
        public System.Windows.Forms.Label label85;
        private System.Windows.Forms.GroupBox groupBox55;
        public System.Windows.Forms.Label label86;
        public System.Windows.Forms.Label label87;
        private System.Windows.Forms.GroupBox groupBox56;
        public System.Windows.Forms.Label label88;
        public System.Windows.Forms.Label label89;
        private System.Windows.Forms.GroupBox groupBox57;
        public System.Windows.Forms.Label label90;
        public System.Windows.Forms.Label label91;
        private System.Windows.Forms.GroupBox groupBox58;
        public System.Windows.Forms.Label label92;
        public System.Windows.Forms.Label label93;
        private System.Windows.Forms.GroupBox groupBox59;
        public System.Windows.Forms.Label label94;
        public System.Windows.Forms.Label label95;
        private System.Windows.Forms.GroupBox groupBox60;
        public System.Windows.Forms.Label label96;
        public System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox groupBox61;
        public System.Windows.Forms.Label label98;
        public System.Windows.Forms.Label label99;
        private System.Windows.Forms.GroupBox groupBox62;
        public System.Windows.Forms.Label label100;
        public System.Windows.Forms.Label label101;
        private System.Windows.Forms.GroupBox groupBox63;
        public System.Windows.Forms.Label label102;
        public System.Windows.Forms.Label label103;
        private System.Windows.Forms.GroupBox groupBox64;
        public System.Windows.Forms.Label label104;
        public System.Windows.Forms.Label label105;
        private System.Windows.Forms.GroupBox groupBox65;
        public System.Windows.Forms.Label label106;
        public System.Windows.Forms.Label label107;
        private System.Windows.Forms.GroupBox groupBox66;
        public System.Windows.Forms.Label label108;
        public System.Windows.Forms.Label label109;
        private System.Windows.Forms.GroupBox groupBox67;
        public System.Windows.Forms.Label label110;
        public System.Windows.Forms.Label label111;
        private System.Windows.Forms.GroupBox groupBox68;
        public System.Windows.Forms.Label label112;
        public System.Windows.Forms.Label label113;
        private System.Windows.Forms.GroupBox groupBox69;
        public System.Windows.Forms.Label label114;
        public System.Windows.Forms.Label label115;
        private System.Windows.Forms.GroupBox groupBox70;
        public System.Windows.Forms.Label label116;
        public System.Windows.Forms.Label label117;
        private System.Windows.Forms.GroupBox groupBox71;
        public System.Windows.Forms.Label label118;
        public System.Windows.Forms.Label label119;
        private System.Windows.Forms.GroupBox groupBox72;
        public System.Windows.Forms.Label label120;
        public System.Windows.Forms.Label label121;
    }
}

