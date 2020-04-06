namespace Uaic.RealEstateAgency.Core.Calculators
{
    public class LandCommisionCalculator : CommisionCalculator
    {
        public override decimal AgentCommisionCalculator(decimal initialPrice)
        {
            return 0.15m * initialPrice;
        }
    }
}
