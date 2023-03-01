using System;

namespace TdInterface
{
    public class DailyLossExceededException : Exception
    {
        public DailyLossExceededException(string message) : base(message) { }
    }
}
