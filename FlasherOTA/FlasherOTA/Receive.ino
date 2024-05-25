
uint8_t ReceivedData[500];
void ReceiveUDPwired()
{
	if (Ethernet.linkStatus() == LinkON)
	{
		PacketLength = UDPcomm.parsePacket();
		if (PacketLength>0)
		{
			if (PacketLength > 500) PacketLength = 500;
			UDPcomm.read(ReceivedData, PacketLength);
			if (UpdateMode)
			{
				
				if (process_hex_record(ReceivedData, PacketLength))
				{
					// return error or user abort, so clean up and
					// reboot to ensure that static vars get boot-up initialized before retry
					Serial.println();
					Serial.println("Update error.");
					Serial.printf("erase FLASH buffer / free RAM buffer...\n");
					delay(5000);
					firmware_buffer_free(buffer_addr, buffer_size);
					REBOOT;
				}
			}
			else
			{
				ReadPGNs(ReceivedData, PacketLength);
			}
		}
	}
}

void ReadPGNs(byte Data[], uint16_t len)
{
	byte PGNlength;
	uint16_t PGN = Data[1] << 8 | Data[0];

	switch (PGN)
	{
	case 32703:
		// PGN32703, firmware update mode for Teensy 4.1
		//0		headerLo		191
		//1		headerHi		127
		//2		Module ID		
		//3		Module Type		0-4
		//4		Command
		//			- overwrite module type
		//5		CRC
		PGNlength = 6;
		if (len > PGNlength - 1)
		{
			if (GoodCRC(Data, PGNlength))
			{
				if (ParseModID(Data[2]) == ModuleID)
				{
					if ((Data[4] == 1) || (Data[3] == ModuleType))
					{
						if (firmware_buffer_init(&buffer_addr, &buffer_size))
						{
							Serial.printf("target = %s (%dK flash in %dK sectors)\n", FLASH_ID, FLASH_SIZE / 1024, FLASH_SECTOR_SIZE / 1024);
							Serial.printf("buffer = %1luK %s (%08lX - %08lX)\n", buffer_size / 1024, IN_FLASH(buffer_addr) ? "FLASH" : "RAM", buffer_addr, buffer_addr + buffer_size);
							Serial.println("waiting for hex lines...\n");
							UpdateMode = true;
						}
						else
						{
							Serial.println("Unable to create update buffer.");
						}
					}
				}
			}
		}
		break;

	default:
		break;
	}
}

