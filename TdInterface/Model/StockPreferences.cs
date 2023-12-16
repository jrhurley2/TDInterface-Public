using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Model
{
    public class StockPreference
    {
        public string Stock { get; set; }
        public double? LimitOffset { get; set; }
        public double? MinimumRisk { get; set; }
    }
}
