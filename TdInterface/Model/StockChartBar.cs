using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Model
{
    public class StockChartBar
    {

        public string symbol { get; set; }
        public double OpenPrice { get; set; }
        public double HighPrice { get; set; }
        public double LowPrice { get; set; }
        public double ClosePrice { get; set; }
        public double Volume { get; set; }
        public long Sequence { get; set; }
        public long ChartTime { get; set; } //Milliseconds since Epoch.
        public int ChartDay { get; set; }  //Not Useful

        //public const string FIELD_CHART_SEQUENCE = "seq";
        public const string FIELD_CHART_SYMBOL = "key";
        public const string FIELD_CHART_OPEN_PRICE = "1";
        public const string FIELD_CHART_HIGH_PRICE = "2";
        public const string FIELD_CHART_LOW_PRICE = "3";
        public const string FIELD_CHART_CLOSE_PRICE = "4";
        public const string FIELD_CHART_VOLUME = "5";
        public const string FIELD_CHART_SEQUENCE = "6";
        public const string FIELD_CHART_TIME = "7";
        public const string FIELD_CHART_DAY = "8";


        public StockChartBar() { }

        public StockChartBar(Dictionary<String,string> keyValuePairs)
        {
            foreach(var key in keyValuePairs.Keys)
            {
                if(key.Equals(FIELD_CHART_SYMBOL))
                {
                    symbol = keyValuePairs[key];    
                }
                else if(key.Equals(FIELD_CHART_OPEN_PRICE))
                {
                    OpenPrice = double.Parse(keyValuePairs[key]);
                }
                else if(key.Equals(FIELD_CHART_HIGH_PRICE))
                {
                    HighPrice = double.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_CHART_LOW_PRICE))
                {
                    LowPrice = double.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_CHART_CLOSE_PRICE))
                {
                    ClosePrice = double.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_CHART_VOLUME))
                {
                    Volume = double.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_CHART_SEQUENCE))
                {
                    Sequence = int.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_CHART_TIME))
                {
                    ChartTime =  long.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_CHART_DAY))
                {
                    ChartDay= int.Parse(keyValuePairs[key]);
                }
            }
        }
    }
}
