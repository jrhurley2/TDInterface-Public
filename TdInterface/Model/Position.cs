using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Model
{
    public class Position
    {
        public float shortQuantity { get; set; }
        public float averagePrice { get; set; }
        public float currentDayCost { get; set; }
        public float currentDayProfitLoss { get; set; }
        public float currentDayProfitLossPercentage { get; set; }
        public float longQuantity { get; set; }
        public float settledLongQuantity { get; set; }
        public float settledShortQuantity { get; set; }
        public Instrument instrument { get; set; }
        public float marketValue { get; set; }
        public float maintenanceRequirement { get; set; }
        public float previousSessionLongQuantity { get; set; }
        public float agedQuantity { get; set; }
        //public Instrument Instrument { get; set; }

        public string Symbol
        {
            get
            {
                return this.instrument?.symbol;
            }
        }

        public int Quantity => this.longQuantity== 0.0 ? (int)this.shortQuantity : (int)this.longQuantity;

        //public bool IsSame(Position other) => other != null && this.Symbol == other.Symbol && this.LongQuantity == other.LongQuantity && this.ShortQuantity == other.ShortQuantity && this.AveragePrice == other.AveragePrice;
     
    }
}
