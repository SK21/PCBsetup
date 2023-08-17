namespace PCBsetup.Forms
{
    partial class frmNetwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNetwork));
            this.lbEthernet = new System.Windows.Forms.Label();
            this.btnSetEthernet = new System.Windows.Forms.Button();
            this.cbEthernet = new System.Windows.Forms.ComboBox();
            this.btnRescan = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbModuleInfo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEthernet
            // 
            this.lbEthernet.Location = new System.Drawing.Point(96, 31);
            this.lbEthernet.Name = "lbEthernet";
            this.lbEthernet.Size = new System.Drawing.Size(307, 26);
            this.lbEthernet.TabIndex = 155;
            this.lbEthernet.Text = "192.168.137.1";
            this.lbEthernet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetEthernet
            // 
            this.btnSetEthernet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSetEthernet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetEthernet.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetEthernet.Location = new System.Drawing.Point(276, 60);
            this.btnSetEthernet.Name = "btnSetEthernet";
            this.btnSetEthernet.Size = new System.Drawing.Size(127, 37);
            this.btnSetEthernet.TabIndex = 156;
            this.btnSetEthernet.Text = "Set";
            this.btnSetEthernet.UseVisualStyleBackColor = false;
            this.btnSetEthernet.Click += new System.EventHandler(this.btnSetEthernet_Click);
            // 
            // cbEthernet
            // 
            this.cbEthernet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEthernet.FormattingEnabled = true;
            this.cbEthernet.Location = new System.Drawing.Point(96, 64);
            this.cbEthernet.Name = "cbEthernet";
            this.cbEthernet.Size = new System.Drawing.Size(157, 32);
            this.cbEthernet.TabIndex = 154;
            // 
            // btnRescan
            // 
            this.btnRescan.BackColor = System.Drawing.Color.Transparent;
            this.btnRescan.FlatAppearance.BorderSize = 0;
            this.btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescan.Image = global::PCBsetup.Properties.Resources.Update;
            this.btnRescan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRescan.Location = new System.Drawing.Point(196, 308);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(72, 72);
            this.btnRescan.TabIndex = 160;
            this.btnRescan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRescan.UseVisualStyleBackColor = false;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::PCBsetup.Properties.Resources.Cancel64;
            this.btnCancel.Location = new System.Drawing.Point(352, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 72);
            this.btnCancel.TabIndex = 159;
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
            this.bntOK.Location = new System.Drawing.Point(430, 308);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(72, 72);
            this.bntOK.TabIndex = 158;
            this.bntOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntOK.UseVisualStyleBackColor = false;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbModuleInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 170);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modules";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // tbModuleInfo
            // 
            this.tbModuleInfo.Location = new System.Drawing.Point(6, 28);
            this.tbModuleInfo.Multiline = true;
            this.tbModuleInfo.Name = "tbModuleInfo";
            this.tbModuleInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbModuleInfo.Size = new System.Drawing.Size(478, 136);
            this.tbModuleInfo.TabIndex = 158;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Image = global::PCBsetup.Properties.Resources.UpArrow64;
            this.btnSend.Location = new System.Drawing.Point(274, 308);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(72, 72);
            this.btnSend.TabIndex = 162;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSend_HelpRequested);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbEthernet);
            this.groupBox2.Controls.Add(this.cbEthernet);
            this.groupBox2.Controls.Add(this.btnSetEthernet);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 114);
            this.groupBox2.TabIndex = 163;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network Subnet";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // frmNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNetwork";
            this.ShowInTaskbar = false;
            this.Text = "Network";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNetwork_FormClosed);
            this.Load += new System.EventHandler(this.frmNetwork_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEthernet;
        private System.Windows.Forms.Button btnSetEthernet;
        private System.Windows.Forms.ComboBox cbEthernet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbModuleInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}