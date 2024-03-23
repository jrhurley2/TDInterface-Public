using System;

namespace EZTM.UI
{
    public class DailyLossExceededException : Exception
    {
        public DailyLossExceededException(string message) : base(message) { }
    }
}
