﻿namespace PCBsetup.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbModule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSendSubnet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEthernet = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSettingsNetwork = new System.Windows.Forms.Button();
            this.btnFirmwareNetwork = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRescanSerial = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFirmware = new System.Windows.Forms.Button();
            this.cboPort1 = new System.Windows.Forms.ComboBox();
            this.ModuleIndicator = new System.Windows.Forms.Label();
            this.PortIndicator1 = new System.Windows.Forms.Label();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tbType.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbModule
            // 
            this.cbModule.FormattingEnabled = true;
            this.cbModule.Items.AddRange(new object[] {
            "Teensy AutoSteer",
            "Teensy Rate",
            "Nano Rate",
            "Nano SwitchBox",
            "Wifi RC",
            "ESP32 Rate"});
            this.cbModule.Location = new System.Drawing.Point(206, 53);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(225, 32);
            this.cbModule.TabIndex = 127;
            this.cbModule.SelectedIndexChanged += new System.EventHandler(this.cbModule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 132;
            this.label1.Text = "Application";
            // 
            // tbType
            // 
            this.tbType.Controls.Add(this.tabPage1);
            this.tbType.Controls.Add(this.tabPage2);
            this.tbType.Location = new System.Drawing.Point(16, 104);
            this.tbType.Name = "tbType";
            this.tbType.SelectedIndex = 0;
            this.tbType.Size = new System.Drawing.Size(419, 226);
            this.tbType.TabIndex = 133;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSendSubnet);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbEthernet);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnSettingsNetwork);
            this.tabPage1.Controls.Add(this.btnFirmwareNetwork);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ethernet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSendSubnet
            // 
            this.btnSendSubnet.BackColor = System.Drawing.Color.Transparent;
            this.btnSendSubnet.FlatAppearance.BorderSize = 0;
            this.btnSendSubnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendSubnet.Image = global::PCBsetup.Properties.Resources.Update4;
            this.btnSendSubnet.Location = new System.Drawing.Point(19, 81);
            this.btnSendSubnet.Name = "btnSendSubnet";
            this.btnSendSubnet.Size = new System.Drawing.Size(72, 72);
            this.btnSendSubnet.TabIndex = 231;
            this.btnSendSubnet.UseVisualStyleBackColor = false;
            this.btnSendSubnet.Click += new System.EventHandler(this.btnSendSubnet_Click);
            this.btnSendSubnet.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSendSubnet_HelpRequested);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 230;
            this.label2.Text = "Local IP";
            // 
            // cbEthernet
            // 
            this.cbEthernet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEthernet.FormattingEnabled = true;
            this.cbEthernet.Location = new System.Drawing.Point(189, 25);
            this.cbEthernet.Name = "cbEthernet";
            this.cbEthernet.Size = new System.Drawing.Size(157, 32);
            this.cbEthernet.TabIndex = 227;
            this.cbEthernet.SelectedIndexChanged += new System.EventHandler(this.cbEthernet_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::PCBsetup.Properties.Resources.Update;
            this.button3.Location = new System.Drawing.Point(104, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 72);
            this.button3.TabIndex = 226;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSettingsNetwork
            // 
            this.btnSettingsNetwork.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSettingsNetwork.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSettingsNetwork.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsNetwork.Location = new System.Drawing.Point(297, 81);
            this.btnSettingsNetwork.Name = "btnSettingsNetwork";
            this.btnSettingsNetwork.Size = new System.Drawing.Size(95, 72);
            this.btnSettingsNetwork.TabIndex = 132;
            this.btnSettingsNetwork.Text = "Settings";
            this.btnSettingsNetwork.UseVisualStyleBackColor = false;
            this.btnSettingsNetwork.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFirmwareNetwork
            // 
            this.btnFirmwareNetwork.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFirmwareNetwork.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFirmwareNetwork.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmwareNetwork.Location = new System.Drawing.Point(189, 81);
            this.btnFirmwareNetwork.Name = "btnFirmwareNetwork";
            this.btnFirmwareNetwork.Size = new System.Drawing.Size(95, 72);
            this.btnFirmwareNetwork.TabIndex = 131;
            this.btnFirmwareNetwork.Text = "Firmware";
            this.btnFirmwareNetwork.UseVisualStyleBackColor = false;
            this.btnFirmwareNetwork.Click += new System.EventHandler(this.btnFirmware_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRescanSerial);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnFirmware);
            this.tabPage2.Controls.Add(this.cboPort1);
            this.tabPage2.Controls.Add(this.ModuleIndicator);
            this.tabPage2.Controls.Add(this.PortIndicator1);
            this.tabPage2.Controls.Add(this.btnConnect1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serial/USB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRescanSerial
            // 
            this.btnRescanSerial.BackColor = System.Drawing.Color.Transparent;
            this.btnRescanSerial.FlatAppearance.BorderSize = 0;
            this.btnRescanSerial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnRescanSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRescanSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescanSerial.Image = global::PCBsetup.Properties.Resources.Update;
            this.btnRescanSerial.Location = new System.Drawing.Point(167, 111);
            this.btnRescanSerial.Name = "btnRescanSerial";
            this.btnRescanSerial.Size = new System.Drawing.Size(72, 72);
            this.btnRescanSerial.TabIndex = 227;
            this.btnRescanSerial.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRescanSerial.UseVisualStyleBackColor = false;
            this.btnRescanSerial.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 72);
            this.button2.TabIndex = 140;
            this.button2.Text = "Monitor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFirmware
            // 
            this.btnFirmware.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFirmware.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFirmware.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmware.Location = new System.Drawing.Point(296, 111);
            this.btnFirmware.Name = "btnFirmware";
            this.btnFirmware.Size = new System.Drawing.Size(95, 72);
            this.btnFirmware.TabIndex = 139;
            this.btnFirmware.Text = "Firmware";
            this.btnFirmware.UseVisualStyleBackColor = false;
            this.btnFirmware.Click += new System.EventHandler(this.btnFirmware_Click);
            // 
            // cboPort1
            // 
            this.cboPort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort1.DropDownWidth = 145;
            this.cboPort1.FormattingEnabled = true;
            this.cboPort1.Location = new System.Drawing.Point(15, 17);
            this.cboPort1.Name = "cboPort1";
            this.cboPort1.Size = new System.Drawing.Size(377, 32);
            this.cboPort1.TabIndex = 133;
            this.cboPort1.SelectedIndexChanged += new System.EventHandler(this.cboPort1_SelectedIndexChanged);
            this.cboPort1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboPort1_HelpRequested);
            // 
            // ModuleIndicator
            // 
            this.ModuleIndicator.BackColor = System.Drawing.SystemColors.Control;
            this.ModuleIndicator.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleIndicator.Image = global::PCBsetup.Properties.Resources.Off;
            this.ModuleIndicator.Location = new System.Drawing.Point(351, 58);
            this.ModuleIndicator.Name = "ModuleIndicator";
            this.ModuleIndicator.Size = new System.Drawing.Size(41, 37);
            this.ModuleIndicator.TabIndex = 137;
            this.ModuleIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModuleIndicator.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ModuleIndicator_HelpRequested);
            // 
            // PortIndicator1
            // 
            this.PortIndicator1.BackColor = System.Drawing.SystemColors.Control;
            this.PortIndicator1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortIndicator1.Image = global::PCBsetup.Properties.Resources.Off;
            this.PortIndicator1.Location = new System.Drawing.Point(304, 58);
            this.PortIndicator1.Name = "PortIndicator1";
            this.PortIndicator1.Size = new System.Drawing.Size(41, 37);
            this.PortIndicator1.TabIndex = 136;
            this.PortIndicator1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PortIndicator1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PortIndicator1_HelpRequested);
            // 
            // btnConnect1
            // 
            this.btnConnect1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConnect1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect1.Location = new System.Drawing.Point(15, 58);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(105, 37);
            this.btnConnect1.TabIndex = 135;
            this.btnConnect1.Text = "Connect";
            this.btnConnect1.UseVisualStyleBackColor = false;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 338);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModule);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "PCBsetup";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbType.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbModule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbType;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSettingsNetwork;
        private System.Windows.Forms.Button btnFirmwareNetwork;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSendSubnet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEthernet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFirmware;
        private System.Windows.Forms.ComboBox cboPort1;
        private System.Windows.Forms.Label ModuleIndicator;
        private System.Windows.Forms.Label PortIndicator1;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.Button btnRescanSerial;
    }
}