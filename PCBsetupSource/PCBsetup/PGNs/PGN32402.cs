using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32402
    {
        //      Info request from PCBsetup
        //0     HeaderLo    146
        //1     HeaderHi    126
        //2     Info ID     0 IP address
        //3     CRC

        private byte[] cData = new byte[4];
        private frmNetwork cf;

        public PGN32402(frmNetwork CalledFrom)
        {
            cf = CalledFrom;
            cData[0] = 146;
            cData[1] = 126;
        }

        public bool Send(byte InfoID)
        {
            cData[2] = InfoID;
            cData[3] = cf.mf.Tls.CRC(cData, 3);

            bool Result = cf.mf.UDPmodulesConfig.SendUDPMessage(cData);

            return Result;
        }
    }
}
