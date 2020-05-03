namespace Uaic.RealEstateAgency.Core.Calculators
{
    public class HouseCommisionCalculator : CommisionCalculator
    {
        public override decimal AgentCommisionCalculator(decimal initialPrice)
        {
            return 0.12m * initialPrice;
        }
    }
}
