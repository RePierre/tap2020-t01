namespace Uaic.Estate.Core.Calculators
{
    public class HouseAgentCommission : AgentCommisionCalculator
    {
        protected override decimal CalculateCommission(decimal amount)
        {
            return amount *.12m;
        }
    }
}

