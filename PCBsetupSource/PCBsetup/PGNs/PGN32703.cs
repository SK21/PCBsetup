using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32703
    {
        // PGN32703, firmware update mode for Teensy 4.1
        //0		headerLo		191
        //1		headerHi		127
        //2		Module ID
        //3		Module Type		0-4
        //4     Command
        //          - overwrite module type
        //5		CRC

        private byte[] cData = new byte[6];
        private frmMain mf;

        public PGN32703(frmMain CalledFrom)
        {
            mf = CalledFrom;
            cData[0] = 191;
            cData[1] = 127;
        }

        public bool Send(byte ModuleID, byte ModuleType, bool Overwrite = false)
        {
            bool Result = false;
            cData[2] = ModuleID;
            cData[3] = ModuleType;
            if (Overwrite)
            {
                cData[4] = 1;
            }
            else
            {
                cData[4] = 0;
            }
            cData[5] = mf.Tls.CRC(cData, 5);
            Result = mf.Tls.UDP_BroadcastPGN(cData);
            return Result;
        }
    }
}