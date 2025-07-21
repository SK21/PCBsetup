using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PCBsetup.Classes
{
    /// <summary>
    /// UdpComm handles sending byte arrays over UDP and receiving string sentences asynchronously,
    /// preventing UI lockups by offloading work to background tasks and using queues.
    /// 
    /// Usage:
    /// 
    /// // 1. Instantiate with local port, remote address, and port:
    /// var udp = new UdpComm(5000, "192.168.1.100", 6000);
    /// 
    /// // 2. Subscribe to incoming messages:
    /// udp.MessageReceived += (s, msg) => Console.WriteLine("Received: " + msg);
    /// 
    /// // 3. Send a byte array:
    /// await udp.SendAsync(Encoding.UTF8.GetBytes("Hello\n"));
    /// 
    /// // 4. Dispose when done:
    /// udp.Dispose();
    /// </summary>
    public class UDPmessages : IDisposable
    {
        private readonly UdpClient _udpClient;
        private readonly IPEndPoint _remoteEndPoint;
        private readonly ConcurrentQueue<string> _receiveQueue = new ConcurrentQueue<string>();
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly Task _receiveLoopTask;
        private readonly Task _processLoopTask;

        /// <summary>Event fired when a new message is processed.</summary>
        public event EventHandler<string> MessageReceived;

        /// <summary>
        /// Construct a new UdpComm.
        /// </summary>
        /// <param name="localPort">Local port to bind for listening.</param>
        /// <param name="remoteAddress">Remote host address to send data.</param>
        /// <param name="remotePort">Remote host port to send data.</param>
        public UDPmessages(int localPort, string remoteAddress, int remotePort)
        {
            _udpClient = new UdpClient(localPort);
            _remoteEndPoint = new IPEndPoint(IPAddress.Parse(remoteAddress), remotePort);

            // Start background loops
            _receiveLoopTask = Task.Run(() => ReceiveLoopAsync(_cts.Token));
            _processLoopTask = Task.Run(() => ProcessLoopAsync(_cts.Token));
        }

        /// <summary>
        /// Send a byte array over UDP to the remote endpoint.
        /// </summary>
        /// <param name="data">Bytes to send.</param>
        public async Task<bool> SendAsync(byte[] data)
        {
            try
            {
                await _udpClient.SendAsync(data, data.Length, _remoteEndPoint).ConfigureAwait(false);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Loop receiving UDP datagrams and enqueue string messages.
        /// </summary>
        private async Task ReceiveLoopAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var result = await _udpClient.ReceiveAsync().ConfigureAwait(false);
                    string message = Encoding.UTF8.GetString(result.Buffer).TrimEnd('\r', '\n');
                    _receiveQueue.Enqueue(message);
                }
                catch (ObjectDisposedException)
                {
                    break;
                }
                catch (Exception)
                {
                    // swallow or log
                }
            }
        }

        /// <summary>
        /// Loop processing queued messages and raising events.
        /// </summary>
        private async Task ProcessLoopAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                while (_receiveQueue.TryDequeue(out var msg))
                {
                    try
                    {
                        MessageReceived?.Invoke(this, msg);
                    }
                    catch
                    {
                        // swallow handler exceptions
                    }
                }

                await Task.Delay(10, token).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Dispose of resources and stop loops.
        /// </summary>
        public void Dispose()
        {
            _cts.Cancel();
            _udpClient.Close();
            _udpClient.Dispose();
        }
    }
}
