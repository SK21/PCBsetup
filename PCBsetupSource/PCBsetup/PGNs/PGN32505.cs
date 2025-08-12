using PCBsetup.Forms;
using System;

namespace PCBsetup
{
    public class PGN32505
    {
        // PGN32505
        // 0	HeaderLo	249
        // 1	HeaderHi	126
        // 2	InoID Lo
        // 3	InoID Hi
        // 4	IMU heading Lo
        // 5	IMU heading Hi
        // 6	WAS reading Lo
        // 7	WAS reading Hi
        // 8	Analog reading Lo
        // 9	Analog reading Hi
        // 10	Status
        //			- bit 0, IMU enabled
        //			- bit 1, Receiver enabled
        //			- bit 2, Pass Thru enabled
        //			- bit 3, ADS1115 found
        //			- bit 4, AOG connected
        //			- bit 5, Steering On
        //			- bit 6, Steer switch On
        // 11   MaxLoopTime Lo
        // 12   MaxLoopTime Hi
        // 13	-
        // 14	CRC

        private const byte cByteCount = 15;
        private const byte HeaderHi = 126;
        private const byte HeaderLo = 249;
        private bool cADS1115found;
        private UInt16 cAnalogReading;
        private bool cAOGconnected;
        private bool cIMUenabled;
        private double cIMUheading;
        private UInt16 cInoID;
        private UInt16 cMaxLoopTime;
        private bool cPassThruEnabled;
        private bool cReceiverEnabled;
        private bool cSteeringOn;
        private bool cSteerSwitchOn;
        private UInt16 cWASreading;
        private frmMain mf;

        public PGN32505(frmMain Main)
        {
            this.mf = Main;
        }

        public event EventHandler NewData;

        public bool ADS1115Found
        { get { return cADS1115found; } }

        public int AnalogReading
        { get { return cAnalogReading; } }

        public bool AOGconnected
        { get { return cAOGconnected; } }

        public string FirmwareVersion
        { get { return ParseDate(cInoID.ToString()); } }

        public bool IMUenabled
        { get { return cIMUenabled; } }

        public double IMUheading
        { get { return cIMUheading; } }

        public int MaxLoopTime
        { get { return cMaxLoopTime; } }

        public bool PassThruEnabled
        { get { return cPassThruEnabled; } }

        public bool ReceiverEnabled
        { get { return cReceiverEnabled; } }

        public bool SteeringOn
        { get { return cSteeringOn; } }

        public bool SteerSwitchOn
        { get { return cSteerSwitchOn; } }

        public int WASreading
        { get { return cWASreading; } }

        public bool ParseByteData(byte[] data)
        {
            bool Result = false;
            if (data[1] == HeaderHi && data[0] == HeaderLo && data.Length >= cByteCount && mf.Tls.GoodCRC(data))
            {
                cInoID = (ushort)(data[2] | data[3] << 8);
                cIMUheading = (double)(data[4] | data[5] << 8) / 10.0;
                cWASreading = (ushort)(data[6] | data[7] << 8);
                cAnalogReading = (ushort)(data[8] | data[9] << 8);

                byte status = data[10];
                cIMUenabled = (status & 0b_0000_0001) != 0;
                cReceiverEnabled = (status & 0b_0000_0010) != 0;
                cPassThruEnabled = (status & 0b_0000_0100) != 0;
                cADS1115found = (status & 0b_0000_1000) != 0;
                cAOGconnected = (status & 0b_0001_0000) != 0;
                cSteeringOn = (status & 0b_0010_0000) != 0;
                cSteerSwitchOn = (status & 0b_0100_0000) != 0;

                cMaxLoopTime = (ushort)(data[11] | data[12] << 8);

                Result = true;
                NewData?.Invoke(this, EventArgs.Empty);
            }
            return Result;
        }

        private string ParseDate(string input)
        {
            // input = ddmmy, no leading 0
            // output = v2025.7.1, year, month, day
            string Result = "";
            if (input.Length > 3)
            {
                int YR = int.Parse(input.Substring(input.Length - 1)) + 2020;
                int MN = int.Parse(input.Substring(input.Length - 3, 2));
                int DY = int.Parse(input.Substring(0, input.Length - 3));

                if (DY > 0 && DY < 32 && MN > 0 && MN < 13)
                {
                    Result = "v" + YR.ToString() + "." + MN.ToString() + "." + DY.ToString();
                }
            }
            return Result;
        }
    }
}