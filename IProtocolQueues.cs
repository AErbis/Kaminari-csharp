﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProtocolQueues
{
    void reset();
    void ack(ushort blockId);
    void process(ushort blockId, ref ushort remaining, SortedDictionary<uint, List<Packet>> byBlock);
}
