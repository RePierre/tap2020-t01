using Uaic.Tema2.Core.Assets;

namespace Uaic.Tema2.Core.Calculators
{
    public class ApartmentTotalPriceCalculator : TotalPriceCalculator
    {
        public override decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var apartmentCommisionCalculator = new ApartmentCommissionCalculator();
            return price + apartmentCommisionCalculator.CalculateCommission(rea, price);
        }
    }
}



