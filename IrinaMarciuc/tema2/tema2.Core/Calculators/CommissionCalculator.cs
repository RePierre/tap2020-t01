using Uaic.tema2.Core.Assets.Base;

namespace Uaic.tema2.Core.Calculators
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
