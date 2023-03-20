using System.Threading.Tasks;
using TdInterface.Model;
using TdInterface.Tda.Model;

namespace TdInterface.Interfaces
{
    public interface IHelper
    {
        public AccessTokenContainer AccessTokenContainer { get; set; }

        public Securitiesaccount Securitiesaccount
        {
            get;
            set;
        }

        public Task<AccessTokenContainer> RefreshAccessToken();
        public Task<ulong> PlaceOrder(string accountId, Order order);
        public Task<Securitiesaccount> GetAccount(string accountId);
        public Task<ulong> ReplaceOrder(string accountId, string orderId, Order newOrder);
        public Task CancelOrder(string accountId, Order order);
        public Order GetInitialLimitOrder(Securitiesaccount securitiesaccount, Order triggerOrder);
        public Model.StockQuote SetStockQuote(Model.StockQuote stockQuote);
        public Model.StockQuote GetStockQuote(string symbol);
        public Task CancelAll(string accountId, string symbol);
    }

}
