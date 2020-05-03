namespace Uaic.RealEstateAgency.Core.Calculators
{
    public class ApartmentCommisionCalculator : CommisionCalculator
    {
        public override decimal AgentCommisionCalculator(decimal initialPrice)
        {
            return 0.1m * initialPrice;
        }
    }
}
