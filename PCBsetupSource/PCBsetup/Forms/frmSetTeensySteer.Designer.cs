namespace PCBsetup.Forms
{
    partial class frmSetTeensySteer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetTeensySteer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ckTSSwapRoll = new System.Windows.Forms.CheckBox();
            this.ckTSInvertRoll = new System.Windows.Forms.CheckBox();
            this.ckTSuse4_20 = new System.Windows.Forms.CheckBox();
            this.tbTSPulseCal = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbTSreceiver = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cbTSRelayControl = new System.Windows.Forms.ComboBox();
            this.tbTSIMUport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTSReceiverPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckTSRelayOn = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbTSspeedPulse = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbTSr16 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTSr15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTSr14 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTSr13 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTSr12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTSr11 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbTSr10 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbTSr9 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbTSr8 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbTSr7 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbTSr6 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbTSr5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTSr4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTSr3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTSr2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTSr1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTSworkSwitch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTSsteerSwitch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTSsteerRelay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTSpowerRelay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTSPWM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTSDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbModuleIP = new System.Windows.Forms.Label();
            this.lbSubnet = new System.Windows.Forms.Label();
            this.cbEthernet = new System.Windows.Forms.ComboBox();
            this.ckTSZeroWas = new System.Windows.Forms.CheckBox();
            this.btnLoadDefaults = new System.Windows.Forms.Button();
            this.btnSendToModule = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.btnSendSubnet = new System.Windows.Forms.Button();
            this.btnRescan = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 543);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ckTSZeroWas);
            this.tabPage1.Controls.Add(this.ckTSSwapRoll);
            this.tabPage1.Controls.Add(this.ckTSInvertRoll);
            this.tabPage1.Controls.Add(this.ckTSuse4_20);
            this.tabPage1.Controls.Add(this.tbTSPulseCal);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.cbTSreceiver);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.cbTSRelayControl);
            this.tabPage1.Controls.Add(this.tbTSIMUport);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbTSReceiverPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ckTSRelayOn);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ckTSSwapRoll
            // 
            this.ckTSSwapRoll.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSSwapRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSSwapRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSSwapRoll.Location = new System.Drawing.Point(6, 404);
            this.ckTSSwapRoll.Name = "ckTSSwapRoll";
            this.ckTSSwapRoll.Size = new System.Drawing.Size(92, 69);
            this.ckTSSwapRoll.TabIndex = 53;
            this.ckTSSwapRoll.Text = "Swap pitch roll";
            this.ckTSSwapRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSSwapRoll.UseVisualStyleBackColor = true;
            this.ckTSSwapRoll.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ckTSSwapRoll_HelpRequested);
            // 
            // ckTSInvertRoll
            // 
            this.ckTSInvertRoll.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSInvertRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSInvertRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSInvertRoll.Location = new System.Drawing.Point(110, 404);
            this.ckTSInvertRoll.Name = "ckTSInvertRoll";
            this.ckTSInvertRoll.Size = new System.Drawing.Size(92, 69);
            this.ckTSInvertRoll.TabIndex = 52;
            this.ckTSInvertRoll.Text = "Invert Roll";
            this.ckTSInvertRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSInvertRoll.UseVisualStyleBackColor = true;
            // 
            // ckTSuse4_20
            // 
            this.ckTSuse4_20.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSuse4_20.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSuse4_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSuse4_20.Location = new System.Drawing.Point(214, 404);
            this.ckTSuse4_20.Name = "ckTSuse4_20";
            this.ckTSuse4_20.Size = new System.Drawing.Size(92, 69);
            this.ckTSuse4_20.TabIndex = 51;
            this.ckTSuse4_20.Text = "Use 4-20 analog";
            this.ckTSuse4_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSuse4_20.UseVisualStyleBackColor = true;
            this.ckTSuse4_20.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ckTSuse4_20_HelpRequested);
            // 
            // tbTSPulseCal
            // 
            this.tbTSPulseCal.Location = new System.Drawing.Point(259, 243);
            this.tbTSPulseCal.Name = "tbTSPulseCal";
            this.tbTSPulseCal.Size = new System.Drawing.Size(71, 29);
            this.tbTSPulseCal.TabIndex = 8;
            this.tbTSPulseCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTSPulseCal.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.tbTSPulseCal_HelpRequested);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(83, 246);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(146, 24);
            this.label32.TabIndex = 49;
            this.label32.Text = "Speed pulse cal";
            // 
            // cbTSreceiver
            // 
            this.cbTSreceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTSreceiver.FormattingEnabled = true;
            this.cbTSreceiver.Items.AddRange(new object[] {
            "None",
            "SimpleRTK2B"});
            this.cbTSreceiver.Location = new System.Drawing.Point(259, 90);
            this.cbTSreceiver.Name = "cbTSreceiver";
            this.cbTSreceiver.Size = new System.Drawing.Size(187, 32);
            this.cbTSreceiver.TabIndex = 0;
            this.cbTSreceiver.SelectedIndexChanged += new System.EventHandler(this.cbTSreceiver_SelectedIndexChanged);
            this.cbTSreceiver.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cbTSreceiver_HelpRequested);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(82, 93);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 24);
            this.label26.TabIndex = 42;
            this.label26.Text = "GPS receiver";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(83, 299);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(122, 24);
            this.label28.TabIndex = 41;
            this.label28.Text = "Relay Control";
            // 
            // cbTSRelayControl
            // 
            this.cbTSRelayControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTSRelayControl.FormattingEnabled = true;
            this.cbTSRelayControl.Items.AddRange(new object[] {
            "No Relays",
            "Teensy GPIOs",
            "PCA9555  8 relays",
            "PCA9555  16 relays",
            "MCP23017"});
            this.cbTSRelayControl.Location = new System.Drawing.Point(259, 296);
            this.cbTSRelayControl.Name = "cbTSRelayControl";
            this.cbTSRelayControl.Size = new System.Drawing.Size(187, 32);
            this.cbTSRelayControl.TabIndex = 9;
            this.cbTSRelayControl.SelectedIndexChanged += new System.EventHandler(this.cbTSRelayControl_SelectedIndexChanged);
            // 
            // tbTSIMUport
            // 
            this.tbTSIMUport.Location = new System.Drawing.Point(259, 192);
            this.tbTSIMUport.Name = "tbTSIMUport";
            this.tbTSIMUport.Size = new System.Drawing.Size(71, 29);
            this.tbTSIMUport.TabIndex = 2;
            this.tbTSIMUport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTSIMUport.TextChanged += new System.EventHandler(this.tbTSIMUport_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "IMU serial port";
            // 
            // tbTSReceiverPort
            // 
            this.tbTSReceiverPort.Location = new System.Drawing.Point(259, 141);
            this.tbTSReceiverPort.Name = "tbTSReceiverPort";
            this.tbTSReceiverPort.Size = new System.Drawing.Size(71, 29);
            this.tbTSReceiverPort.TabIndex = 1;
            this.tbTSReceiverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Receiver serial port";
            // 
            // ckTSRelayOn
            // 
            this.ckTSRelayOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSRelayOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSRelayOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSRelayOn.Location = new System.Drawing.Point(318, 404);
            this.ckTSRelayOn.Name = "ckTSRelayOn";
            this.ckTSRelayOn.Size = new System.Drawing.Size(92, 69);
            this.ckTSRelayOn.TabIndex = 17;
            this.ckTSRelayOn.Text = "Relay on High";
            this.ckTSRelayOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSRelayOn.UseVisualStyleBackColor = true;
            this.ckTSRelayOn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ckTSRelayOn_HelpRequested);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbTSspeedPulse);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.tbTSr16);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbTSr15);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbTSr14);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbTSr13);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tbTSr12);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tbTSr11);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.tbTSr10);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.tbTSr9);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.tbTSr8);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.tbTSr7);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.tbTSr6);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.tbTSr5);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbTSr4);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbTSr3);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbTSr2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbTSr1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbTSworkSwitch);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbTSsteerSwitch);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbTSsteerRelay);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbTSpowerRelay);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbTSPWM);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbTSDir);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teensy Pins";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbTSspeedPulse
            // 
            this.tbTSspeedPulse.Location = new System.Drawing.Point(160, 255);
            this.tbTSspeedPulse.Name = "tbTSspeedPulse";
            this.tbTSspeedPulse.Size = new System.Drawing.Size(58, 29);
            this.tbTSspeedPulse.TabIndex = 69;
            this.tbTSspeedPulse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(39, 257);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(118, 24);
            this.label33.TabIndex = 68;
            this.label33.Text = "Speed Pulse";
            // 
            // tbTSr16
            // 
            this.tbTSr16.Location = new System.Drawing.Point(405, 426);
            this.tbTSr16.Name = "tbTSr16";
            this.tbTSr16.Size = new System.Drawing.Size(58, 29);
            this.tbTSr16.TabIndex = 67;
            this.tbTSr16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 24);
            this.label13.TabIndex = 66;
            this.label13.Text = "Relay 16";
            // 
            // tbTSr15
            // 
            this.tbTSr15.Location = new System.Drawing.Point(405, 384);
            this.tbTSr15.Name = "tbTSr15";
            this.tbTSr15.Size = new System.Drawing.Size(58, 29);
            this.tbTSr15.TabIndex = 65;
            this.tbTSr15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 24);
            this.label15.TabIndex = 64;
            this.label15.Text = "Relay 15";
            // 
            // tbTSr14
            // 
            this.tbTSr14.Location = new System.Drawing.Point(405, 342);
            this.tbTSr14.Name = "tbTSr14";
            this.tbTSr14.Size = new System.Drawing.Size(58, 29);
            this.tbTSr14.TabIndex = 63;
            this.tbTSr14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(284, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 24);
            this.label16.TabIndex = 62;
            this.label16.Text = "Relay 14";
            // 
            // tbTSr13
            // 
            this.tbTSr13.Location = new System.Drawing.Point(405, 300);
            this.tbTSr13.Name = "tbTSr13";
            this.tbTSr13.Size = new System.Drawing.Size(58, 29);
            this.tbTSr13.TabIndex = 61;
            this.tbTSr13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 24);
            this.label17.TabIndex = 60;
            this.label17.Text = "Relay 13";
            // 
            // tbTSr12
            // 
            this.tbTSr12.Location = new System.Drawing.Point(405, 258);
            this.tbTSr12.Name = "tbTSr12";
            this.tbTSr12.Size = new System.Drawing.Size(58, 29);
            this.tbTSr12.TabIndex = 59;
            this.tbTSr12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(284, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 24);
            this.label18.TabIndex = 58;
            this.label18.Text = "Relay 12";
            // 
            // tbTSr11
            // 
            this.tbTSr11.Location = new System.Drawing.Point(405, 216);
            this.tbTSr11.Name = "tbTSr11";
            this.tbTSr11.Size = new System.Drawing.Size(58, 29);
            this.tbTSr11.TabIndex = 57;
            this.tbTSr11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(284, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 24);
            this.label19.TabIndex = 56;
            this.label19.Text = "Relay 11";
            // 
            // tbTSr10
            // 
            this.tbTSr10.Location = new System.Drawing.Point(405, 174);
            this.tbTSr10.Name = "tbTSr10";
            this.tbTSr10.Size = new System.Drawing.Size(58, 29);
            this.tbTSr10.TabIndex = 55;
            this.tbTSr10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(284, 176);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 24);
            this.label20.TabIndex = 54;
            this.label20.Text = "Relay 10";
            // 
            // tbTSr9
            // 
            this.tbTSr9.Location = new System.Drawing.Point(405, 132);
            this.tbTSr9.Name = "tbTSr9";
            this.tbTSr9.Size = new System.Drawing.Size(58, 29);
            this.tbTSr9.TabIndex = 53;
            this.tbTSr9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(284, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 24);
            this.label21.TabIndex = 52;
            this.label21.Text = "Relay 9";
            // 
            // tbTSr8
            // 
            this.tbTSr8.Location = new System.Drawing.Point(405, 90);
            this.tbTSr8.Name = "tbTSr8";
            this.tbTSr8.Size = new System.Drawing.Size(58, 29);
            this.tbTSr8.TabIndex = 51;
            this.tbTSr8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(284, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 24);
            this.label22.TabIndex = 50;
            this.label22.Text = "Relay 8";
            // 
            // tbTSr7
            // 
            this.tbTSr7.Location = new System.Drawing.Point(405, 48);
            this.tbTSr7.Name = "tbTSr7";
            this.tbTSr7.Size = new System.Drawing.Size(58, 29);
            this.tbTSr7.TabIndex = 49;
            this.tbTSr7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(284, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 24);
            this.label23.TabIndex = 48;
            this.label23.Text = "Relay 7";
            // 
            // tbTSr6
            // 
            this.tbTSr6.Location = new System.Drawing.Point(405, 6);
            this.tbTSr6.Name = "tbTSr6";
            this.tbTSr6.Size = new System.Drawing.Size(58, 29);
            this.tbTSr6.TabIndex = 47;
            this.tbTSr6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(284, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 24);
            this.label24.TabIndex = 46;
            this.label24.Text = "Relay 6";
            // 
            // tbTSr5
            // 
            this.tbTSr5.Location = new System.Drawing.Point(160, 465);
            this.tbTSr5.Name = "tbTSr5";
            this.tbTSr5.Size = new System.Drawing.Size(58, 29);
            this.tbTSr5.TabIndex = 45;
            this.tbTSr5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 24);
            this.label14.TabIndex = 44;
            this.label14.Text = "Relay 5";
            // 
            // tbTSr4
            // 
            this.tbTSr4.Location = new System.Drawing.Point(160, 423);
            this.tbTSr4.Name = "tbTSr4";
            this.tbTSr4.Size = new System.Drawing.Size(58, 29);
            this.tbTSr4.TabIndex = 43;
            this.tbTSr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 42;
            this.label11.Text = "Relay 4";
            // 
            // tbTSr3
            // 
            this.tbTSr3.Location = new System.Drawing.Point(160, 381);
            this.tbTSr3.Name = "tbTSr3";
            this.tbTSr3.Size = new System.Drawing.Size(58, 29);
            this.tbTSr3.TabIndex = 41;
            this.tbTSr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 40;
            this.label12.Text = "Relay 3";
            // 
            // tbTSr2
            // 
            this.tbTSr2.Location = new System.Drawing.Point(160, 339);
            this.tbTSr2.Name = "tbTSr2";
            this.tbTSr2.Size = new System.Drawing.Size(58, 29);
            this.tbTSr2.TabIndex = 39;
            this.tbTSr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Relay 2";
            // 
            // tbTSr1
            // 
            this.tbTSr1.Location = new System.Drawing.Point(160, 297);
            this.tbTSr1.Name = "tbTSr1";
            this.tbTSr1.Size = new System.Drawing.Size(58, 29);
            this.tbTSr1.TabIndex = 37;
            this.tbTSr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 36;
            this.label10.Text = "Relay 1";
            // 
            // tbTSworkSwitch
            // 
            this.tbTSworkSwitch.Location = new System.Drawing.Point(160, 216);
            this.tbTSworkSwitch.Name = "tbTSworkSwitch";
            this.tbTSworkSwitch.Size = new System.Drawing.Size(58, 29);
            this.tbTSworkSwitch.TabIndex = 35;
            this.tbTSworkSwitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Work Switch";
            // 
            // tbTSsteerSwitch
            // 
            this.tbTSsteerSwitch.Location = new System.Drawing.Point(160, 174);
            this.tbTSsteerSwitch.Name = "tbTSsteerSwitch";
            this.tbTSsteerSwitch.Size = new System.Drawing.Size(58, 29);
            this.tbTSsteerSwitch.TabIndex = 33;
            this.tbTSsteerSwitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Steer Switch";
            // 
            // tbTSsteerRelay
            // 
            this.tbTSsteerRelay.Location = new System.Drawing.Point(160, 132);
            this.tbTSsteerRelay.Name = "tbTSsteerRelay";
            this.tbTSsteerRelay.Size = new System.Drawing.Size(58, 29);
            this.tbTSsteerRelay.TabIndex = 31;
            this.tbTSsteerRelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Steer Relay";
            // 
            // tbTSpowerRelay
            // 
            this.tbTSpowerRelay.Location = new System.Drawing.Point(160, 90);
            this.tbTSpowerRelay.Name = "tbTSpowerRelay";
            this.tbTSpowerRelay.Size = new System.Drawing.Size(58, 29);
            this.tbTSpowerRelay.TabIndex = 29;
            this.tbTSpowerRelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Power Relay";
            // 
            // tbTSPWM
            // 
            this.tbTSPWM.Location = new System.Drawing.Point(160, 48);
            this.tbTSPWM.Name = "tbTSPWM";
            this.tbTSPWM.Size = new System.Drawing.Size(58, 29);
            this.tbTSPWM.TabIndex = 27;
            this.tbTSPWM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Motor PWM";
            // 
            // tbTSDir
            // 
            this.tbTSDir.Location = new System.Drawing.Point(160, 6);
            this.tbTSDir.Name = "tbTSDir";
            this.tbTSDir.Size = new System.Drawing.Size(58, 29);
            this.tbTSDir.TabIndex = 25;
            this.tbTSDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Motor Dir";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSendSubnet);
            this.tabPage3.Controls.Add(this.lbIP);
            this.tabPage3.Controls.Add(this.lbModuleIP);
            this.tabPage3.Controls.Add(this.lbSubnet);
            this.tabPage3.Controls.Add(this.cbEthernet);
            this.tabPage3.Controls.Add(this.btnRescan);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(522, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Network";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(84, 209);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(76, 24);
            this.lbIP.TabIndex = 223;
            this.lbIP.Text = "Local IP";
            // 
            // lbModuleIP
            // 
            this.lbModuleIP.Location = new System.Drawing.Point(249, 166);
            this.lbModuleIP.Name = "lbModuleIP";
            this.lbModuleIP.Size = new System.Drawing.Size(161, 24);
            this.lbModuleIP.TabIndex = 222;
            this.lbModuleIP.Text = "192.168.100.100";
            this.lbModuleIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSubnet
            // 
            this.lbSubnet.AutoSize = true;
            this.lbSubnet.Location = new System.Drawing.Point(84, 166);
            this.lbSubnet.Name = "lbSubnet";
            this.lbSubnet.Size = new System.Drawing.Size(149, 24);
            this.lbSubnet.TabIndex = 221;
            this.lbSubnet.Text = "Selected Subnet";
            // 
            // cbEthernet
            // 
            this.cbEthernet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEthernet.FormattingEnabled = true;
            this.cbEthernet.Location = new System.Drawing.Point(253, 206);
            this.cbEthernet.Name = "cbEthernet";
            this.cbEthernet.Size = new System.Drawing.Size(157, 32);
            this.cbEthernet.TabIndex = 220;
            this.cbEthernet.SelectedIndexChanged += new System.EventHandler(this.cbEthernet_SelectedIndexChanged);
            // 
            // ckTSZeroWas
            // 
            this.ckTSZeroWas.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSZeroWas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSZeroWas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSZeroWas.Location = new System.Drawing.Point(422, 404);
            this.ckTSZeroWas.Name = "ckTSZeroWas";
            this.ckTSZeroWas.Size = new System.Drawing.Size(92, 69);
            this.ckTSZeroWas.TabIndex = 54;
            this.ckTSZeroWas.Text = "Zero WAS";
            this.ckTSZeroWas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSZeroWas.UseVisualStyleBackColor = true;
            this.ckTSZeroWas.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ckTSZeroWas_HelpRequested);
            // 
            // btnLoadDefaults
            // 
            this.btnLoadDefaults.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadDefaults.FlatAppearance.BorderSize = 0;
            this.btnLoadDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDefaults.Image = global::PCBsetup.Properties.Resources.VehFileLoad;
            this.btnLoadDefaults.Location = new System.Drawing.Point(18, 561);
            this.btnLoadDefaults.Name = "btnLoadDefaults";
            this.btnLoadDefaults.Size = new System.Drawing.Size(115, 72);
            this.btnLoadDefaults.TabIndex = 30;
            this.btnLoadDefaults.UseVisualStyleBackColor = false;
            this.btnLoadDefaults.Click += new System.EventHandler(this.btnLoadDefaults_Click);
            this.btnLoadDefaults.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnLoadDefaults_HelpRequested);
            // 
            // btnSendToModule
            // 
            this.btnSendToModule.BackColor = System.Drawing.Color.Transparent;
            this.btnSendToModule.FlatAppearance.BorderSize = 0;
            this.btnSendToModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToModule.Image = global::PCBsetup.Properties.Resources.UpArrow64;
            this.btnSendToModule.Location = new System.Drawing.Point(153, 561);
            this.btnSendToModule.Name = "btnSendToModule";
            this.btnSendToModule.Size = new System.Drawing.Size(115, 72);
            this.btnSendToModule.TabIndex = 29;
            this.btnSendToModule.UseVisualStyleBackColor = false;
            this.btnSendToModule.Click += new System.EventHandler(this.btnSendToModule_Click);
            this.btnSendToModule.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSendToModule_HelpRequested);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::PCBsetup.Properties.Resources.Cancel64;
            this.btnCancel.Location = new System.Drawing.Point(288, 561);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 72);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntOK
            // 
            this.bntOK.BackColor = System.Drawing.Color.Transparent;
            this.bntOK.FlatAppearance.BorderSize = 0;
            this.bntOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntOK.Image = global::PCBsetup.Properties.Resources.bntOK_Image;
            this.bntOK.Location = new System.Drawing.Point(423, 561);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(115, 72);
            this.bntOK.TabIndex = 0;
            this.bntOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntOK.UseVisualStyleBackColor = false;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // btnSendSubnet
            // 
            this.btnSendSubnet.BackColor = System.Drawing.Color.Transparent;
            this.btnSendSubnet.FlatAppearance.BorderSize = 0;
            this.btnSendSubnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendSubnet.Image = global::PCBsetup.Properties.Resources.Update4;
            this.btnSendSubnet.Location = new System.Drawing.Point(162, 261);
            this.btnSendSubnet.Name = "btnSendSubnet";
            this.btnSendSubnet.Size = new System.Drawing.Size(72, 72);
            this.btnSendSubnet.TabIndex = 225;
            this.btnSendSubnet.UseVisualStyleBackColor = false;
            this.btnSendSubnet.Click += new System.EventHandler(this.btnSendSubnet_Click);
            this.btnSendSubnet.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSendSubnet_HelpRequested);
            // 
            // btnRescan
            // 
            this.btnRescan.BackColor = System.Drawing.Color.Transparent;
            this.btnRescan.FlatAppearance.BorderSize = 0;
            this.btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescan.Image = global::PCBsetup.Properties.Resources.Update;
            this.btnRescan.Location = new System.Drawing.Point(253, 261);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(72, 72);
            this.btnRescan.TabIndex = 218;
            this.btnRescan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRescan.UseVisualStyleBackColor = false;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // frmSetTeensySteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 640);
            this.Controls.Add(this.btnLoadDefaults);
            this.Controls.Add(this.btnSendToModule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetTeensySteer";
            this.ShowInTaskbar = false;
            this.Text = "Teensy Autosteer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTeensySteer_FormClosed);
            this.Load += new System.EventHandler(this.frmTeensySteer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbTSRelayControl;
        private System.Windows.Forms.TextBox tbTSIMUport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTSReceiverPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckTSRelayOn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbTSr16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTSr15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTSr14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTSr13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTSr12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbTSr11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbTSr10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbTSr9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbTSr8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbTSr7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbTSr6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbTSr5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTSr4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTSr3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTSr2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTSr1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTSworkSwitch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTSsteerSwitch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTSsteerRelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTSpowerRelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTSPWM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTSDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTSreceiver;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox ckTSSwapRoll;
        private System.Windows.Forms.CheckBox ckTSInvertRoll;
        private System.Windows.Forms.CheckBox ckTSuse4_20;
        private System.Windows.Forms.TextBox tbTSPulseCal;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbTSspeedPulse;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnLoadDefaults;
        private System.Windows.Forms.Button btnSendToModule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbModuleIP;
        private System.Windows.Forms.Label lbSubnet;
        private System.Windows.Forms.ComboBox cbEthernet;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnSendSubnet;
        private System.Windows.Forms.CheckBox ckTSZeroWas;
    }
}