using Uaic.Tema2.Core.Assets;
namespace Uaic.Tema2.Core.Calculators
{
    public interface ICommissionCalculator
    {
        decimal CalculateCommission(RealEstateAgency rea, decimal price);
    }
}