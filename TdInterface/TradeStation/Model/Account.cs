using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TdInterface.TradeStation.Model
{

    public class Rootobject
    {
        public Account[] Accounts { get; set; }
    }

    public class Account
    {
        public static List<Account> ParseJson(string json)
        {
            return JsonConvert.DeserializeObject<Rootobject>(json).Accounts.ToList<Account>();
        }

        public string AccountID { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string AccountType { get; set; }
        public Accountdetail AccountDetail { get; set; }
    }

    public class Accountdetail
    {
        public bool IsStockLocateEligible { get; set; }
        public bool EnrolledInRegTProgram { get; set; }
        public bool RequiresBuyingPowerWarning { get; set; }
        public bool CryptoEnabled { get; set; }
        public bool DayTradingQualified { get; set; }
        public int OptionApprovalLevel { get; set; }
        public bool PatternDayTrader { get; set; }
    }


}
