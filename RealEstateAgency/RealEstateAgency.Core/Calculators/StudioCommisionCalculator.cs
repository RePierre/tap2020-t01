namespace Uaic.RealEstateAgency.Core.Calculators
{
    public class StudioCommisionCalculator : CommisionCalculator
    {
        public override decimal AgentCommisionCalculator(decimal initialPrice)
        {
            return 0.05m * initialPrice;
        }
    }
}
