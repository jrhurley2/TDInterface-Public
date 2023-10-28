using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Tda.Model
{
    public class Transaction
    {
        public string type { get; set; }
        public string clearingReferenceNumber { get; set; }
        public string subAccount { get; set; }
        public string settlementDate { get; set; }
        public string orderId { get; set; }
        public int sma { get; set; }
        public int requirementReallocationAmount { get; set; }
        public int dayTradeBuyingPowerEffect { get; set; }
        public int netAmount { get; set; }
        public string transactionDate { get; set; }
        public string orderDate { get; set; }
        public string transactionSubType { get; set; }
        public int transactionId { get; set; }
        public bool cashBalanceEffectFlag { get; set; }
        public string description { get; set; }
        public string achStatus { get; set; }
        public int accruedInterest { get; set; }
        public string fees { get; set; }
        public Transactionitem transactionItem { get; set; }
    }

    public class Transactionitem
    {
        public int accountId { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public int cost { get; set; }
        public int parentOrderKey { get; set; }
        public string parentChildIndicator { get; set; }
        public string instruction { get; set; }
        public string positionEffect { get; set; }
        public Instrument instrument { get; set; }
    }

    //public class Instrument
    //{
    //    public string symbol { get; set; }
    //    public string underlyingSymbol { get; set; }
    //    public string optionExpirationDate { get; set; }
    //    public int optionStrikePrice { get; set; }
    //    public string putCall { get; set; }
    //    public string cusip { get; set; }
    //    public string description { get; set; }
    //    public string assetType { get; set; }
    //    public string bondMaturityDate { get; set; }
    //    public int bondInterestRate { get; set; }
    //}
}

