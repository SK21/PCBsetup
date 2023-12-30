using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32303
    {
        //      Info request from PCBsetup
        //0     HeaderLo    47
        //1     HeaderHi    126
        //2     CRC

        private byte[] cData = new byte[3];
        private frmNetwork cf;

        public PGN32303(frmNetwork CalledFrom)
        {
            cf = CalledFrom;
            cData[0] = 47;
            cData[1] = 126;
        }

        public bool Send()
        {
            cData[2] = cf.mf.Tls.CRC(cData, 2);
            bool Result = cf.mf.UDPmodulesConfig.SendUDPMessage(cData);
            return Result;
        }
    }
}
