using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        public Task ReplaceOrder(AccessTokenContainer accessTokenContainer, string accountId, string orderId, Order newOrder);
        public Task CancelOrder(AccessTokenContainer accessTokenContainer, string accountId, Order order);
        public Order GetInitialLimitOrder(Securitiesaccount securitiesaccount, Order triggerOrder);
    }
}
