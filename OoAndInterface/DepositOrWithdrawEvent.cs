using System;
using System.Collections.Generic;

namespace OoAndInterface
{
    class DepositOrWithdrawEvent : Event
    {
        public decimal Amount { get; }
        public bool IsDeposit { get; }

        public DepositOrWithdrawEvent(
            DateTime date,
            decimal amount,
            bool isDeposit) : base(date)
        {
            Amount = amount;
            IsDeposit = isDeposit;
        }

        public override void Process(Inventory inventory)
        {
            var factor = IsDeposit ? 1 : -1;
            inventory.CashAmount += Amount * factor;
        }
    }
}
