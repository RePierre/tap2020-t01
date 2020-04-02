using Uaic.Tema2.Core.Assets;
namespace Uaic.Tema2.Core.Calculators
{
    public class LandTotalPriceCalculator : TotalPriceCalculator
    {
        public override decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var landCommisionCalculator = new LandCommissionCalculator();
            return price + landCommisionCalculator.CalculateCommission(rea, price);
        }
    }
}



