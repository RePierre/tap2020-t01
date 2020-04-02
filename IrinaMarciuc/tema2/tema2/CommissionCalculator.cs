using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    public abstract class CommissionCalculator : ICommissionCalculator
    {
        public decimal CalculateCommission(Asset asset, decimal price)
        {
            var commission = GetCommission();
            return price + price * commission / 100;
        }
        public abstract decimal GetCommission();
    }
}
