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
        //      teensy steering config
        //0     HeaderLo    44
        //1     HeaderHi    126
        //2		power relay pin
        //3		steer relay pin
        //4     WAS pin
        //5     Current pin
        //6		Steer switch pin
        //7		Work switch pin
        //8		Dir pin
        //9		PWM pin
        //10    Receiver serial port
        //11	PassThr Out port
        //12	PassThru In port
        //13    IMU serial port
        //14    Commands
        //          - bit 0, zero WAS
        //          - bit 1, invert roll
        //          - bit 2, use ADS1115
        //15	-
        //16	CRC

        private byte[] cData = new byte[17];
        private frmSetTeensySteer cf;

        public PGN32300(frmSetTeensySteer CalledFrom)
        {
            cf = CalledFrom;
            cData[0] = 44;
            cData[1] = 126;
            cData[15] = 0;
        }
        public  bool Send()
        {
            bool Result = false;
            string Name;
            bool Checked;

            cData[2] = (byte)cf.Boxes.Value("tbTSpowerRelay");
            cData[3] = (byte)cf.Boxes.Value("tbTSsteerRelay");
            cData[4] = (byte)cf.Boxes.Value("tbTSwas");
            cData[5] = (byte)cf.Boxes.Value("tbTScurrent");
            cData[6] = (byte)cf.Boxes.Value("tbTSsteerSwitch");
            cData[7] = (byte)cf.Boxes.Value("tbTSworkSwitch");
            cData[8] = (byte)cf.Boxes.Value("tbTSdir");
            cData[9] = (byte)cf.Boxes.Value("tbTSpwm");

            cData[10] = (byte)cf.Boxes.Value("tbTSReceiverPort");
            cData[11] = (byte)cf.Boxes.Value("tbTSRS232Out");
            cData[12] = (byte)cf.Boxes.Value("tbTSRS232In");
            cData[13] = (byte)cf.Boxes.Value("tbTSIMUport");

            // check boxes
            cData[14] = 0;
            for (int i = 0; i < cf.CKs.Length; i++)
            {
                Name = cf.CKs[i].Name;
                bool.TryParse(cf.mf.Tls.LoadProperty(Name), out Checked);
                if (Checked) cData[14] |= (byte)Math.Pow(2, i);
            }

            // CRC
            cData[16] = cf.mf.Tls.CRC(cData, 16);

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
