using PCBsetup.Forms;
using System;
using System.Collections.Concurrent;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PCBsetup.Classes
{
    public class SerialComm : IDisposable
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly StringBuilder _logBuilder = new StringBuilder();
        private readonly object _logLock = new object();
        private readonly Task _processLoopTask;
        private readonly Task _readLoopTask;
        private readonly ConcurrentQueue<string> _receiveQueue = new ConcurrentQueue<string>();
        private readonly SerialPort _serialPort;
        private frmMain mf;
        public event Action PortDisconnected;

        public SerialComm(string portName, frmMain CallingForm, int baudRate = 38400)
        {
            mf = CallingForm;
            _serialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One)
            {
                ReadTimeout = 500,
                WriteTimeout = 500,
                Encoding = Encoding.UTF8,
                NewLine = "\r"
            };

            _serialPort.DtrEnable = true;
            _serialPort.RtsEnable = true;

            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
                AddToLog("Port open.", true);
            }

            // Start background tasks
            _readLoopTask = Task.Run(() => ReadLoopAsync(_cts.Token));
            _processLoopTask = Task.Run(() => ProcessLoopAsync(_cts.Token));
        }

        public bool IsOpen
        { get { return _serialPort.IsOpen; } }

        public string Log
        {
            get
            {
                lock (_logLock)
                {
                    return _logBuilder.ToString();
                }
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
            _serialPort.Close();
            _serialPort.Dispose();
            AddToLog("Port closed.", true);
        }

        public async Task<bool> SendAsync(byte[] data)
        {
            try
            {
                await Task.Run(() => _serialPort.Write(data, 0, data.Length)).ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("SerialMessage/SendAsync: " + ex.Message);
                return false;
            }
        }

        private void AddToLog(string message, bool ShowTime = false)
        {
            string entry = message;
            if (ShowTime) entry = $"{DateTime.Now:HH:mm:ss}: {message}";
            lock (_logLock)
            {
                _logBuilder.AppendLine(entry);
                if (_logBuilder.Length > 100_000)
                    _logBuilder.Remove(0, _logBuilder.Length - 80_000);
            }
        }

        private async Task ProcessLoopAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                while (_receiveQueue.TryDequeue(out var line))
                {
                    try
                    {
                        AddToLog(line);
                    }
                    catch (Exception ex)
                    {
                        mf.Tls.WriteErrorLog("SerialMessage/ProcessLoopAsync: " + ex.Message);
                    }
                }
                await Task.Delay(10, token).ConfigureAwait(false);
            }
        }

        private async Task ReadLoopAsync(CancellationToken token)
        {
            try
            {
                var sb = new StringBuilder();

                while (!token.IsCancellationRequested)
                {
                    // Grab all available bytes (non‐blocking)
                    string chunk = _serialPort.ReadExisting();
                    if (chunk.Length > 0)
                    {
                        sb.Append(chunk);

                        // Pull out each full line
                        int newline;
                        while ((newline = sb.ToString().IndexOf('\n')) >= 0)
                        {
                            string line = sb
                                .ToString(0, newline)
                                .TrimEnd('\r');
                            _receiveQueue.Enqueue(line);

                            // Remove the consumed segment
                            sb.Remove(0, newline + 1);
                        }
                    }
                    else
                    {
                        // No data—yield for a moment
                        await Task.Delay(20, token).ConfigureAwait(false);
                    }
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("ReadLoopAsync: " + ex.Message);
            }
        }
    }
}