using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface.Model
{
    public  class SocketData
    {
        public string service { get; set; }
        public Int64 timestamp { get; set; }
        public string command { get; set; }
        public List<Dictionary<string,string>> content { get; set; }
    }
}
