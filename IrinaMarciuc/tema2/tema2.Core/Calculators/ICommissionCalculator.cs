
using Uaic.tema2.Core.Assets.Base;
namespace Uaic.tema2.Core.Calculators
{
    public interface ICommissionCalculator
    {
        decimal CalculateCommission(Asset asset, decimal price);
        decimal GetCommission();
    }
}