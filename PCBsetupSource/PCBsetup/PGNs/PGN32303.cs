using PCBsetup.Forms;
using System;

namespace PCBsetup
{
    public class PGN32303
    {
        //		Diagnostics reply, PGN32303
        //0		Header lo	47
        //1		Header hi	126
        //2		InoID lo
        //3		InoID hi
        //4		byte 1
        //5		byte 2
        //6		byte 3
        //7		byte 4
        //8		byte 5
        //9		byte 6
        //10	WAS lo X 100
        //11	WAS hi
        //12	heading lo X 10
        //13	heading hi
        //14	CRC

        private const byte cByteCount = 15;
        private const byte HeaderHi = 126;
        private const byte HeaderLo = 47;
        private byte[] cDebug = new byte[6];
        private double cHeading;
        private UInt16 cInoID;
        private double cWAS;
        private frmMain mf;

        public PGN32303(frmMain Main)
        {
            mf = Main;
        }

        public event EventHandler NewData;

        public double Heading
        { get { return cHeading; } }

        public UInt16 InoID
        { get { return cInoID; } }

        public double WAS
        { get { return cWAS; } }

        public byte Debug(int ID)
        {
            return cDebug[ID];
        }

        public bool ParseByteData(byte[] data)
        {
            bool Result = false;
            if (data[0] == HeaderLo && data[1] == HeaderHi
                && data.Length >= cByteCount && mf.Tls.GoodCRC(data))
            {
                cInoID = (ushort)(data[2] | data[3] << 8);
                for (int i = 0; i < 6; i++)
                {
                    cDebug[i] = data[4 + i];
                }

                cWAS = (data[10] | data[11] << 8) / 100.0;
                cHeading = (data[12] | data[13] << 8) / 10.0;

                NewData?.Invoke(this, EventArgs.Empty);
            }
            return Result;
        }
    }
}