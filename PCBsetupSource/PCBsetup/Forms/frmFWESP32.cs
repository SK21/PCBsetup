using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmFWESP32 : Form
    {
        // https://nerdiy.de/en/howto-esp8266-mit-dem-esptool-bin-dateien-unter-windows-flashen/

        private frmMain mf;
        private bool UserSelectedFile = true;

        public frmFWESP32(frmMain CallingForm)
        {
            InitializeComponent();
            mf = CallingForm;
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            UserSelectedFile = true;
            tbHexfile.Text = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 0;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbHexfile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            UserSelectedFile = false;
            UpdateForm();
        }

        private void btnDefault_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Load defaults.";

            mf.Tls.ShowHelp(Message);
            hlpevent.Handled = true;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string NewFileBinary = "";
            string PathName;
            string UploadTool = "";
            string arg = "";
            string BootLoader = "BootLoader.tmp";
            string Partitions = "Partitions.tmp";
            try
            {
                SetButtons(true);

                NewFileBinary = Path.GetTempFileName();
                PathName = Path.GetDirectoryName(NewFileBinary);

                // esp32
                BootLoader = PathName + "\\" + BootLoader;
                Partitions = PathName + "\\" + Partitions;
                if (UserSelectedFile)
                {
                    File.Copy(tbHexfile.Text, NewFileBinary, true);

                    string SourceFile = tbHexfile.Text.Replace(".bin", ".bootloader.bin");
                    File.Copy(SourceFile, BootLoader, true);

                    SourceFile = tbHexfile.Text.Replace(".bin", ".partitions.bin");
                    File.Copy(SourceFile, Partitions, true);
                }
                else
                {
                    File.Copy(mf.Tls.HexDir() + "\\ESP32Rate\\RC_ESP32.ino.bootloader.bin", BootLoader, true);
                    File.Copy(mf.Tls.HexDir() + "\\ESP32Rate\\RC_ESP32.ino.partitions.bin", Partitions, true);
                    File.Copy(mf.Tls.HexDir() + "\\ESP32Rate\\RC_ESP32.ino.bin", NewFileBinary, true);
                }
                arg = "--chip esp32 --port " + mf.SelectedPortName() + " --baud " + "460800"
                    + " --before default_reset --after hard_reset write_flash -z --flash_mode dio"
                    + " 0x1000 " + BootLoader + " 0x8000 " + Partitions + " 0x10000 " + NewFileBinary;

                File.WriteAllBytes(PathName + "//esptool.exe", PCBsetup.Properties.Resources.esptool);
                Process myProcess = null;
                UploadTool = PathName + "//esptool.exe";
                myProcess = Process.Start(UploadTool, arg);

                int MaxTime = 120000;   // 2 minutes
                DateTime StartTime = DateTime.Now;
                bool TimedOut = false;

                while (!myProcess.WaitForExit(1000))
                {
                    if ((DateTime.Now - StartTime).TotalMilliseconds > MaxTime)
                    {
                        // Timeout reached: kill the process and exit the wait loop.
                        myProcess.Kill();
                        TimedOut = true;
                        break;
                    }
                }

                if (TimedOut)
                {
                    mf.Tls.ShowHelp("Flash process timed out and was aborted.", "ESP Rate", 10000, true);
                }
                else if (myProcess.ExitCode != 0)
                {
                    mf.Tls.ShowHelp("Flash failed with arguments: " + arg, "ESP Rate", 10000, true);
                }
                else
                {
                    mf.Tls.ShowHelp("Flash complete.", "ESP Rate", 5000);
                }
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp(ex.Message, "ESP Rate", 15000, true);
            }
            finally
            {
                SetButtons(false);

                // Clean up temporary files
                string[] tempFiles = new string[] { NewFileBinary, UploadTool, BootLoader, Partitions };
                foreach (var file in tempFiles)
                {
                    if (!string.IsNullOrEmpty(file) && File.Exists(file))
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch
                        {
                            // Optionally, log the error or notify that deletion failed.
                        }
                    }
                }
            }
        }

        private void btnUpload_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Upload to module.";

            mf.Tls.ShowHelp(Message);
            hlpevent.Handled = true;
        }

        private void frmD1rate_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                mf.Tls.SaveFormData(this);
            }
        }

        private void frmD1rate_Load(object sender, EventArgs e)
        {
            mf.Tls.LoadFormData(this);
            this.BackColor = PCBsetup.Properties.Settings.Default.DayColour;
            UserSelectedFile = false;
            SetButtons(false);
            UpdateForm();
        }

        private void SetButtons(bool Edited)
        {
            if (Edited)
            {
                btnBrowse.Enabled = false;
                btnDefault.Enabled = false;
                btnUpload.Enabled = false;
            }
            else
            {
                btnBrowse.Enabled = true;
                btnDefault.Enabled = true;
                btnUpload.Enabled = true;
            }
        }

        private void UpdateForm()
        {
            lbPort.Text = "Serial Port: " + mf.SelectedPortName();
            this.Text = "ESP32 Rate";
            tbHexfile.Text = "File version date:  " + mf.VC.ModuleDate((int)ModuleTypes.ESP_Rate).ToString("dd-MMM-yyyy");
        }
    }
}