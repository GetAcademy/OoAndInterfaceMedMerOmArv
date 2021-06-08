using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoAndInterface
{
    class BuyOrSellEvent : Event
    {
        public decimal AmountPerShare { get; }
        public Stock Stock { get; }
        public int ShareCount { get; }
        public bool IsBuy { get; }

        public BuyOrSellEvent(DateTime date, decimal amountPerShare, Stock stock, int shareCount, bool isBuy)
        : base(date)
        {
            AmountPerShare = amountPerShare;
            Stock = stock;
            ShareCount = shareCount;
            IsBuy = isBuy;
        }

        public override void Process(Inventory inventory)
        {
            var stocks = inventory.Stocks;
            if (IsBuy && !stocks.ContainsKey(Stock)) stocks.Add(Stock, 0);
            var factor = IsBuy ? 1 : -1;
            stocks[Stock] += ShareCount * factor;
        }
    }
}
