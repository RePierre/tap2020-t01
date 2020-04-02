namespace Uaic.Estate.Core.Calculators
{
    public class ApartmentAgentCommission : AgentCommisionCalculator
    {
        protected override decimal CalculateCommission(decimal amount)
        {
            return amount *.15m;
        }
    }
}

