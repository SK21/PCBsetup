using PCBsetup.Forms;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PCBsetup
{
    public class clsTools
    {
        private static Hashtable ht;
        private string cAppDir;
        private string cAppName = "PCBsetup";
        private string cAppVersion = "2.0.0";
        private string cFileName;
        private string cFirmwareDir;
        private string cVersionDate = "19-Jul-2025";
        private frmMain mf;

        public clsTools(frmMain CallingForm)
        {
            mf = CallingForm;
            CheckFolders();
        }

        public string AppDir()
        {
            return cAppDir;
        }

        public string AppVersion()
        {
            return cAppVersion;
        }

        public byte CRC(byte[] Data, int Length, byte Start = 0)
        {
            byte Result = 0;
            if (Length <= Data.Length)
            {
                int CK = 0;
                for (int i = Start; i < Length; i++)
                {
                    CK += Data[i];
                }
                Result = (byte)CK;
            }
            return Result;
        }

        public void DrawGroupBox(GroupBox box, Graphics g, Color BackColor, Color textColor, Color borderColor, float borderWidth = 1)
        {
            // useage:
            // point the Groupbox paint event to this sub:
            // private void groupBox1_Paint(object sender, PaintEventArgs e)
            //{
            //    GroupBox box = sender as GroupBox;
            // mf.Tls.DrawGroupBox(box, e.Graphics, this.BackColor, Color.Black, Color.Red, 3); // Red border with thickness 3
            //}
            if (box != null)
            {
                using (Brush textBrush = new SolidBrush(textColor))
                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    SizeF strSize = g.MeasureString(box.Text, box.Font);
                    Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                                   box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                                   box.ClientRectangle.Width - 1,
                                                   box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                    // Clear text and border
                    g.Clear(BackColor);

                    // Draw text
                    g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                    // Drawing Border
                    // Left
                    g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                    // Right
                    g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                    // Bottom
                    g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                    // Top1
                    g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                    // Top2
                    g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
                }
            }
        }

        public string FirmwareDir()
        {
            return cFirmwareDir;
        }

        public bool GoodCRC(byte[] Data, byte Start = 0)
        {
            bool Result = false;
            int Length = Data.Length;
            byte cr = CRC(Data, Length - 1, Start);
            Result = (cr == Data[Length - 1]);
            return Result;
        }

        public string HexDir()
        {
            return cFirmwareDir + "\\ModulesHex";
        }

        public bool IsOnScreen(Form form, bool PutOnScreen = false)
        {
            // Create rectangle
            Rectangle formRectangle = new Rectangle(form.Left, form.Top, form.Width, form.Height);

            // Test
            bool IsOn = Screen.AllScreens.Any(s => s.WorkingArea.IntersectsWith(formRectangle));

            if (!IsOn & PutOnScreen)
            {
                form.Top = 0;
                form.Left = 0;
            }

            return IsOn;
        }

        public bool IsPathSafeToDelete(string candidatePath)
        {
            bool result = false;
            try
            {
                string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string baseFolder = Path.Combine(myDocuments, "PCBsetup");

                if (!string.IsNullOrEmpty(candidatePath))
                {
                    string candidateFullPath = Path.GetFullPath(candidatePath);
                    string safeBaseFullPath = Path.GetFullPath(baseFolder);

                    // If the candidate is a file, use its parent folder for the containment check.
                    if (File.Exists(candidateFullPath))
                    {
                        candidateFullPath = Path.GetDirectoryName(candidateFullPath);
                    }

                    // Normalize paths
                    candidateFullPath = candidateFullPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                    safeBaseFullPath = safeBaseFullPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

                    // Check if the candidate path is within the safe base folder
                    string safeBaseWithSeparator = safeBaseFullPath + Path.DirectorySeparatorChar;
                    result = candidateFullPath.StartsWith(safeBaseWithSeparator, StringComparison.OrdinalIgnoreCase);
                }
            }
            catch (Exception ex)
            {
                WriteErrorLog("Props/SafeToDelete: " + ex.Message);
            }
            return result;
        }

        public void LoadFormData(Form Frm)
        {
            int Leftloc = 0;
            int.TryParse(LoadProperty(Frm.Name + ".Left"), out Leftloc);
            Frm.Left = Leftloc;

            int Toploc = 0;
            int.TryParse(LoadProperty(Frm.Name + ".Top"), out Toploc);
            Frm.Top = Toploc;

            IsOnScreen(Frm, true);
        }

        public string LoadProperty(string Key)
        {
            string Prop = "";
            if (ht.Contains(Key)) Prop = ht[Key].ToString();
            return Prop;
        }

        public bool PrevInstance()
        {
            string PrsName = Process.GetCurrentProcess().ProcessName;
            Process[] All = Process.GetProcessesByName(PrsName); //Get the name of all processes having the same name as this process name
            if (All.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SaveFormData(Form Frm)
        {
            SaveProperty(Frm.Name + ".Left", Frm.Left.ToString());
            SaveProperty(Frm.Name + ".Top", Frm.Top.ToString());
        }

        public void SaveProperty(string Key, string Value)
        {
            bool Changed = false;
            if (ht.Contains(Key))
            {
                if (!ht[Key].ToString().Equals(Value))
                {
                    ht[Key] = Value;
                    Changed = true;
                }
            }
            else
            {
                ht.Add(Key, Value);
                Changed = true;
            }
            if (Changed) SaveProperties();
        }

        public void ShowHelp(string Message, string Title = "Help",
            int timeInMsec = 30000, bool LogError = false, bool Modal = false)
        {
            var Hlp = new frmHelp(mf, Message, Title, timeInMsec);
            if (Modal)
            {
                Hlp.ShowDialog();
            }
            else
            {
                Hlp.Show();
            }

            if (LogError) WriteErrorLog(Message);
        }

        public bool UDP_BroadcastPGN(byte[] Data)
        {
            // send UDP
            // based on AGIO/FormUDP
            bool Result = false;

            try
            {
                IPEndPoint epModuleSet = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 28888);

                //loop thru all interfaces
                foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.Supports(NetworkInterfaceComponent.IPv4) && nic.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (var info in nic.GetIPProperties().UnicastAddresses)
                        {
                            // Only InterNetwork and not loopback which have a subnetmask
                            if (info.Address.AddressFamily == AddressFamily.InterNetwork &&
                                !IPAddress.IsLoopback(info.Address) &&
                                info.IPv4Mask != null)
                            {
                                Socket scanSocket;
                                if (nic.OperationalStatus == OperationalStatus.Up
                                    && info.IPv4Mask != null)
                                {
                                    scanSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                                    scanSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
                                    scanSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                                    scanSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontRoute, true);
                                    scanSocket.Bind(new IPEndPoint(info.Address, 9578));
                                    scanSocket.SendTo(Data, 0, Data.Length, SocketFlags.None, epModuleSet);
                                    scanSocket.Dispose();
                                }
                            }
                        }
                    }
                }
                Result = true;
            }
            catch (Exception ex)
            {
                WriteErrorLog("clsTools/UDP_BroadcastPGN: " + ex.Message);
            }

            return Result;
        }

        public string VersionDate()
        {
            return cVersionDate;
        }

        public void WriteErrorLog(string strErrorText)
        {
            try
            {
                string FileName = cAppDir + "\\Error Log.txt";
                TrimFile(FileName);
                File.AppendAllText(FileName, DateTime.Now.ToString() + "  -  " + strErrorText + "\r\n\r\n");
            }
            catch (Exception)
            {
            }
        }

        private void CheckFolders()
        {
            try
            {
                // SettingsDir
                cAppDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + cAppName;
                if (!Directory.Exists(cAppDir)) Directory.CreateDirectory(cAppDir);
                cFirmwareDir = cAppDir + "\\Firmware";
                if (!Directory.Exists(cFirmwareDir)) Directory.CreateDirectory(cFirmwareDir);

                cFileName = cAppDir + "\\Settings.txt";
                if (!File.Exists(cFileName)) File.Create(cFileName).Dispose();
                LoadProperties();
            }
            catch (Exception)
            {
            }
        }

        private void LoadProperties()
        {
            // property:  key=value  ex: "LastFile=Main.mdb"
            try
            {
                ht = new Hashtable();
                string[] lines = File.ReadAllLines(cFileName);
                foreach (string line in lines)
                {
                    if (line.Contains("=") && !string.IsNullOrEmpty(line.Split('=')[0]) && !string.IsNullOrEmpty(line.Split('=')[1]))
                    {
                        string[] splitText = line.Split('=');
                        ht.Add(splitText[0], splitText[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteErrorLog("Tools: LoadProperties: " + ex.Message);
            }
        }

        private void SaveProperties()
        {
            try
            {
                string[] NewLines = new string[ht.Count];
                int i = -1;
                foreach (DictionaryEntry Pair in ht)
                {
                    i++;
                    NewLines[i] = Pair.Key.ToString() + "=" + Pair.Value.ToString();
                }
                if (i > -1) File.WriteAllLines(cFileName, NewLines);
            }
            catch (Exception)
            {
            }
        }

        private void TrimFile(string FileName, int MaxSize = 100000)
        {
            try
            {
                if (File.Exists(FileName))
                {
                    long FileSize = new FileInfo(FileName).Length;
                    if (FileSize > MaxSize)
                    {
                        // trim file
                        string[] Lines = File.ReadAllLines(FileName);
                        int Len = Lines.Length;
                        int St = (int)(Len * .1); // skip first 10% of old lines
                        string[] NewLines = new string[Len - St];
                        Array.Copy(Lines, St, NewLines, 0, Len - St);
                        File.Delete(FileName);
                        File.AppendAllLines(FileName, NewLines);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}