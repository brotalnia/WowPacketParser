using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientServerBuckDataStart
    {
        public uint RequestID;
        public byte Mpid;
        public byte NumVServers;
    }
}