using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TdInterface.Tda.Model;

namespace TdInterface.Interfaces
{
    public interface IHelper
    {
        public Task<ulong> PlaceOrder(AccessTokenContainer accessTokenContainer, string accountId, Order order);
    }
}
