namespace GCCAdapterTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ALabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detectLabel = new System.Windows.Forms.Label();
            this.DetectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rumbleBTTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.P4 = new System.Windows.Forms.CheckBox();
            this.P3 = new System.Windows.Forms.CheckBox();
            this.P2 = new System.Windows.Forms.CheckBox();
            this.P1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectPort = new System.Windows.Forms.ComboBox();
            this.isPresentLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ZLabel = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.LLabel = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.RLabel = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.RTLabel = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.LTLabel = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.RightStickYLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RightStickXLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.LeftStickYLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LeftStickXLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.DPLabel = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.FBLabel = new System.Windows.Forms.Label();
            this.OBLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.SuspendLayout();
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(6, 16);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(65, 13);
            this.ALabel.TabIndex = 1;
            this.ALabel.Text = "Not Pressed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ALabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(77, 37);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Button";
            // 
            // detectLabel
            // 
            this.detectLabel.AutoSize = true;
            this.detectLabel.Location = new System.Drawing.Point(33, 16);
            this.detectLabel.Name = "detectLabel";
            this.detectLabel.Size = new System.Drawing.Size(111, 13);
            this.detectLabel.TabIndex = 3;
            this.detectLabel.Text = "Adapter Not Detected";
            this.detectLabel.Click += new System.EventHandler(this.detectLabel_Click);
            // 
            // DetectButton
            // 
            this.DetectButton.Location = new System.Drawing.Point(293, 92);
            this.DetectButton.Name = "DetectButton";
            this.DetectButton.Size = new System.Drawing.Size(86, 42);
            this.DetectButton.TabIndex = 4;
            this.DetectButton.Text = "Detect Adapter";
            this.DetectButton.UseVisualStyleBackColor = true;
            this.DetectButton.Click += new System.EventHandler(this.DetectButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Poll Adapter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rumbleBTTN
            // 
            this.rumbleBTTN.Location = new System.Drawing.Point(293, 231);
            this.rumbleBTTN.Name = "rumbleBTTN";
            this.rumbleBTTN.Size = new System.Drawing.Size(86, 33);
            this.rumbleBTTN.TabIndex = 7;
            this.rumbleBTTN.Text = "Rumble";
            this.rumbleBTTN.UseVisualStyleBackColor = true;
            this.rumbleBTTN.Click += new System.EventHandler(this.rumbleBTTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Read Adapter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.P4);
            this.groupBox2.Controls.Add(this.P3);
            this.groupBox2.Controls.Add(this.P2);
            this.groupBox2.Controls.Add(this.P1);
            this.groupBox2.Controls.Add(this.detectLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adpater Ports";
            // 
            // P4
            // 
            this.P4.AutoSize = true;
            this.P4.Enabled = false;
            this.P4.Location = new System.Drawing.Point(132, 45);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(39, 17);
            this.P4.TabIndex = 11;
            this.P4.Text = "P4";
            this.P4.UseVisualStyleBackColor = true;
            // 
            // P3
            // 
            this.P3.AutoSize = true;
            this.P3.Enabled = false;
            this.P3.Location = new System.Drawing.Point(89, 45);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(39, 17);
            this.P3.TabIndex = 10;
            this.P3.Text = "P3";
            this.P3.UseVisualStyleBackColor = true;
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Enabled = false;
            this.P2.Location = new System.Drawing.Point(44, 45);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(39, 17);
            this.P2.TabIndex = 9;
            this.P2.Text = "P2";
            this.P2.UseVisualStyleBackColor = true;
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Enabled = false;
            this.P1.Location = new System.Drawing.Point(6, 45);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(39, 17);
            this.P1.TabIndex = 8;
            this.P1.Text = "P1";
            this.P1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selectPort);
            this.groupBox3.Controls.Add(this.isPresentLabel);
            this.groupBox3.Location = new System.Drawing.Point(195, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 67);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controller Selection";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // selectPort
            // 
            this.selectPort.FormattingEnabled = true;
            this.selectPort.Items.AddRange(new object[] {
            "Port 1",
            "Port 2",
            "Port 3",
            "Port 4"});
            this.selectPort.Location = new System.Drawing.Point(6, 40);
            this.selectPort.Name = "selectPort";
            this.selectPort.Size = new System.Drawing.Size(172, 21);
            this.selectPort.TabIndex = 13;
            this.selectPort.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // isPresentLabel
            // 
            this.isPresentLabel.AutoSize = true;
            this.isPresentLabel.Location = new System.Drawing.Point(37, 16);
            this.isPresentLabel.Name = "isPresentLabel";
            this.isPresentLabel.Size = new System.Drawing.Size(107, 13);
            this.isPresentLabel.TabIndex = 12;
            this.isPresentLabel.Text = "No Controller Present";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(77, 37);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "B Button";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(6, 16);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(65, 13);
            this.BLabel.TabIndex = 1;
            this.BLabel.Text = "Not Pressed";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.YLabel);
            this.groupBox5.Location = new System.Drawing.Point(12, 182);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(77, 37);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Y Button";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(6, 16);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(65, 13);
            this.YLabel.TabIndex = 1;
            this.YLabel.Text = "Not Pressed";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.XLabel);
            this.groupBox6.Location = new System.Drawing.Point(12, 225);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(77, 37);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "X Button";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(6, 16);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(65, 13);
            this.XLabel.TabIndex = 1;
            this.XLabel.Text = "Not Pressed";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.StartLabel);
            this.groupBox7.Location = new System.Drawing.Point(12, 268);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(77, 37);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Start Button";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(6, 16);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(65, 13);
            this.StartLabel.TabIndex = 1;
            this.StartLabel.Text = "Not Pressed";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ZLabel);
            this.groupBox8.Location = new System.Drawing.Point(12, 311);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(77, 37);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Z Button";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Location = new System.Drawing.Point(6, 16);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(65, 13);
            this.ZLabel.TabIndex = 1;
            this.ZLabel.Text = "Not Pressed";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.LLabel);
            this.groupBox9.Location = new System.Drawing.Point(6, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(77, 37);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "L Button";
            // 
            // LLabel
            // 
            this.LLabel.AutoSize = true;
            this.LLabel.Location = new System.Drawing.Point(6, 16);
            this.LLabel.Name = "LLabel";
            this.LLabel.Size = new System.Drawing.Size(65, 13);
            this.LLabel.TabIndex = 1;
            this.LLabel.Text = "Not Pressed";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox9);
            this.groupBox10.Location = new System.Drawing.Point(98, 86);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(90, 107);
            this.groupBox10.TabIndex = 17;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Digital";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.RLabel);
            this.groupBox11.Location = new System.Drawing.Point(7, 62);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(77, 37);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "R Button";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(6, 16);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(65, 13);
            this.RLabel.TabIndex = 1;
            this.RLabel.Text = "Not Pressed";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox13);
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Location = new System.Drawing.Point(99, 199);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(90, 107);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Analog";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.RTLabel);
            this.groupBox13.Location = new System.Drawing.Point(7, 62);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(77, 37);
            this.groupBox13.TabIndex = 17;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "R Trigger";
            // 
            // RTLabel
            // 
            this.RTLabel.AutoSize = true;
            this.RTLabel.Location = new System.Drawing.Point(6, 16);
            this.RTLabel.Name = "RTLabel";
            this.RTLabel.Size = new System.Drawing.Size(15, 13);
            this.RTLabel.TabIndex = 1;
            this.RTLabel.Text = "%";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.LTLabel);
            this.groupBox14.Location = new System.Drawing.Point(6, 19);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(77, 37);
            this.groupBox14.TabIndex = 16;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "L Trigger";
            // 
            // LTLabel
            // 
            this.LTLabel.AutoSize = true;
            this.LTLabel.Location = new System.Drawing.Point(6, 16);
            this.LTLabel.Name = "LTLabel";
            this.LTLabel.Size = new System.Drawing.Size(15, 13);
            this.LTLabel.TabIndex = 1;
            this.LTLabel.Text = "%";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.groupBox17);
            this.groupBox15.Controls.Add(this.groupBox16);
            this.groupBox15.Location = new System.Drawing.Point(193, 86);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(94, 220);
            this.groupBox15.TabIndex = 19;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Joy Sticks";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.RightStickYLabel);
            this.groupBox17.Controls.Add(this.label4);
            this.groupBox17.Controls.Add(this.RightStickXLabel);
            this.groupBox17.Controls.Add(this.label1);
            this.groupBox17.Location = new System.Drawing.Point(6, 113);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(78, 101);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Right Stick";
            // 
            // RightStickYLabel
            // 
            this.RightStickYLabel.AutoSize = true;
            this.RightStickYLabel.Location = new System.Drawing.Point(30, 51);
            this.RightStickYLabel.Name = "RightStickYLabel";
            this.RightStickYLabel.Size = new System.Drawing.Size(25, 13);
            this.RightStickYLabel.TabIndex = 3;
            this.RightStickYLabel.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y:";
            // 
            // RightStickXLabel
            // 
            this.RightStickXLabel.AutoSize = true;
            this.RightStickXLabel.Location = new System.Drawing.Point(30, 20);
            this.RightStickXLabel.Name = "RightStickXLabel";
            this.RightStickXLabel.Size = new System.Drawing.Size(25, 13);
            this.RightStickXLabel.TabIndex = 1;
            this.RightStickXLabel.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.LeftStickYLabel);
            this.groupBox16.Controls.Add(this.label5);
            this.groupBox16.Controls.Add(this.LeftStickXLabel);
            this.groupBox16.Controls.Add(this.label7);
            this.groupBox16.Location = new System.Drawing.Point(6, 19);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(78, 88);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Left Stick";
            // 
            // LeftStickYLabel
            // 
            this.LeftStickYLabel.AutoSize = true;
            this.LeftStickYLabel.Location = new System.Drawing.Point(30, 47);
            this.LeftStickYLabel.Name = "LeftStickYLabel";
            this.LeftStickYLabel.Size = new System.Drawing.Size(25, 13);
            this.LeftStickYLabel.TabIndex = 7;
            this.LeftStickYLabel.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y:";
            // 
            // LeftStickXLabel
            // 
            this.LeftStickXLabel.AutoSize = true;
            this.LeftStickXLabel.Location = new System.Drawing.Point(30, 16);
            this.LeftStickXLabel.Name = "LeftStickXLabel";
            this.LeftStickXLabel.Size = new System.Drawing.Size(25, 13);
            this.LeftStickXLabel.TabIndex = 5;
            this.LeftStickXLabel.Text = "000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "X:";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.DPLabel);
            this.groupBox18.Location = new System.Drawing.Point(101, 312);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(186, 36);
            this.groupBox18.TabIndex = 22;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "D - Pad";
            // 
            // DPLabel
            // 
            this.DPLabel.AutoSize = true;
            this.DPLabel.Location = new System.Drawing.Point(57, 13);
            this.DPLabel.Name = "DPLabel";
            this.DPLabel.Size = new System.Drawing.Size(65, 13);
            this.DPLabel.TabIndex = 0;
            this.DPLabel.Text = "Not Pressed";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.FBLabel);
            this.groupBox19.Location = new System.Drawing.Point(13, 19);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(95, 75);
            this.groupBox19.TabIndex = 23;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Face Buttons";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.groupBox21);
            this.groupBox20.Controls.Add(this.groupBox19);
            this.groupBox20.Location = new System.Drawing.Point(12, 356);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(275, 100);
            this.groupBox20.TabIndex = 24;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Raw Input";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.OBLabel);
            this.groupBox21.Location = new System.Drawing.Point(170, 19);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(95, 75);
            this.groupBox21.TabIndex = 24;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Other Buttons";
            // 
            // FBLabel
            // 
            this.FBLabel.AutoSize = true;
            this.FBLabel.Location = new System.Drawing.Point(38, 34);
            this.FBLabel.Name = "FBLabel";
            this.FBLabel.Size = new System.Drawing.Size(13, 13);
            this.FBLabel.TabIndex = 0;
            this.FBLabel.Text = "0";
            // 
            // OBLabel
            // 
            this.OBLabel.AutoSize = true;
            this.OBLabel.Location = new System.Drawing.Point(41, 33);
            this.OBLabel.Name = "OBLabel";
            this.OBLabel.Size = new System.Drawing.Size(13, 13);
            this.OBLabel.TabIndex = 1;
            this.OBLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 468);
            this.Controls.Add(this.groupBox20);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rumbleBTTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DetectButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(408, 396);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ReRezd\'s GameCube Adapter Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label detectLabel;
        private System.Windows.Forms.Button DetectButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rumbleBTTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label isPresentLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label LLabel;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label RTLabel;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label LTLabel;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label RightStickYLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RightStickXLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label LeftStickYLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LeftStickXLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectPort;
        private System.Windows.Forms.CheckBox P4;
        private System.Windows.Forms.CheckBox P3;
        private System.Windows.Forms.CheckBox P2;
        private System.Windows.Forms.CheckBox P1;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label DPLabel;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label FBLabel;
        private System.Windows.Forms.Label OBLabel;
    }
}

