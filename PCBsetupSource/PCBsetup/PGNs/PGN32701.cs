using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32701
    {
        // Switchbox pins
        //0         HeaderLo    189
        //1         HeaderHi    127
        //2         Auto
        //3         Master On
        //4         Master Off
        //5         Rate Up
        //6         Rate Down
        //7-22      switches 1-16
        //23        work pin
        //24        crc

        private byte[] cData = new byte[25];
        private frmSetNanoSwitchbox cf;

        public PGN32701(frmSetNanoSwitchbox CalledFrom)
        {
            cf = CalledFrom;
            cData[0] = 189;
            cData[1] = 127;
        }

        public bool Send()
        {
            bool Result = false;

            cData[2] = (byte)cf.Boxes.Value("tbAuto");
            cData[3] = (byte)cf.Boxes.Value("tbMasterOn");
            cData[4] = (byte)cf.Boxes.Value("tbMasterOff");
            cData[5] = (byte)cf.Boxes.Value("tbRateUp");
            cData[6] = (byte)cf.Boxes.Value("tbRateDown");

            cData[7] = (byte)cf.Boxes.Value("tbSW1");
            cData[8] = (byte)cf.Boxes.Value("tbSW2");
            cData[9] = (byte)cf.Boxes.Value("tbSW3");
            cData[10] = (byte)cf.Boxes.Value("tbSW4");
            cData[11] = (byte)cf.Boxes.Value("tbSW5");
            cData[12] = (byte)cf.Boxes.Value("tbSW6");
            cData[13] = (byte)cf.Boxes.Value("tbSW7");
            cData[14] = (byte)cf.Boxes.Value("tbSW8");

            cData[15] = (byte)cf.Boxes.Value("tbSW9");
            cData[16] = (byte)cf.Boxes.Value("tbSW10");
            cData[17] = (byte)cf.Boxes.Value("tbSW11");
            cData[18] = (byte)cf.Boxes.Value("tbSW12");
            cData[19] = (byte)cf.Boxes.Value("tbSW13");
            cData[20] = (byte)cf.Boxes.Value("tbSW14");
            cData[21] = (byte)cf.Boxes.Value("tbSW15");
            cData[22] = (byte)cf.Boxes.Value("tbSW16");

            cData[23] = (byte)cf.Boxes.Value("tbWorkSwitch");

            cData[24] = cf.mf.Tls.CRC(cData, 23);

            switch (cf.mf.ConnectionType)
            {
                case 0:
                    // send ethernet
                    cf.mf.UDPmodules.SendUDPMessage(cData);
                    Result = true;
                    break;

                case 1:
                    // send serial
                    try
                    {
                        Result = cf.mf.CommPort.Send(cData);
                    }
                    catch (Exception ex)
                    {
                        cf.mf.Tls.WriteErrorLog("PGN32300/send serial: " + ex.Message);
                    }
                    break;
            }

            return Result;
        }
    }
}
