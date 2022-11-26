using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface
{
    public class DailyLossExceededException : Exception
    {
        public DailyLossExceededException(string message) : base(message) { }
    }
}
