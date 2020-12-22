﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketWithId
{
	public Packet packet;
	public ulong id;

	public PacketWithId(Packet packet, ulong id)
	{
		this.packet = packet;
		this.id = id;
	}
}
