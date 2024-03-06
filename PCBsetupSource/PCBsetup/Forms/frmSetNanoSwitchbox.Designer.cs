namespace PCBsetup.Forms
{
    partial class frmSetNanoSwitchbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetNanoSwitchbox));
            this.btnLoadDefaults = new System.Windows.Forms.Button();
            this.btnSendToModule = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.tbMasterOn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAuto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRateUp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMasterOff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSW2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSW1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSW4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSW3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRateDown = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSW16 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSW15 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSW14 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSW5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSW13 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSW12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSW11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSW10 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbSW9 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbSW8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbSW7 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbSW6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbWorkSwitch = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSendSubnet = new System.Windows.Forms.Button();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbModuleIP = new System.Windows.Forms.Label();
            this.lbSubnet = new System.Windows.Forms.Label();
            this.cbEthernet = new System.Windows.Forms.ComboBox();
            this.btnRescan = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadDefaults
            // 
            this.btnLoadDefaults.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadDefaults.FlatAppearance.BorderSize = 0;
            this.btnLoadDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDefaults.Image = global::PCBsetup.Properties.Resources.VehFileLoad;
            this.btnLoadDefaults.Location = new System.Drawing.Point(12, 403);
            this.btnLoadDefaults.Name = "btnLoadDefaults";
            this.btnLoadDefaults.Size = new System.Drawing.Size(76, 72);
            this.btnLoadDefaults.TabIndex = 23;
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
            this.btnSendToModule.Location = new System.Drawing.Point(117, 403);
            this.btnSendToModule.Name = "btnSendToModule";
            this.btnSendToModule.Size = new System.Drawing.Size(76, 72);
            this.btnSendToModule.TabIndex = 22;
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
            this.btnCancel.Location = new System.Drawing.Point(222, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 72);
            this.btnCancel.TabIndex = 21;
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
            this.bntOK.Location = new System.Drawing.Point(327, 403);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(76, 72);
            this.bntOK.TabIndex = 20;
            this.bntOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntOK.UseVisualStyleBackColor = false;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // tbMasterOn
            // 
            this.tbMasterOn.Location = new System.Drawing.Point(213, 89);
            this.tbMasterOn.Name = "tbMasterOn";
            this.tbMasterOn.Size = new System.Drawing.Size(58, 29);
            this.tbMasterOn.TabIndex = 27;
            this.tbMasterOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMasterOn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Master On";
            this.label2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbAuto
            // 
            this.tbAuto.Location = new System.Drawing.Point(213, 49);
            this.tbAuto.Name = "tbAuto";
            this.tbAuto.Size = new System.Drawing.Size(58, 29);
            this.tbAuto.TabIndex = 25;
            this.tbAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAuto.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Auto";
            this.label1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbRateUp
            // 
            this.tbRateUp.Location = new System.Drawing.Point(213, 169);
            this.tbRateUp.Name = "tbRateUp";
            this.tbRateUp.Size = new System.Drawing.Size(58, 29);
            this.tbRateUp.TabIndex = 31;
            this.tbRateUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRateUp.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Rate Up";
            this.label3.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbMasterOff
            // 
            this.tbMasterOff.Location = new System.Drawing.Point(213, 129);
            this.tbMasterOff.Name = "tbMasterOff";
            this.tbMasterOff.Size = new System.Drawing.Size(58, 29);
            this.tbMasterOff.TabIndex = 29;
            this.tbMasterOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMasterOff.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Master Off";
            this.label4.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW2
            // 
            this.tbSW2.Location = new System.Drawing.Point(118, 61);
            this.tbSW2.Name = "tbSW2";
            this.tbSW2.Size = new System.Drawing.Size(58, 29);
            this.tbSW2.TabIndex = 35;
            this.tbSW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Switch 2";
            this.label5.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW1
            // 
            this.tbSW1.Location = new System.Drawing.Point(118, 21);
            this.tbSW1.Name = "tbSW1";
            this.tbSW1.Size = new System.Drawing.Size(58, 29);
            this.tbSW1.TabIndex = 33;
            this.tbSW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Switch 1";
            this.label6.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW4
            // 
            this.tbSW4.Location = new System.Drawing.Point(118, 141);
            this.tbSW4.Name = "tbSW4";
            this.tbSW4.Size = new System.Drawing.Size(58, 29);
            this.tbSW4.TabIndex = 39;
            this.tbSW4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW4.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Switch 4";
            this.label7.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW3
            // 
            this.tbSW3.Location = new System.Drawing.Point(118, 101);
            this.tbSW3.Name = "tbSW3";
            this.tbSW3.Size = new System.Drawing.Size(58, 29);
            this.tbSW3.TabIndex = 37;
            this.tbSW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW3.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Switch 3";
            this.label8.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbRateDown
            // 
            this.tbRateDown.Location = new System.Drawing.Point(213, 209);
            this.tbRateDown.Name = "tbRateDown";
            this.tbRateDown.Size = new System.Drawing.Size(58, 29);
            this.tbRateDown.TabIndex = 41;
            this.tbRateDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRateDown.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "Rate Down";
            this.label9.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW16
            // 
            this.tbSW16.Location = new System.Drawing.Point(304, 299);
            this.tbSW16.Name = "tbSW16";
            this.tbSW16.Size = new System.Drawing.Size(58, 29);
            this.tbSW16.TabIndex = 52;
            this.tbSW16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW16.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "Switch 16";
            this.label10.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW15
            // 
            this.tbSW15.Location = new System.Drawing.Point(304, 262);
            this.tbSW15.Name = "tbSW15";
            this.tbSW15.Size = new System.Drawing.Size(58, 29);
            this.tbSW15.TabIndex = 50;
            this.tbSW15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW15.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Switch 15";
            this.label11.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW14
            // 
            this.tbSW14.Location = new System.Drawing.Point(304, 222);
            this.tbSW14.Name = "tbSW14";
            this.tbSW14.Size = new System.Drawing.Size(58, 29);
            this.tbSW14.TabIndex = 48;
            this.tbSW14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW14.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 24);
            this.label12.TabIndex = 47;
            this.label12.Text = "Switch 14";
            this.label12.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW5
            // 
            this.tbSW5.Location = new System.Drawing.Point(118, 178);
            this.tbSW5.Name = "tbSW5";
            this.tbSW5.Size = new System.Drawing.Size(58, 29);
            this.tbSW5.TabIndex = 46;
            this.tbSW5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW5.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 24);
            this.label13.TabIndex = 45;
            this.label13.Text = "Switch 5";
            this.label13.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW13
            // 
            this.tbSW13.Location = new System.Drawing.Point(304, 182);
            this.tbSW13.Name = "tbSW13";
            this.tbSW13.Size = new System.Drawing.Size(58, 29);
            this.tbSW13.TabIndex = 68;
            this.tbSW13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW13.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 24);
            this.label14.TabIndex = 67;
            this.label14.Text = "Switch 13";
            this.label14.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW12
            // 
            this.tbSW12.Location = new System.Drawing.Point(304, 142);
            this.tbSW12.Name = "tbSW12";
            this.tbSW12.Size = new System.Drawing.Size(58, 29);
            this.tbSW12.TabIndex = 66;
            this.tbSW12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW12.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(207, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 24);
            this.label15.TabIndex = 65;
            this.label15.Text = "Switch 12";
            this.label15.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW11
            // 
            this.tbSW11.Location = new System.Drawing.Point(304, 102);
            this.tbSW11.Name = "tbSW11";
            this.tbSW11.Size = new System.Drawing.Size(58, 29);
            this.tbSW11.TabIndex = 64;
            this.tbSW11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW11.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(207, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 24);
            this.label16.TabIndex = 63;
            this.label16.Text = "Switch 11";
            this.label16.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW10
            // 
            this.tbSW10.Location = new System.Drawing.Point(304, 62);
            this.tbSW10.Name = "tbSW10";
            this.tbSW10.Size = new System.Drawing.Size(58, 29);
            this.tbSW10.TabIndex = 62;
            this.tbSW10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW10.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(207, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 24);
            this.label17.TabIndex = 61;
            this.label17.Text = "Switch 10";
            this.label17.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW9
            // 
            this.tbSW9.Location = new System.Drawing.Point(304, 22);
            this.tbSW9.Name = "tbSW9";
            this.tbSW9.Size = new System.Drawing.Size(58, 29);
            this.tbSW9.TabIndex = 60;
            this.tbSW9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW9.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(207, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 24);
            this.label18.TabIndex = 59;
            this.label18.Text = "Switch 9";
            this.label18.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW8
            // 
            this.tbSW8.Location = new System.Drawing.Point(118, 299);
            this.tbSW8.Name = "tbSW8";
            this.tbSW8.Size = new System.Drawing.Size(58, 29);
            this.tbSW8.TabIndex = 58;
            this.tbSW8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW8.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 301);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 24);
            this.label19.TabIndex = 57;
            this.label19.Text = "Switch 8";
            this.label19.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW7
            // 
            this.tbSW7.Location = new System.Drawing.Point(118, 259);
            this.tbSW7.Name = "tbSW7";
            this.tbSW7.Size = new System.Drawing.Size(58, 29);
            this.tbSW7.TabIndex = 56;
            this.tbSW7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW7.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 261);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 24);
            this.label20.TabIndex = 55;
            this.label20.Text = "Switch 7";
            this.label20.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbSW6
            // 
            this.tbSW6.Location = new System.Drawing.Point(118, 219);
            this.tbSW6.Name = "tbSW6";
            this.tbSW6.Size = new System.Drawing.Size(58, 29);
            this.tbSW6.TabIndex = 54;
            this.tbSW6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSW6.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 221);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 24);
            this.label21.TabIndex = 53;
            this.label21.Text = "Switch 6";
            this.label21.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tbWorkSwitch
            // 
            this.tbWorkSwitch.Location = new System.Drawing.Point(213, 249);
            this.tbWorkSwitch.Name = "tbWorkSwitch";
            this.tbWorkSwitch.Size = new System.Drawing.Size(58, 29);
            this.tbWorkSwitch.TabIndex = 70;
            this.tbWorkSwitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWorkSwitch.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(87, 251);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 24);
            this.label22.TabIndex = 69;
            this.label22.Text = "Work Switch";
            this.label22.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Pins_HelpRequested);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 385);
            this.tabControl1.TabIndex = 71;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbRateUp);
            this.tabPage1.Controls.Add(this.tbWorkSwitch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.tbAuto);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbMasterOn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbMasterOff);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbRateDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbSW9);
            this.tabPage2.Controls.Add(this.tbSW8);
            this.tabPage2.Controls.Add(this.tbSW13);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbSW7);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.tbSW14);
            this.tabPage2.Controls.Add(this.tbSW6);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.tbSW12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbSW5);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbSW15);
            this.tabPage2.Controls.Add(this.tbSW4);
            this.tabPage2.Controls.Add(this.tbSW11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbSW3);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbSW16);
            this.tabPage2.Controls.Add(this.tbSW2);
            this.tabPage2.Controls.Add(this.tbSW10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tbSW1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Section Switches";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage3.Size = new System.Drawing.Size(383, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Network";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSendSubnet
            // 
            this.btnSendSubnet.BackColor = System.Drawing.Color.Transparent;
            this.btnSendSubnet.FlatAppearance.BorderSize = 0;
            this.btnSendSubnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendSubnet.Image = global::PCBsetup.Properties.Resources.Update4;
            this.btnSendSubnet.Location = new System.Drawing.Point(99, 182);
            this.btnSendSubnet.Name = "btnSendSubnet";
            this.btnSendSubnet.Size = new System.Drawing.Size(72, 72);
            this.btnSendSubnet.TabIndex = 225;
            this.btnSendSubnet.UseVisualStyleBackColor = false;
            this.btnSendSubnet.Click += new System.EventHandler(this.btnSendSubnet_Click);
            this.btnSendSubnet.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSendSubnet_HelpRequested);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(21, 130);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(76, 24);
            this.lbIP.TabIndex = 223;
            this.lbIP.Text = "Local IP";
            // 
            // lbModuleIP
            // 
            this.lbModuleIP.Location = new System.Drawing.Point(186, 87);
            this.lbModuleIP.Name = "lbModuleIP";
            this.lbModuleIP.Size = new System.Drawing.Size(161, 24);
            this.lbModuleIP.TabIndex = 222;
            this.lbModuleIP.Text = "192.168.100.100";
            this.lbModuleIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSubnet
            // 
            this.lbSubnet.AutoSize = true;
            this.lbSubnet.Location = new System.Drawing.Point(21, 87);
            this.lbSubnet.Name = "lbSubnet";
            this.lbSubnet.Size = new System.Drawing.Size(149, 24);
            this.lbSubnet.TabIndex = 221;
            this.lbSubnet.Text = "Selected Subnet";
            // 
            // cbEthernet
            // 
            this.cbEthernet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEthernet.FormattingEnabled = true;
            this.cbEthernet.Location = new System.Drawing.Point(190, 127);
            this.cbEthernet.Name = "cbEthernet";
            this.cbEthernet.Size = new System.Drawing.Size(157, 32);
            this.cbEthernet.TabIndex = 220;
            this.cbEthernet.SelectedIndexChanged += new System.EventHandler(this.cbEthernet_SelectedIndexChanged);
            // 
            // btnRescan
            // 
            this.btnRescan.BackColor = System.Drawing.Color.Transparent;
            this.btnRescan.FlatAppearance.BorderSize = 0;
            this.btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescan.Image = global::PCBsetup.Properties.Resources.Update;
            this.btnRescan.Location = new System.Drawing.Point(190, 182);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(72, 72);
            this.btnRescan.TabIndex = 218;
            this.btnRescan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRescan.UseVisualStyleBackColor = false;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // frmSetNanoSwitchbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLoadDefaults);
            this.Controls.Add(this.btnSendToModule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetNanoSwitchbox";
            this.ShowInTaskbar = false;
            this.Text = "Nano Switchbox Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSwitchboxSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmSwitchboxSettings_Load);
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

        private System.Windows.Forms.Button btnLoadDefaults;
        private System.Windows.Forms.Button btnSendToModule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.TextBox tbMasterOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRateUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMasterOff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSW2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSW1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSW4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSW3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRateDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSW16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSW15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSW14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSW5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSW13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSW12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSW11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbSW10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbSW9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbSW8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbSW7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbSW6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbWorkSwitch;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSendSubnet;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbModuleIP;
        private System.Windows.Forms.Label lbSubnet;
        private System.Windows.Forms.ComboBox cbEthernet;
        private System.Windows.Forms.Button btnRescan;
    }
}