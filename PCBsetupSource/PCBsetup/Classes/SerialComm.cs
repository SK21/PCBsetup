using PCBsetup.Forms;
using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

namespace PCBsetup.Classes
{
    public class SerialComm
    {
        private readonly SerialPort Sport;
        private string cLog = "";
        private frmMain mf;

        public SerialComm(string portName, frmMain CallingForm, int baudRate = 38400)
        {
            mf = CallingForm;
            Sport = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One)
            {
                ReadTimeout = 500,
                WriteTimeout = 500,
                DtrEnable = true,
                RtsEnable = true
            };
            OpenPort();
        }

        public event Action PortDisconnected;

        public bool IsOpen
        { get { return Sport.IsOpen; } }

        public string Log
        { get { return cLog; } }

        public void ClosePort()
        {
            try
            {
                if (Sport.IsOpen)
                {
                    Sport.DataReceived -= Sport_DataReceived;
                    Sport.Close();
                    AddToLog("Port closed.");
                    PortDisconnected?.Invoke();
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("SerialComm/ClosePort: " + ex.Message);
            }
            Sport.Dispose();
        }

        public bool Send(byte[] Data)
        {
            bool Result = false;
            try
            {
                Sport.Write(Data, 0, Data.Length);
                Result = true;
                Debug.Print("");
                Debug.Print("Data sent");
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("SerialComm/Send: " + ex.Message);
            }
            return Result;
        }

        private void AddToLog(string NewData)
        {
            try
            {
                string CleanData = NewData.Replace("\0", "");
                cLog += CleanData;
                if (cLog.Length > 100000)
                {
                    cLog = cLog.Substring(cLog.Length - 25000);
                }
                Debug.Print("");
                Debug.Print("Log length: " + cLog.Length);
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("SerialComm/AddToLog: " + ex.Message);
            }
        }

        private void OpenPort()
        {
            try
            {
                if (!Sport.IsOpen)
                {
                    Sport.Open();
                    AddToLog("Port open.");

                    Sport.DataReceived += Sport_DataReceived;
                    Sport.DiscardOutBuffer();
                    Sport.DiscardInBuffer();
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("SerialComm/OpenPort: " + ex.Message);
            }
        }

        private void Sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Sport.IsOpen)
            {
                try
                {
                    string sentence = Sport.ReadExisting();
                    mf.BeginInvoke((MethodInvoker)(() => AddToLog(sentence)));
                }
                catch (Exception ex)
                {
                    mf.Tls.WriteErrorLog("SerialComm/Sport_DataReceived: " + ex.Message);
                }
            }
        }
    }
}