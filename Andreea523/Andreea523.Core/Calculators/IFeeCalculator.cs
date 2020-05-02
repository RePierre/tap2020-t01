namespace Uaic.Andreea523.Core.Calculators
{
    public interface IFeeCalculator
    {
        decimal CalculTotal(decimal price, string zone);
        decimal returnCommissionn(decimal price, string zone);
    }
}