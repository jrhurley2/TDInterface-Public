using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Tda.Model
{
    public class UserPrincipalAccount
    {
        public string accountId { get; set; }
        public string displayName { get; set; }
        public string accountCdDomainId { get; set; }
        public string company { get; set; }
        public string segment { get; set; }
        public string acl { get; set; }

        public Dictionary<string, object> authorizations { get; set; }
    }
}
