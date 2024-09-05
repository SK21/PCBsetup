namespace PCBsetup.Forms
{
    partial class frmDiag
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiag));
            this.label26 = new System.Windows.Forms.Label();
            this.lbInoID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bntOK = new System.Windows.Forms.Button();
            this.lbByte1 = new System.Windows.Forms.Label();
            this.lbByte2 = new System.Windows.Forms.Label();
            this.lbByte3 = new System.Windows.Forms.Label();
            this.lbByte4 = new System.Windows.Forms.Label();
            this.lbByte5 = new System.Windows.Forms.Label();
            this.lbByte6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.lbWAS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 24);
            this.label26.TabIndex = 43;
            this.label26.Text = "Ino ID";
            // 
            // lbInoID
            // 
            this.lbInoID.Location = new System.Drawing.Point(121, 9);
            this.lbInoID.Name = "lbInoID";
            this.lbInoID.Size = new System.Drawing.Size(70, 24);
            this.lbInoID.TabIndex = 44;
            this.lbInoID.Text = "0";
            this.lbInoID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Byte 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Byte 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Byte 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Byte 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "Byte 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Byte 5";
            // 
            // bntOK
            // 
            this.bntOK.BackColor = System.Drawing.Color.Transparent;
            this.bntOK.FlatAppearance.BorderSize = 0;
            this.bntOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntOK.Image = global::PCBsetup.Properties.Resources.bntOK_Image;
            this.bntOK.Location = new System.Drawing.Point(27, 376);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(174, 72);
            this.bntOK.TabIndex = 51;
            this.bntOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntOK.UseVisualStyleBackColor = false;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // lbByte1
            // 
            this.lbByte1.Location = new System.Drawing.Point(121, 44);
            this.lbByte1.Name = "lbByte1";
            this.lbByte1.Size = new System.Drawing.Size(70, 24);
            this.lbByte1.TabIndex = 52;
            this.lbByte1.Text = "0";
            this.lbByte1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbByte2
            // 
            this.lbByte2.Location = new System.Drawing.Point(121, 79);
            this.lbByte2.Name = "lbByte2";
            this.lbByte2.Size = new System.Drawing.Size(70, 24);
            this.lbByte2.TabIndex = 53;
            this.lbByte2.Text = "0";
            this.lbByte2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbByte3
            // 
            this.lbByte3.Location = new System.Drawing.Point(121, 114);
            this.lbByte3.Name = "lbByte3";
            this.lbByte3.Size = new System.Drawing.Size(70, 24);
            this.lbByte3.TabIndex = 54;
            this.lbByte3.Text = "0";
            this.lbByte3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbByte4
            // 
            this.lbByte4.Location = new System.Drawing.Point(121, 149);
            this.lbByte4.Name = "lbByte4";
            this.lbByte4.Size = new System.Drawing.Size(70, 24);
            this.lbByte4.TabIndex = 55;
            this.lbByte4.Text = "0";
            this.lbByte4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbByte5
            // 
            this.lbByte5.Location = new System.Drawing.Point(121, 184);
            this.lbByte5.Name = "lbByte5";
            this.lbByte5.Size = new System.Drawing.Size(70, 24);
            this.lbByte5.TabIndex = 56;
            this.lbByte5.Text = "0";
            this.lbByte5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbByte6
            // 
            this.lbByte6.Location = new System.Drawing.Point(121, 219);
            this.lbByte6.Name = "lbByte6";
            this.lbByte6.Size = new System.Drawing.Size(70, 24);
            this.lbByte6.TabIndex = 57;
            this.lbByte6.Text = "0";
            this.lbByte6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Time";
            // 
            // lbTime
            // 
            this.lbTime.Location = new System.Drawing.Point(87, 335);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(134, 24);
            this.lbTime.TabIndex = 59;
            this.lbTime.Text = "0";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeading
            // 
            this.lbHeading.Location = new System.Drawing.Point(121, 289);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(70, 24);
            this.lbHeading.TabIndex = 63;
            this.lbHeading.Text = "0";
            this.lbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWAS
            // 
            this.lbWAS.Location = new System.Drawing.Point(121, 254);
            this.lbWAS.Name = "lbWAS";
            this.lbWAS.Size = new System.Drawing.Size(70, 24);
            this.lbWAS.TabIndex = 62;
            this.lbWAS.Text = "0";
            this.lbWAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 61;
            this.label10.Text = "Heading";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 24);
            this.label11.TabIndex = 60;
            this.label11.Text = "WAS";
            // 
            // frmDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 461);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.lbWAS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbByte6);
            this.Controls.Add(this.lbByte5);
            this.Controls.Add(this.lbByte4);
            this.Controls.Add(this.lbByte3);
            this.Controls.Add(this.lbByte2);
            this.Controls.Add(this.lbByte1);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInoID);
            this.Controls.Add(this.label26);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiag";
            this.ShowInTaskbar = false;
            this.Text = "Steer Diagnostics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDiag_FormClosed);
            this.Load += new System.EventHandler(this.frmDiag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbInoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Label lbByte1;
        private System.Windows.Forms.Label lbByte2;
        private System.Windows.Forms.Label lbByte3;
        private System.Windows.Forms.Label lbByte4;
        private System.Windows.Forms.Label lbByte5;
        private System.Windows.Forms.Label lbByte6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Label lbWAS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}