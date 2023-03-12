using System.Threading.Tasks;
using TdInterface.Model;
using TdInterface.Tda.Model;

namespace TdInterface.Interfaces
{
    public interface IHelper
    {
        public Securitiesaccount Securitiesaccount
        {
            get;
            set;
        }

        public Task<AccessTokenContainer> RefreshAccessToken(AccessTokenContainer accessTokenContainer);
        public Task<ulong> PlaceOrder(AccessTokenContainer accessTokenContainer, string accountId, Order order);
        public Task<Securitiesaccount> GetAccount(AccessTokenContainer accessTokenContainer, string accountId);
        public Task<ulong> ReplaceOrder(AccessTokenContainer accessTokenContainer, string accountId, string orderId, Order newOrder);
        public Task CancelOrder(AccessTokenContainer accessTokenContainer, string accountId, Order order);
        public Order GetInitialLimitOrder(Securitiesaccount securitiesaccount, Order triggerOrder);
        public Model.StockQuote SetStockQuote(Model.StockQuote stockQuote);
        public Model.StockQuote GetStockQuote(string symbol);
        public Task CancelAll(AccessTokenContainer accessTokenContainer, string accountId, string symbol);
    }

}
