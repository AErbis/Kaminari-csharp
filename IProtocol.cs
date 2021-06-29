﻿using System.Collections;
using System.Collections.Generic;


namespace Kaminari
{
	public interface IProtocol<PQ> where PQ : IProtocolQueues
	{
		ushort getLastServerID();
		ushort getExpectedBlockId();
		ushort getLastReadID();
		ServerPhaseSync getPhaseSync();
		int getServerTimeDiff();
		byte getLoopCounter();
		float getEstimatedRTT();
		ushort getLastSentSuperPacketSize(SuperPacket<PQ> superpacket);
		ushort getLastRecvSuperPacketSize(IBaseClient client);
		void setBufferSize(ushort size);
		void InitiateHandshake(SuperPacket<PQ> superpacket);
		void clientHasNewPacket(IBaseClient client, SuperPacket<PQ> superpacket);
		bool read(IBaseClient client, SuperPacket<PQ> superpacket, IHandlePacket handler);
		Buffer update(IBaseClient client, SuperPacket<PQ> superpacket);
	}
}
