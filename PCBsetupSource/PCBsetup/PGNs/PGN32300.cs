using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32300
    {
        //      Steering PCB config
        //0     HeaderLo    44
        //1     HeaderHi    126
        //2     Receiver    0-None, 1-SimpleRTK2B
        //3     Receiver serial port
        //4     IMU serial port
        //5     Minimum speed
        //6     Maximum speed
        //7     Pulse cal X 10, Lo
        //8     Pulse cal X 10, Hi
        //9     Relay control type, 0 - no relays, 1 - , 2 - PCA9555 8 relays, 3 - PCA9555 16 relays, 4 - MCP23017, 5 - GPIO
        //10    Commands
        //          - bit 0, swap pitch for roll
        //          - bit 1, invert roll
        //          - bit 2, use 4_20 for analog
        //          - bit 3, relay on signal
        //          - bit 4, zero WAS
        //11    CRC

        private byte[] cData = new byte[12];
        private frmSetTeensySteer cf;

        public PGN32300(frmSetTeensySteer CalledFrom)
        {
            cf = CalledFrom;
            cData[0] = 44;
            cData[1] = 126;
        }
        public  bool Send()
        {
            bool Result = false;
            byte tmp;
            string Name;
            bool Checked;

            byte.TryParse(cf.mf.Tls.LoadProperty("cbTSreceiver"), out tmp);
            cData[2] = tmp;
            cData[3] = (byte)cf.Boxes.Value("tbTSReceiverPort");
            cData[4] = (byte)cf.Boxes.Value("tbTSIMUport");

            cData[5] = (byte)cf.Boxes.Value("tbTSMinSpeed");
            cData[6] = (byte)cf.Boxes.Value("tbTSMaxSpeed");

            double val = cf.Boxes.Value("tbTSPulseCal");
            cData[7] = (byte)(val * 10);
            cData[8] = (byte)((int)(val * 10) >> 8);

            cData[9] = (byte)cf.Boxes.Value("cbTSrelayControl");

            // check boxes
            cData[10] = 0;
            for (int i = 0; i < cf.CKs.Length; i++)
            {
                Name = cf.CKs[i].Name;
                bool.TryParse(cf.mf.Tls.LoadProperty(Name), out Checked);
                if (Checked) cData[10] |= (byte)Math.Pow(2, i);
            }

            // CRC
            cData[11] = cf.mf.Tls.CRC(cData, 11);

            switch (cf.mf.ConnectionType)
            {
                case 0:
                    // send serial
                    try
                    {
                        Result =  cf.mf.CommPort.Send(cData);
                    }
                    catch (Exception ex)
                    {
                        cf.mf.Tls.WriteErrorLog("PGN32300/send serial: " + ex.Message);
                    }
                    break;

                case 1:
                    // send ethernet
                    cf.mf.UDPmodules.SendUDPMessage(cData);
                    Result = true;
                    break;
            }

            return Result;
        }
    }
}
