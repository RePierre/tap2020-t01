namespace Uaic.Estate.Core.Calculators
{
   public class LandAgentCommission : AgentCommisionCalculator
    {
        protected override decimal CalculateCommission(decimal amount)
        {
            return amount*.25m;
        }
    }
}

