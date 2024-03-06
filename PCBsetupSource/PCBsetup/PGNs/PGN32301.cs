using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32301
    {
        //      Steering pins
        //0     HeaderLo    45
        //1     HeaderHi    126
        //2     motor dir
        //3     motor pwm
        //4     power relay
        //5     steering relay
        //6     steer switch
        //7     work switch
        //8     speed pulse
        //9-24  relay pins
        //25    CRC

        private byte[] cData = new byte[26];
        private frmSetTeensySteer cf;

        public PGN32301(frmSetTeensySteer CalledFrom)
        {
            cf = CalledFrom;
            cData[0] = 45;
            cData[1] = 126;
        }

        public bool Send()
        {
            bool Result = false;

            cData[2] = (byte)cf.Boxes.Value("tbTSDir");
            cData[3] = (byte)cf.Boxes.Value("tbTSPWM");

            cData[4] = (byte)cf.Boxes.Value("tbTSpowerRelay");
            cData[5] = (byte)cf.Boxes.Value("tbTSsteerRelay");

            cData[6] = (byte)cf.Boxes.Value("tbTSsteerSwitch");
            cData[7] = (byte)cf.Boxes.Value("tbTSworkSwitch");

            cData[8] = (byte)cf.Boxes.Value("tbTSspeedPulse");

            for (int i = 1; i < 17; i++)
            {
                cData[i + 8] = (byte)cf.Boxes.Value("tbTSr" + i.ToString());
            }

            // CRC
            cData[25] = cf.mf.Tls.CRC(cData, 25);

            try
            {
                // send serial
                Result = cf.mf.CommPort.Send(cData);
            }
            catch (Exception ex)
            {
                cf.mf.Tls.WriteErrorLog("PGN32301/send serial: " + ex.Message);
            }

            if (!Result)
            {
                // send ethernet
                Result = cf.mf.Tls.UDP_BroadcastPGN(cData);
            }

            return Result;
        }
    }
}