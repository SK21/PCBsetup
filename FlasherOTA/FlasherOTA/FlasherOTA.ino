#include <Wire.h>
#include <EEPROM.h> 
#include <NativeEthernet.h>
#include <NativeEthernetUdp.h>

#include "FXUtil.h"		// read_ascii_line(), hex file support
extern "C" {
#include "FlashTxx.h"		// TLC/T3x/T4x/TMM flash primitives
}

// ethernet
EthernetUDP UDPcomm;
uint16_t ListeningPort = 28888;
uint16_t DestinationPort = 29999;
IPAddress DestinationIP(192,168,5, 255);

// OTA
uint32_t buffer_addr, buffer_size;
bool UpdateMode = false;
uint8_t ModuleID = 0;
uint8_t ModuleType = 1;

//******************************************************************************
// hex_info_t struct for hex record and hex file info
//******************************************************************************
typedef struct {  //
	char* data;   // pointer to array allocated elsewhere
	unsigned int addr;  // address in intel hex record
	unsigned int code;  // intel hex record type (0=data, etc.)
	unsigned int num; // number of data bytes in intel hex record

	uint32_t base;  // base address to be added to intel hex 16-bit addr
	uint32_t min;   // min address in hex file
	uint32_t max;   // max address in hex file

	int eof;    // set true on intel hex EOF (code = 1)
	int lines;    // number of hex records received
} hex_info_t;

static char data[16];// buffer for hex data

hex_info_t hex =
{ // intel hex info struct
  data, 0, 0, 0,          //   data,addr,num,code
  0, 0xFFFFFFFF, 0,           //   base,min,max,
  0, 0            //   eof,lines
};

uint16_t PacketLength;

void setup()
{
	Serial.begin(115200);

	// ethernet 
	Serial.println("Starting Ethernet ...");
	IPAddress LocalIP(192,168,5,50);
	static uint8_t LocalMac[] = { 0x0A,0x0B,0x42,0x0C,0x0D,50 };

	Ethernet.begin(LocalMac, 0);
	Ethernet.setLocalIP(LocalIP);

	delay(1500);
	if (Ethernet.linkStatus() == LinkON)
	{
		Serial.println("Ethernet Connected.");
	}
	else
	{
		Serial.println("Ethernet Not Connected.");
	}
	Serial.print("IP Address: ");
	Serial.println(Ethernet.localIP());
	DestinationIP = IPAddress(192,168,5, 255);	// update from saved data

    UDPcomm.begin(ListeningPort);

	Serial.println("");
	Serial.println("Test 4");
	Serial.println("Finished Setup");
}

void loop()
{
		ReceiveUDPwired();
}

bool GoodCRC(byte Data[], byte Length)
{
	byte ck = CRC(Data, Length - 1, 0);
	bool Result = (ck == Data[Length - 1]);
	return Result;
}

byte CRC(byte Chk[], byte Length, byte Start)
{
	byte Result = 0;
	int CK = 0;
	for (int i = Start; i < Length; i++)
	{
		CK += Chk[i];
	}
	Result = (byte)CK;
	return Result;
}

byte ParseModID(byte ID)
{
	// top 4 bits
	return ID >> 4;
}
