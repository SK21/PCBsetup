﻿using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBsetup
{
    public class PGN32700
    {
        //PGN32700, module config from RC to modules
        //0     HeaderLo    188
        //1     HeaderHi    127
        //2     Module ID   0-15
        //3	    sensor count
        //4     commands
        //      bit 0 - Relay on high
        //      bit 1 - Flow on high
        //5	    relay control type 0-5
        //6	    wifi module serial port
        //7	    Sensor 0, Flow pin
        //8     Sensor 0, Dir pin
        //9     Sensor 0, PWM pin
        //10    Sensor 1, Flow pin
        //11    Sensor 1, Dir pin
        //12    Sensor 1, PWM pin
        //13    Relay pins 0-15, bytes 13-28
        //29    -
        //30    CRC

        private const byte cByteCount = 31;
        private const byte HeaderHi = 127;
        private const byte HeaderLo = 188;
        private byte[] cData = new byte[cByteCount];
        private bool cRecordsFound;
        private frmMain mf;

        public PGN32700(frmMain Main)
        {
            mf = Main;
            Load();
        }

        public bool FlowOnHigh
        {
            set
            {
                if (value)
                {
                    cData[4] = (byte)(cData[4] | 2);
                }
                else
                {
                    cData[4] = (byte)(cData[4] & 0x11111101);
                }
            }
        }

        public byte ModuleID
        { set { cData[2] = value; } }

        public bool RecordsFound
        { get { return cRecordsFound; } }

        public bool RelayOnHigh
        {
            set
            {
                if (value)
                {
                    cData[4] = (byte)(cData[4] | 1);
                }
                else
                {
                    cData[4] = (byte)(cData[4] & 0x11111110);
                }
            }
        }

        public byte RelayType
        { set { cData[5] = value; } }

        public byte Sensor0Dir
        { set { cData[8] = value; } }

        public byte Sensor0Flow
        { set { cData[7] = value; } }

        public byte Sensor0PWM
        { set { cData[9] = value; } }

        public byte Sensor1Dir
        { set { cData[11] = value; } }

        public byte Sensor1Flow
        { set { cData[10] = value; } }

        public byte Sensor1PWM
        { set { cData[12] = value; } }

        public byte SensorCount
        { set { cData[3] = value; } }

        public byte WifiPort
        { set { cData[6] = value; } }

        public byte[] GetData()
        {
            return cData;
        }

        public void Load()
        {
            String Name;
            Array.Clear(cData, 0, cByteCount);
            cData[0] = HeaderLo;
            cData[1] = HeaderHi;
            cRecordsFound = false;

            for (int i = 2; i < cByteCount; i++)
            {
                Name = "ModuleConfig_" + i.ToString();
                if (byte.TryParse(mf.Tls.LoadProperty(Name), out byte Val))
                {
                    cData[i] = Val;
                    cRecordsFound = true;
                }
            }
        }

        public void RelayPins(byte[] RelayPin)
        {
            for (int i = 0; i < 16; i++)
            {
                cData[i + 13] = RelayPin[i];
            }
        }

        public void Save()
        {
            String Name;
            for (int i = 2; i < cByteCount; i++)
            {
                Name = "ModuleConfig_" + i.ToString();
                mf.Tls.SaveProperty(Name, cData[i].ToString());
            }
            cRecordsFound = true;
        }

        public void Send()
        {
            // CRC
            cData[cByteCount - 1] = mf.Tls.CRC(cData, cByteCount - 1);

            // send
            mf.CommPort.Send(cData);
            mf.UDPmodulesConfig.SendUDPMessage(cData);
        }
    }
}