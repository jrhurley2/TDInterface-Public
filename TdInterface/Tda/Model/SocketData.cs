using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface.Tda.Model
{
    public class SocketData
    {
        public string service { get; set; }
        public long timestamp { get; set; }
        public string command { get; set; }
        public List<Dictionary<string, string>> content { get; set; }
    }
}
