using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TdInterface.Model
{
    public class StockQuote : INotifyPropertyChanged
    {
        private double lastPrice;

        public virtual string symbol { get; set; }
        public virtual double bidPrice { get; set; }
        public virtual double askPrice { get; set; }
        public virtual double LastPrice
        {
            get { return lastPrice; }
            set
            {
                lastPrice = value;
                NotifyPropertyChanged();
            }
        }
        public virtual string description { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual StockQuote Update(StockQuote stockQuote)
        {
            symbol = stockQuote.symbol;
            bidPrice = stockQuote.bidPrice != 0.0 ? stockQuote.bidPrice : bidPrice;
            askPrice = stockQuote.askPrice != 0.0 ? stockQuote.askPrice : askPrice;
            LastPrice = stockQuote.LastPrice != 0.0 ? stockQuote.LastPrice : LastPrice;
            description = string.IsNullOrEmpty(stockQuote.description) ? description: stockQuote.description;
            return this;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
