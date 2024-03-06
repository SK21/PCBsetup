using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32503
    {
        //PGN32503, Subnet change
        //0     HeaderLo    247
        //1     HeaderHI    126
        //2     IP 0
        //3     IP 1
        //4     IP 2
        //5     CRC

        private byte[] cData = new byte[6];
        private frmMain mf;

        public PGN32503(frmMain Main)
        {
            mf = Main;
            cData[0] = 247;
            cData[1] = 126;
        }

        public bool Send(string EP)
        {
            string[] data = EP.Split('.');
            cData[2] = byte.Parse(data[0]);
            cData[3] = byte.Parse(data[1]);
            cData[4] = byte.Parse(data[2]);

            // CRC
            cData[5] = mf.Tls.CRC(cData, 5);

            return mf.Tls.UDP_BroadcastPGN(cData);
        }
    }
}
