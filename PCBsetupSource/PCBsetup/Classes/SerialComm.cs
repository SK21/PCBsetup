using PCBsetup.Forms;
using System;
using System.IO.Ports;
using System.Text;

namespace PCBsetup.Classes
{
    public class SerialComm
    {
        private readonly StringBuilder LogBuilder = new StringBuilder();
        private readonly object LogLock = new object();
        private readonly SerialPort Sport;
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
        {
            get
            {
                lock (LogLock)
                {
                    return LogBuilder.ToString();
                }
            }
        }

        public void ClosePort()
        {
            try
            {
                if (Sport.IsOpen)
                {
                    Sport.DataReceived -= Sport_DataReceived;
                    Sport.Close();
                    AddToLog("\nPort closed.\n");
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
                lock (LogLock)
                {
                    LogBuilder.Append(NewData);
                    if (LogBuilder.Length > 100000) LogBuilder.Remove(0, LogBuilder.Length - 25000);
                }
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
                    AddToLog("\nPort open.\n");

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
            try
            {
                if (Sport.IsOpen)
                {
                    string sentence = Sport.ReadExisting();
                    sentence = sentence.Replace("\0", "");  // remove nulls
                    AddToLog(sentence);
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("SerialComm/Sport_DataReceived: " + ex.Message);
            }
        }
    }
}