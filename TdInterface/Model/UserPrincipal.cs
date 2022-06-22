using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Model
{
    public class UserPrincipal
    {
        public string userId { get; set; }
        public string userCdDomainId { get; set; }
        public string primaryAccountId { get; set; }
        public DateTime lastLoginTime { get; set; }
        public DateTime tokenExpirationTime { get; set; }
        public DateTime loginTime { get; set; }
        public string accessLevel { get; set; }
        public bool stalePassword { get; set; }
        public StreamerInfo streamerInfo { get; set; }
        public UserPrincipalAccount[] accounts { get; set; }
        public SubscriptionKeys streamerSubscriptionKeys { get; set; }
    }
}
