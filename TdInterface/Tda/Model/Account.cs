using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Tda.Model
{
    public class Account
    {
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "isDayTrader")]
        public bool IsDayTrader { get; set; }

        [JsonProperty(PropertyName = "IsClosingOnlyRestricted")]
        public bool IsClosingOnlyRestricted { get; set; }

        //public Position[] Positions { get; set; }

        //public Balance CurrentBalances { get; set; }

        //public Dictionary<string, string> ToDictionary()
        //{
        //    Dictionary<string, string> dictionary = this.CurrentBalances?.ToDictionary() ?? new Dictionary<string, string>(5);
        //    if (!string.IsNullOrEmpty(this.AccountId))
        //        dictionary["ID"] = this.AccountId;
        //    if (!string.IsNullOrEmpty(this.Type))
        //        dictionary["Type"] = this.Type;
        //    if (this.IsDayTrader)
        //        dictionary["Is day trader"] = "Yes";
        //    if (this.IsClosingOnlyRestricted)
        //        dictionary["Closing-only restricted"] = "Yes";
        //    return dictionary;
        //}
    }

}
