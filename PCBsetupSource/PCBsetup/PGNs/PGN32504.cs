using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32504
    {
        // PGN32504, commands
        // 0	HeaderLo	248
        // 1	HeaderHi	126
        // 2	Command
        //          - bit 0, request status
        // 3	CRC

        private byte[] cData = new byte[4];
        private frmMain mf;

        public PGN32504(frmMain main)
        {
            mf = main;
            cData[0] = 248;
            cData[1] = 126;
            cData[2] = 1;
        }

        public void Send()
        {
            cData[3] = mf.Tls.CRC(cData, 3);
            mf.UDPmodules.SendUDPMessage(cData);
        }
    }
}