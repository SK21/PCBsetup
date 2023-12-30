﻿namespace PCBsetup.Forms
{
    partial class frmTeensyRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeensyRate));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.cbRelayControl = new System.Windows.Forms.ComboBox();
            this.tbWifiPort = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.ckFlowOn = new System.Windows.Forms.CheckBox();
            this.ckRelayOn = new System.Windows.Forms.CheckBox();
            this.tbSensorCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbRelay16 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRelay15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbRelay14 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRelay13 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbRelay12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbRelay11 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbRelay10 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbRelay9 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbRelay8 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbRelay7 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbRelay6 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbRelay5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbRelay4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRelay3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRelay2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRelay1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPWM2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPWM1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDir2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDir1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFlow2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFlow1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadDefaults = new System.Windows.Forms.Button();
            this.btnSendToModule = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 514);
            this.tabControl1.TabIndex = 148;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.cbRelayControl);
            this.tabPage1.Controls.Add(this.tbWifiPort);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.ckFlowOn);
            this.tabPage1.Controls.Add(this.ckRelayOn);
            this.tabPage1.Controls.Add(this.tbSensorCount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbModuleID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(448, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(43, 226);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(122, 24);
            this.label28.TabIndex = 47;
            this.label28.Text = "Relay Control";
            // 
            // cbRelayControl
            // 
            this.cbRelayControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelayControl.FormattingEnabled = true;
            this.cbRelayControl.Items.AddRange(new object[] {
            "No Relays",
            "PCA9685",
            "PCA9555  8 relays",
            "PCA9555  16 relays",
            "MCP23017",
            "GPIOs"});
            this.cbRelayControl.Location = new System.Drawing.Point(192, 222);
            this.cbRelayControl.Name = "cbRelayControl";
            this.cbRelayControl.Size = new System.Drawing.Size(187, 32);
            this.cbRelayControl.TabIndex = 46;
            this.cbRelayControl.SelectedIndexChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // tbWifiPort
            // 
            this.tbWifiPort.Location = new System.Drawing.Point(321, 176);
            this.tbWifiPort.Name = "tbWifiPort";
            this.tbWifiPort.Size = new System.Drawing.Size(58, 29);
            this.tbWifiPort.TabIndex = 45;
            this.tbWifiPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWifiPort.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbWifiPort.Enter += new System.EventHandler(this.tbWifiPort_Enter);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(43, 178);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(135, 24);
            this.label25.TabIndex = 44;
            this.label25.Text = "Wifi  Serial Port";
            // 
            // ckFlowOn
            // 
            this.ckFlowOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckFlowOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckFlowOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckFlowOn.Location = new System.Drawing.Point(262, 276);
            this.ckFlowOn.Name = "ckFlowOn";
            this.ckFlowOn.Size = new System.Drawing.Size(117, 69);
            this.ckFlowOn.TabIndex = 43;
            this.ckFlowOn.Text = "Flow on High";
            this.ckFlowOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckFlowOn.UseVisualStyleBackColor = true;
            this.ckFlowOn.CheckedChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // ckRelayOn
            // 
            this.ckRelayOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckRelayOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckRelayOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckRelayOn.Location = new System.Drawing.Point(50, 276);
            this.ckRelayOn.Name = "ckRelayOn";
            this.ckRelayOn.Size = new System.Drawing.Size(117, 69);
            this.ckRelayOn.TabIndex = 42;
            this.ckRelayOn.Text = "Relay on High";
            this.ckRelayOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckRelayOn.UseVisualStyleBackColor = true;
            this.ckRelayOn.CheckedChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // tbSensorCount
            // 
            this.tbSensorCount.Location = new System.Drawing.Point(321, 128);
            this.tbSensorCount.Name = "tbSensorCount";
            this.tbSensorCount.Size = new System.Drawing.Size(58, 29);
            this.tbSensorCount.TabIndex = 27;
            this.tbSensorCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSensorCount.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbSensorCount.Enter += new System.EventHandler(this.tbSensorCount_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sensor Count";
            // 
            // tbModuleID
            // 
            this.tbModuleID.Location = new System.Drawing.Point(321, 80);
            this.tbModuleID.Name = "tbModuleID";
            this.tbModuleID.Size = new System.Drawing.Size(58, 29);
            this.tbModuleID.TabIndex = 25;
            this.tbModuleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbModuleID.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbModuleID.Enter += new System.EventHandler(this.tbModuleID_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Module ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRelay16);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbRelay15);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbRelay14);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbRelay13);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tbRelay12);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tbRelay11);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.tbRelay10);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.tbRelay9);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.tbRelay8);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.tbRelay7);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.tbRelay6);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.tbRelay5);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbRelay4);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbRelay3);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbRelay2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbRelay1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbPWM2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbPWM1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbDir2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbDir1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbFlow2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbFlow1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(448, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pins";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbRelay16
            // 
            this.tbRelay16.Location = new System.Drawing.Point(375, 434);
            this.tbRelay16.Name = "tbRelay16";
            this.tbRelay16.Size = new System.Drawing.Size(58, 29);
            this.tbRelay16.TabIndex = 111;
            this.tbRelay16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay16.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay16.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 24);
            this.label13.TabIndex = 110;
            this.label13.Text = "Relay 16";
            // 
            // tbRelay15
            // 
            this.tbRelay15.Location = new System.Drawing.Point(375, 392);
            this.tbRelay15.Name = "tbRelay15";
            this.tbRelay15.Size = new System.Drawing.Size(58, 29);
            this.tbRelay15.TabIndex = 109;
            this.tbRelay15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay15.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay15.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 394);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 24);
            this.label15.TabIndex = 108;
            this.label15.Text = "Relay 15";
            // 
            // tbRelay14
            // 
            this.tbRelay14.Location = new System.Drawing.Point(375, 350);
            this.tbRelay14.Name = "tbRelay14";
            this.tbRelay14.Size = new System.Drawing.Size(58, 29);
            this.tbRelay14.TabIndex = 107;
            this.tbRelay14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay14.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay14.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(254, 352);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 24);
            this.label16.TabIndex = 106;
            this.label16.Text = "Relay 14";
            // 
            // tbRelay13
            // 
            this.tbRelay13.Location = new System.Drawing.Point(375, 308);
            this.tbRelay13.Name = "tbRelay13";
            this.tbRelay13.Size = new System.Drawing.Size(58, 29);
            this.tbRelay13.TabIndex = 105;
            this.tbRelay13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay13.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay13.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(254, 310);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 24);
            this.label17.TabIndex = 104;
            this.label17.Text = "Relay 13";
            // 
            // tbRelay12
            // 
            this.tbRelay12.Location = new System.Drawing.Point(375, 266);
            this.tbRelay12.Name = "tbRelay12";
            this.tbRelay12.Size = new System.Drawing.Size(58, 29);
            this.tbRelay12.TabIndex = 103;
            this.tbRelay12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay12.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay12.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(254, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 24);
            this.label18.TabIndex = 102;
            this.label18.Text = "Relay 12";
            // 
            // tbRelay11
            // 
            this.tbRelay11.Location = new System.Drawing.Point(375, 224);
            this.tbRelay11.Name = "tbRelay11";
            this.tbRelay11.Size = new System.Drawing.Size(58, 29);
            this.tbRelay11.TabIndex = 101;
            this.tbRelay11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay11.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay11.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(254, 226);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 24);
            this.label19.TabIndex = 100;
            this.label19.Text = "Relay 11";
            // 
            // tbRelay10
            // 
            this.tbRelay10.Location = new System.Drawing.Point(375, 182);
            this.tbRelay10.Name = "tbRelay10";
            this.tbRelay10.Size = new System.Drawing.Size(58, 29);
            this.tbRelay10.TabIndex = 99;
            this.tbRelay10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay10.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay10.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(254, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 24);
            this.label20.TabIndex = 98;
            this.label20.Text = "Relay 10";
            // 
            // tbRelay9
            // 
            this.tbRelay9.Location = new System.Drawing.Point(375, 140);
            this.tbRelay9.Name = "tbRelay9";
            this.tbRelay9.Size = new System.Drawing.Size(58, 29);
            this.tbRelay9.TabIndex = 97;
            this.tbRelay9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay9.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay9.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(254, 142);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 24);
            this.label21.TabIndex = 96;
            this.label21.Text = "Relay 9";
            // 
            // tbRelay8
            // 
            this.tbRelay8.Location = new System.Drawing.Point(375, 98);
            this.tbRelay8.Name = "tbRelay8";
            this.tbRelay8.Size = new System.Drawing.Size(58, 29);
            this.tbRelay8.TabIndex = 95;
            this.tbRelay8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay8.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay8.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(254, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 24);
            this.label22.TabIndex = 94;
            this.label22.Text = "Relay 8";
            // 
            // tbRelay7
            // 
            this.tbRelay7.Location = new System.Drawing.Point(375, 56);
            this.tbRelay7.Name = "tbRelay7";
            this.tbRelay7.Size = new System.Drawing.Size(58, 29);
            this.tbRelay7.TabIndex = 93;
            this.tbRelay7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay7.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay7.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(254, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 24);
            this.label23.TabIndex = 92;
            this.label23.Text = "Relay 7";
            // 
            // tbRelay6
            // 
            this.tbRelay6.Location = new System.Drawing.Point(375, 14);
            this.tbRelay6.Name = "tbRelay6";
            this.tbRelay6.Size = new System.Drawing.Size(58, 29);
            this.tbRelay6.TabIndex = 91;
            this.tbRelay6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay6.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay6.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(254, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 24);
            this.label24.TabIndex = 90;
            this.label24.Text = "Relay 6";
            // 
            // tbRelay5
            // 
            this.tbRelay5.Location = new System.Drawing.Point(130, 434);
            this.tbRelay5.Name = "tbRelay5";
            this.tbRelay5.Size = new System.Drawing.Size(58, 29);
            this.tbRelay5.TabIndex = 89;
            this.tbRelay5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay5.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay5.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 436);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 24);
            this.label14.TabIndex = 88;
            this.label14.Text = "Relay 5";
            // 
            // tbRelay4
            // 
            this.tbRelay4.Location = new System.Drawing.Point(130, 392);
            this.tbRelay4.Name = "tbRelay4";
            this.tbRelay4.Size = new System.Drawing.Size(58, 29);
            this.tbRelay4.TabIndex = 87;
            this.tbRelay4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay4.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay4.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 86;
            this.label11.Text = "Relay 4";
            // 
            // tbRelay3
            // 
            this.tbRelay3.Location = new System.Drawing.Point(130, 350);
            this.tbRelay3.Name = "tbRelay3";
            this.tbRelay3.Size = new System.Drawing.Size(58, 29);
            this.tbRelay3.TabIndex = 85;
            this.tbRelay3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay3.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay3.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 84;
            this.label12.Text = "Relay 3";
            // 
            // tbRelay2
            // 
            this.tbRelay2.Location = new System.Drawing.Point(130, 308);
            this.tbRelay2.Name = "tbRelay2";
            this.tbRelay2.Size = new System.Drawing.Size(58, 29);
            this.tbRelay2.TabIndex = 83;
            this.tbRelay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay2.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay2.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 82;
            this.label9.Text = "Relay 2";
            // 
            // tbRelay1
            // 
            this.tbRelay1.Location = new System.Drawing.Point(130, 266);
            this.tbRelay1.Name = "tbRelay1";
            this.tbRelay1.Size = new System.Drawing.Size(58, 29);
            this.tbRelay1.TabIndex = 81;
            this.tbRelay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRelay1.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbRelay1.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 80;
            this.label10.Text = "Relay 1";
            // 
            // tbPWM2
            // 
            this.tbPWM2.Location = new System.Drawing.Point(130, 224);
            this.tbPWM2.Name = "tbPWM2";
            this.tbPWM2.Size = new System.Drawing.Size(58, 29);
            this.tbPWM2.TabIndex = 79;
            this.tbPWM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPWM2.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbPWM2.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 78;
            this.label7.Text = "PWM 2";
            // 
            // tbPWM1
            // 
            this.tbPWM1.Location = new System.Drawing.Point(130, 182);
            this.tbPWM1.Name = "tbPWM1";
            this.tbPWM1.Size = new System.Drawing.Size(58, 29);
            this.tbPWM1.TabIndex = 77;
            this.tbPWM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPWM1.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbPWM1.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 76;
            this.label8.Text = "PWM 1";
            // 
            // tbDir2
            // 
            this.tbDir2.Location = new System.Drawing.Point(130, 140);
            this.tbDir2.Name = "tbDir2";
            this.tbDir2.Size = new System.Drawing.Size(58, 29);
            this.tbDir2.TabIndex = 75;
            this.tbDir2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDir2.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbDir2.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 74;
            this.label5.Text = "Dir 2";
            // 
            // tbDir1
            // 
            this.tbDir1.Location = new System.Drawing.Point(130, 98);
            this.tbDir1.Name = "tbDir1";
            this.tbDir1.Size = new System.Drawing.Size(58, 29);
            this.tbDir1.TabIndex = 73;
            this.tbDir1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDir1.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbDir1.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 72;
            this.label6.Text = "Dir 1";
            // 
            // tbFlow2
            // 
            this.tbFlow2.Location = new System.Drawing.Point(130, 56);
            this.tbFlow2.Name = "tbFlow2";
            this.tbFlow2.Size = new System.Drawing.Size(58, 29);
            this.tbFlow2.TabIndex = 71;
            this.tbFlow2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFlow2.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbFlow2.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 70;
            this.label3.Text = "Flow 2";
            // 
            // tbFlow1
            // 
            this.tbFlow1.Location = new System.Drawing.Point(130, 14);
            this.tbFlow1.Name = "tbFlow1";
            this.tbFlow1.Size = new System.Drawing.Size(58, 29);
            this.tbFlow1.TabIndex = 69;
            this.tbFlow1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFlow1.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tbFlow1.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 68;
            this.label4.Text = "Flow 1";
            // 
            // btnLoadDefaults
            // 
            this.btnLoadDefaults.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadDefaults.FlatAppearance.BorderSize = 0;
            this.btnLoadDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDefaults.Image = global::PCBsetup.Properties.Resources.VehFileLoad;
            this.btnLoadDefaults.Location = new System.Drawing.Point(17, 538);
            this.btnLoadDefaults.Name = "btnLoadDefaults";
            this.btnLoadDefaults.Size = new System.Drawing.Size(80, 72);
            this.btnLoadDefaults.TabIndex = 152;
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
            this.btnSendToModule.Location = new System.Drawing.Point(141, 538);
            this.btnSendToModule.Name = "btnSendToModule";
            this.btnSendToModule.Size = new System.Drawing.Size(80, 72);
            this.btnSendToModule.TabIndex = 151;
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
            this.btnCancel.Location = new System.Drawing.Point(265, 538);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 72);
            this.btnCancel.TabIndex = 150;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::PCBsetup.Properties.Resources.bntOK_Image;
            this.btnClose.Location = new System.Drawing.Point(389, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 72);
            this.btnClose.TabIndex = 149;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // frmTeensyRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 617);
            this.Controls.Add(this.btnLoadDefaults);
            this.Controls.Add(this.btnSendToModule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeensyRate";
            this.ShowInTaskbar = false;
            this.Text = " Rate Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTeensyRate_FormClosed);
            this.Load += new System.EventHandler(this.frmTeensyRate_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbRelayControl;
        private System.Windows.Forms.TextBox tbWifiPort;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox ckFlowOn;
        private System.Windows.Forms.CheckBox ckRelayOn;
        private System.Windows.Forms.TextBox tbSensorCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbRelay16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRelay15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbRelay14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRelay13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbRelay12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRelay11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbRelay10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbRelay9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbRelay8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbRelay7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbRelay6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbRelay5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbRelay4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRelay3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRelay2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRelay1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPWM2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPWM1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDir2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDir1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFlow2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFlow1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadDefaults;
        private System.Windows.Forms.Button btnSendToModule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
    }
}