namespace Uaic.Estate.Core.Calculators
{
   public class StudioApartmentAgentCommission : AgentCommisionCalculator
    {
        protected override decimal CalculateCommission(decimal amount)
        {
            return  amount* .18m;
        }
    }
}

