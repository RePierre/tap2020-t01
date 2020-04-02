using Uaic.Tema2.Core.Assets;
namespace Uaic.Tema2.Core.Calculators
{
   public abstract class TotalPriceCalculator : ITotalPriceCalculator
    {
        public abstract decimal CalculateTotalPrice(RealEstateAgency rea, decimal price);
    }

}



