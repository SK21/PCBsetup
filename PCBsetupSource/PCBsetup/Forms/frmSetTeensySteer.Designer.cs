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
            this.ckTSZeroWas = new System.Windows.Forms.CheckBox();
            this.ckTSUseAds = new System.Windows.Forms.CheckBox();
            this.ckTSInvertRoll = new System.Windows.Forms.CheckBox();
            this.tbTSIMUport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTSReceiverPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadDefaults = new System.Windows.Forms.Button();
            this.btnSendToModule = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbTSsteerRelay = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbTSpowerRelay = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbTScurrent = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbTSwas = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbTSworkSwitch = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbTSsteerSwitch = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbTSpwm = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbTSdir = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbTSRS232Out = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbTSRS232In = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboIMU = new System.Windows.Forms.ComboBox();
            this.ckTSAutoZero = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckTSZeroWas
            // 
            this.ckTSZeroWas.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSZeroWas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSZeroWas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSZeroWas.Location = new System.Drawing.Point(135, 426);
            this.ckTSZeroWas.Name = "ckTSZeroWas";
            this.ckTSZeroWas.Size = new System.Drawing.Size(110, 69);
            this.ckTSZeroWas.TabIndex = 54;
            this.ckTSZeroWas.Text = "Reset WAS Zero";
            this.ckTSZeroWas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSZeroWas.UseVisualStyleBackColor = true;
            this.ckTSZeroWas.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ckTSZeroWas_HelpRequested);
            // 
            // ckTSUseAds
            // 
            this.ckTSUseAds.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSUseAds.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSUseAds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSUseAds.Location = new System.Drawing.Point(368, 426);
            this.ckTSUseAds.Name = "ckTSUseAds";
            this.ckTSUseAds.Size = new System.Drawing.Size(107, 69);
            this.ckTSUseAds.TabIndex = 53;
            this.ckTSUseAds.Text = "Use ADS1115";
            this.ckTSUseAds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSUseAds.UseVisualStyleBackColor = true;
            this.ckTSUseAds.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ckTSUseAds_HelpRequested);
            // 
            // ckTSInvertRoll
            // 
            this.ckTSInvertRoll.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSInvertRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSInvertRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSInvertRoll.Location = new System.Drawing.Point(253, 426);
            this.ckTSInvertRoll.Name = "ckTSInvertRoll";
            this.ckTSInvertRoll.Size = new System.Drawing.Size(107, 69);
            this.ckTSInvertRoll.TabIndex = 52;
            this.ckTSInvertRoll.Text = "Invert Roll";
            this.ckTSInvertRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSInvertRoll.UseVisualStyleBackColor = true;
            // 
            // tbTSIMUport
            // 
            this.tbTSIMUport.Location = new System.Drawing.Point(361, 33);
            this.tbTSIMUport.Name = "tbTSIMUport";
            this.tbTSIMUport.Size = new System.Drawing.Size(71, 29);
            this.tbTSIMUport.TabIndex = 2;
            this.tbTSIMUport.Tag = "1";
            this.tbTSIMUport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "IMU";
            // 
            // tbTSReceiverPort
            // 
            this.tbTSReceiverPort.Location = new System.Drawing.Point(123, 33);
            this.tbTSReceiverPort.Name = "tbTSReceiverPort";
            this.tbTSReceiverPort.Size = new System.Drawing.Size(71, 29);
            this.tbTSReceiverPort.TabIndex = 1;
            this.tbTSReceiverPort.Tag = "0";
            this.tbTSReceiverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Receiver";
            // 
            // btnLoadDefaults
            // 
            this.btnLoadDefaults.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadDefaults.FlatAppearance.BorderSize = 0;
            this.btnLoadDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDefaults.Image = global::PCBsetup.Properties.Resources.VehFileLoad;
            this.btnLoadDefaults.Location = new System.Drawing.Point(12, 586);
            this.btnLoadDefaults.Name = "btnLoadDefaults";
            this.btnLoadDefaults.Size = new System.Drawing.Size(83, 72);
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
            this.btnSendToModule.Location = new System.Drawing.Point(109, 586);
            this.btnSendToModule.Name = "btnSendToModule";
            this.btnSendToModule.Size = new System.Drawing.Size(83, 72);
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
            this.btnCancel.Location = new System.Drawing.Point(303, 586);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 72);
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
            this.bntOK.Location = new System.Drawing.Point(400, 586);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(83, 72);
            this.bntOK.TabIndex = 0;
            this.bntOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntOK.UseVisualStyleBackColor = false;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::PCBsetup.Properties.Resources.Reset2;
            this.btnClear.Location = new System.Drawing.Point(206, 586);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 72);
            this.btnClear.TabIndex = 73;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbTSsteerRelay
            // 
            this.tbTSsteerRelay.Location = new System.Drawing.Point(138, 84);
            this.tbTSsteerRelay.Name = "tbTSsteerRelay";
            this.tbTSsteerRelay.Size = new System.Drawing.Size(58, 29);
            this.tbTSsteerRelay.TabIndex = 58;
            this.tbTSsteerRelay.Tag = "5";
            this.tbTSsteerRelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 86);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 24);
            this.label25.TabIndex = 57;
            this.label25.Text = "Steer Relay";
            // 
            // tbTSpowerRelay
            // 
            this.tbTSpowerRelay.Location = new System.Drawing.Point(138, 33);
            this.tbTSpowerRelay.Name = "tbTSpowerRelay";
            this.tbTSpowerRelay.Size = new System.Drawing.Size(58, 29);
            this.tbTSpowerRelay.TabIndex = 56;
            this.tbTSpowerRelay.Tag = "4";
            this.tbTSpowerRelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(17, 35);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 24);
            this.label26.TabIndex = 55;
            this.label26.Text = "Power Relay";
            // 
            // tbTScurrent
            // 
            this.tbTScurrent.Location = new System.Drawing.Point(374, 84);
            this.tbTScurrent.Name = "tbTScurrent";
            this.tbTScurrent.Size = new System.Drawing.Size(58, 29);
            this.tbTScurrent.TabIndex = 62;
            this.tbTScurrent.Tag = "9";
            this.tbTScurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(255, 86);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 24);
            this.label27.TabIndex = 61;
            this.label27.Text = "Current";
            // 
            // tbTSwas
            // 
            this.tbTSwas.Location = new System.Drawing.Point(374, 33);
            this.tbTSwas.Name = "tbTSwas";
            this.tbTSwas.Size = new System.Drawing.Size(58, 29);
            this.tbTSwas.TabIndex = 60;
            this.tbTSwas.Tag = "8";
            this.tbTSwas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(255, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 24);
            this.label28.TabIndex = 59;
            this.label28.Text = "WAS";
            // 
            // tbTSworkSwitch
            // 
            this.tbTSworkSwitch.Location = new System.Drawing.Point(138, 186);
            this.tbTSworkSwitch.Name = "tbTSworkSwitch";
            this.tbTSworkSwitch.Size = new System.Drawing.Size(58, 29);
            this.tbTSworkSwitch.TabIndex = 66;
            this.tbTSworkSwitch.Tag = "7";
            this.tbTSworkSwitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 188);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 24);
            this.label29.TabIndex = 65;
            this.label29.Text = "Work Switch";
            // 
            // tbTSsteerSwitch
            // 
            this.tbTSsteerSwitch.Location = new System.Drawing.Point(138, 135);
            this.tbTSsteerSwitch.Name = "tbTSsteerSwitch";
            this.tbTSsteerSwitch.Size = new System.Drawing.Size(58, 29);
            this.tbTSsteerSwitch.TabIndex = 64;
            this.tbTSsteerSwitch.Tag = "6";
            this.tbTSsteerSwitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 137);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(114, 24);
            this.label30.TabIndex = 63;
            this.label30.Text = "Steer Switch";
            // 
            // tbTSpwm
            // 
            this.tbTSpwm.Location = new System.Drawing.Point(374, 186);
            this.tbTSpwm.Name = "tbTSpwm";
            this.tbTSpwm.Size = new System.Drawing.Size(58, 29);
            this.tbTSpwm.TabIndex = 70;
            this.tbTSpwm.Tag = "11";
            this.tbTSpwm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(255, 188);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(109, 24);
            this.label31.TabIndex = 69;
            this.label31.Text = "Motor PWM";
            // 
            // tbTSdir
            // 
            this.tbTSdir.Location = new System.Drawing.Point(374, 135);
            this.tbTSdir.Name = "tbTSdir";
            this.tbTSdir.Size = new System.Drawing.Size(58, 29);
            this.tbTSdir.TabIndex = 68;
            this.tbTSdir.Tag = "10";
            this.tbTSdir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(255, 137);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(86, 24);
            this.label32.TabIndex = 67;
            this.label32.Text = "Motor Dir";
            // 
            // tbTSRS232Out
            // 
            this.tbTSRS232Out.Location = new System.Drawing.Point(361, 75);
            this.tbTSRS232Out.Name = "tbTSRS232Out";
            this.tbTSRS232Out.Size = new System.Drawing.Size(71, 29);
            this.tbTSRS232Out.TabIndex = 71;
            this.tbTSRS232Out.Tag = "3";
            this.tbTSRS232Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(255, 77);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 24);
            this.label34.TabIndex = 72;
            this.label34.Text = "RS232 Out";
            // 
            // tbTSRS232In
            // 
            this.tbTSRS232In.Location = new System.Drawing.Point(123, 75);
            this.tbTSRS232In.Name = "tbTSRS232In";
            this.tbTSRS232In.Size = new System.Drawing.Size(71, 29);
            this.tbTSRS232In.TabIndex = 73;
            this.tbTSRS232In.Tag = "2";
            this.tbTSRS232In.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(17, 77);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(85, 24);
            this.label35.TabIndex = 74;
            this.label35.Text = "RS232 In";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTSReceiverPort);
            this.groupBox1.Controls.Add(this.tbTSRS232Out);
            this.groupBox1.Controls.Add(this.tbTSRS232In);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.tbTSIMUport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 138);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Ports";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTSpowerRelay);
            this.groupBox2.Controls.Add(this.tbTSsteerRelay);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.tbTSpwm);
            this.groupBox2.Controls.Add(this.tbTSwas);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.tbTScurrent);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.tbTSdir);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.tbTSsteerSwitch);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.tbTSworkSwitch);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Location = new System.Drawing.Point(20, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 242);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "I/O Pins";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 77;
            this.label3.Text = "IMU";
            // 
            // cboIMU
            // 
            this.cboIMU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIMU.FormattingEnabled = true;
            this.cboIMU.Items.AddRange(new object[] {
            "BNO080",
            "TM171"});
            this.cboIMU.Location = new System.Drawing.Point(218, 528);
            this.cboIMU.Name = "cboIMU";
            this.cboIMU.Size = new System.Drawing.Size(110, 32);
            this.cboIMU.TabIndex = 78;
            this.cboIMU.SelectedIndexChanged += new System.EventHandler(this.cboIMU_SelectedIndexChanged);
            // 
            // ckTSAutoZero
            // 
            this.ckTSAutoZero.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckTSAutoZero.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckTSAutoZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckTSAutoZero.Location = new System.Drawing.Point(20, 426);
            this.ckTSAutoZero.Name = "ckTSAutoZero";
            this.ckTSAutoZero.Size = new System.Drawing.Size(107, 69);
            this.ckTSAutoZero.TabIndex = 79;
            this.ckTSAutoZero.Text = "Auto Zero WAS";
            this.ckTSAutoZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckTSAutoZero.UseVisualStyleBackColor = true;
            this.ckTSAutoZero.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ckTSAutoZero_HelpRequested);
            // 
            // frmSetTeensySteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 673);
            this.Controls.Add(this.ckTSAutoZero);
            this.Controls.Add(this.cboIMU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadDefaults);
            this.Controls.Add(this.ckTSZeroWas);
            this.Controls.Add(this.ckTSUseAds);
            this.Controls.Add(this.btnSendToModule);
            this.Controls.Add(this.ckTSInvertRoll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntOK);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTSIMUport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTSReceiverPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckTSUseAds;
        private System.Windows.Forms.CheckBox ckTSInvertRoll;
        private System.Windows.Forms.Button btnLoadDefaults;
        private System.Windows.Forms.Button btnSendToModule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.CheckBox ckTSZeroWas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbTSsteerRelay;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbTSpowerRelay;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbTSRS232In;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbTSRS232Out;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbTSpwm;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbTSdir;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbTSworkSwitch;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbTSsteerSwitch;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbTScurrent;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbTSwas;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboIMU;
        private System.Windows.Forms.CheckBox ckTSAutoZero;
    }
}