using System;

namespace Uaic.Estate.Core.Calculators
{
    public abstract class AgentCommisionCalculator : IAgentCommisionCalculator
    {
        public decimal SellPriceWithAgentCommission(decimal amount)
        {
            var commision = CalculateCommission(amount);
            return amount + commision;
        }
        public decimal SellPriceWithoutCommission(decimal amount)
        {
            var commision = CalculateCommission(amount);
            return amount;
        }
        public decimal Commission(decimal amount)
        {
            var commision = CalculateCommission(amount);
            return commision;
        }
        protected abstract decimal CalculateCommission(decimal amount);

    }
}

