using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Tda.Model
{
    public class StreamerInfo
    {
        public string streamerBinaryUrl { get; set; }
        public string streamerSocketUrl { get; set; }
        public string token { get; set; }
        public string tokenTimestamp { get; set; }
        public string userGroup { get; set; }
        public string accessLevel { get; set; }
        public string acl { get; set; }
        public string appId { get; set; }
    }
}
