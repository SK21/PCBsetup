using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PCBsetup
{
    public class PGN32302
    {
        //		Diagnostics request
        //0		Header lo	46
        //1		Header hi	126
        //2		Command
        //			- bit 0, send diagnostics
        //3		-
        //4		CRC

        private byte[] cdata = new byte[5];
        private frmMain mf;

        public PGN32302(frmMain Main)
        {
            mf = Main;
            cdata[0] = 46;
            cdata[1] = 126;
        }

        public void Send()
        {
            cdata[2] = 1;
            cdata[3] = 0;
            cdata[4] = mf.Tls.CRC(cdata, 4);
            mf.UDPmodules.SendUDPMessage(cdata);
        }
    }
}
