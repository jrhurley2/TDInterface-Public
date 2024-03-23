using EZTM.Common.Model;
using EZTM.Common.Tda.Model;

namespace EZTM.Common.Interfaces
{
    public interface IBrokerage
    {
        public void Initialize();
        public AccessTokenContainer AccessTokenContainer { get; set; }

        public IObservable<Securitiesaccount> SecuritiesAccountUpdated { get; }
        public Securitiesaccount Securitiesaccount
        {
            get;
            set;
        }

        public AccountInfo AccountInfo { get; set; }

        public string LoginUri { get; }

        public bool NeedTokenRefreshed { get; }

        public string AccountId { get; }

        public Task<AccessTokenContainer> GetAccessToken(string authToken);
        public Task<AccessTokenContainer> RefreshAccessToken();
        public Task<UserPrincipal> GetUserPrincipals()
        {
            // TODO: Can we merge GetUserPrincipals and GetAccounts in some way?
            return null;
        }
        //public Task<List<TradeStation.Model.Account>> GetAccounts()
        //{
        //    // TODO: Need to change this so it doesn't depend on specific TradeStation model.
        //    // TODO: Can we merge GetUserPrincipals and GetAccounts in some way?
        //    return null;
        //}
        public Task<ulong> PlaceOrder(string accountId, Order order);
        public Task<Securitiesaccount> GetAccount(string accountId);
        public Task<ulong> ReplaceOrder(string accountId, string orderId, Order newOrder);
        public Task CancelOrder(string accountId, Order order);
        public Order GetInitialLimitOrder(Securitiesaccount securitiesaccount, Order triggerOrder);
        public EZTM.Common.Model.StockQuote SetStockQuote(EZTM.Common.Model.StockQuote stockQuote);
        public EZTM.Common.Model.StockQuote GetStockQuote(string symbol);
        public Task CancelAll(string accountId, string symbol);
        public Task<IStreamer> GetStreamer();
    }

}
