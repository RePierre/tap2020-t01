using Uaic.Tema2.Core.Assets;
namespace Uaic.Tema2.Core.Calculators
{
    public interface ITotalPriceCalculator
    {
        decimal CalculateTotalPrice(RealEstateAgency rea, decimal price);
    }
}