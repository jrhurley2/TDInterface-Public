using System;

namespace EZTM.Forms.UI
{
    public class DailyLossExceededException : Exception
    {
        public DailyLossExceededException(string message) : base(message) { }
    }
}
