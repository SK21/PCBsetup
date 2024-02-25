﻿using PCBsetup.Forms;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace PCBsetup
{
    public class UDPComm
    {
        private readonly frmMain mf;
        private byte[] buffer = new byte[1024];
        private IPAddress cEthernetEP;
        private bool cIsUDPSendConnected;
        private int cReceivePort;

        private int cSendFromPort;
        private int cSendToPort;
        private bool cUpdateDestinationIP;

        private HandleDataDelegateObj HandleDataDelegate = null;

        private Socket recvSocket;
        private Socket sendSocket;

        public UDPComm(frmMain CallingForm, int ReceivePort, int SendToPort, int SendFromPort)
        {
            mf = CallingForm;
            cReceivePort = ReceivePort;
            cSendToPort = SendToPort;
            cSendFromPort = SendFromPort;
            SetEndPoints();
        }

        // Status delegate
        private delegate void HandleDataDelegateObj(int port, byte[] msg);

        public string EthernetIP()
        {
            string Adr;
            IPAddress IP;
            string Result;

            Adr = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            if (IPAddress.TryParse(Adr, out IP))
            {
                Result = IP.ToString();
            }
            else
            {
                Result = "127.0.0.1";
            }
            return Result;
        }

        //sends byte array
        public bool SendUDPMessage(byte[] byteData)
        {
            bool Result = false;
            try
            {
                if (byteData.Length != 0)
                {
                    // ethernet
                    IPEndPoint EndPt = new IPEndPoint(cEthernetEP, cSendToPort);
                    sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, EndPt, new AsyncCallback(SendData), null);
                }
                Result = true;
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("UDPcomm/SendUDPMessage " + ex.Message);
            }
            return Result;
        }

        public void StartUDPServer()
        {
            try
            {
                // initialize the delegate which updates the message received
                HandleDataDelegate = HandleData;

                // initialize the receive socket
                recvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                recvSocket.Bind(new IPEndPoint(IPAddress.Any, cReceivePort));

                // initialize the send socket
                sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                sendSocket.EnableBroadcast = true;

                // Initialise the IPEndPoint for the server to send on port
                IPEndPoint server = new IPEndPoint(IPAddress.Any, cSendFromPort);
                sendSocket.Bind(server);

                // Initialise the IPEndPoint for the client - async listner client only!
                EndPoint client = new IPEndPoint(IPAddress.Any, 0);

                // Start listening for incoming data
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref client, new AsyncCallback(ReceiveData), recvSocket);
            }
            catch (Exception e)
            {
                //mf.Tls.ShowHelp("UDP start error: \n" + e.Message, "Comm", 3000, true);
                mf.Tls.WriteErrorLog("StartUDPServer: \n" + e.Message);
            }
        }

        private string GetLocalIPv4(NetworkInterfaceType _type)
        {
            // https://stackoverflow.com/questions/6803073/get-local-ip-address

            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        private void HandleData(int Port, byte[] Data)
        {
            try
            {
                int PGN = Data[1] << 8 | Data[0];
                switch (PGN)
                {
                    case 0xABC:
                        // debug info from module
                        Debug.Print("");
                        for (int i = 0; i < Data.Length; i++)
                        {
                            Debug.Print(DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "  " + i.ToString() + " " + Data[i].ToString());
                        }
                        Debug.Print("");
                        break;
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("UDPcomm/HandleData " + ex.Message);
            }
        }

        private void ReceiveData(IAsyncResult asyncResult)
        {
            try
            {
                // Initialise the IPEndPoint for the client
                EndPoint epSender = new IPEndPoint(IPAddress.Any, 0);

                // Receive all data
                int msgLen = recvSocket.EndReceiveFrom(asyncResult, ref epSender);

                byte[] localMsg = new byte[msgLen];
                Array.Copy(buffer, localMsg, msgLen);

                // Listen for more connections again...
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback(ReceiveData), epSender);

                int port = ((IPEndPoint)epSender).Port;
                // Update status through a delegate
                mf.Invoke(HandleDataDelegate, new object[] { port, localMsg });
            }
            catch (System.ObjectDisposedException)
            {
                // do nothing
            }
            catch (Exception ex)
            {
                //mf.Tls.ShowHelp("ReceiveData Error \n" + e.Message, "Comm", 3000, true);
                mf.Tls.WriteErrorLog("UDPcomm/ReceiveData " + ex.Message);
            }
        }

        private void SendData(IAsyncResult asyncResult)
        {
            try
            {
                sendSocket.EndSend(asyncResult);
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog(" UDP Send Data" + ex.ToString());
            }
        }

        private void SetEndPoints()
        {
            try
            {
                cEthernetEP = IPAddress.Parse(EthernetIP());
                byte[] parts = cEthernetEP.GetAddressBytes();
                string ads = parts[0].ToString() + "." + parts[1].ToString() + "." + parts[2].ToString() + ".255";
                cEthernetEP = IPAddress.Parse(ads);
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("UDPcomm/SetEndPoints " + ex.Message);
            }
        }
    }
}