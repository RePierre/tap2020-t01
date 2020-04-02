using Uaic.Tema2.Core.Assets;
namespace Uaic.Tema2.Core.Calculators
{
    public class HouseTotalPriceCalculator : TotalPriceCalculator
    {
        public override decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var houseCommisionCalculator = new HouseCommissionCalculator();
            return price + houseCommisionCalculator.CalculateCommission(rea, price);
        }
    }
}



