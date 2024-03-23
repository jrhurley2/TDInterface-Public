namespace EZTM.Common.Model
{
    public class StockQuote
    {
        public virtual string symbol { get; set; }
        public virtual double bidPrice { get; set; }
        public virtual double askPrice { get; set; }
        public virtual double lastPrice { get; set; }


        public virtual StockQuote Update(StockQuote stockQuote)
        {
            symbol = stockQuote.symbol;
            bidPrice = stockQuote.bidPrice != 0.0 ? stockQuote.bidPrice : bidPrice;
            askPrice = stockQuote.askPrice != 0.0 ? stockQuote.askPrice : askPrice;
            lastPrice = stockQuote.lastPrice != 0.0 ? stockQuote.lastPrice : lastPrice;
            return this;
        }

    }
}
