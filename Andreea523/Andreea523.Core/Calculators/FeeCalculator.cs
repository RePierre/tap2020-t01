using System;
using System.Collections.Generic;
using System.Text;

namespace Uaic.Andreea523.Core.Calculators
{
    public abstract class FeeCalculator : IFeeCalculator
    {
        // protected abstract decimal CalculationCommissionn(decimal price, string zone);

        public decimal CalculTotal(decimal price, string zone)
        {
            return price + CalculateCommissionn(price, zone);
        }

        protected abstract decimal CalculateCommissionn(decimal price, string zone);

        public decimal returnCommissionn(decimal price, string zone)
        {
            return CalculateCommissionn(price, zone);
        }
    }
}
