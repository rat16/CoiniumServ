﻿/*
 * Coinium project, Copyright (C) 2013, Int6 Studios - All Rights Reserved. - http://www.coinium.org
 *
 */

/* This file is based on https://github.com/BitKoot/BitcoinRpcSharp */

namespace coinium.Net.RPC.Client.Responses
{
    public class PeerInfo
    {
        public string Addr { get; set; }
        public string Services { get; set; }
        public int LastSend { get; set; }
        public int LastRecv { get; set; }
        public int BytesSent { get; set; }
        public int BytesRecv { get; set; }
        public int ConnTime { get; set; }
        public int Version { get; set; }
        public string SubVer { get; set; }
        public bool Inbound { get; set; }
        public int StartingHeight { get; set; }
        public int BanScore { get; set; }
        public bool SyncNode { get; set; }
    }
}
