using Uaic.Tema2.Core.Assets;
namespace Uaic.Tema2.Core.Calculators
{
    public class StudioTotalPriceCalculator : TotalPriceCalculator
    {
        public override decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var studioCommisionCalculator = new StudioCommissionCalculator();
            return price + studioCommisionCalculator.CalculateCommission(rea, price);
        }
    }
}



