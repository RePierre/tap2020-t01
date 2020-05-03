namespace Uaic.Estate.Core.Calculators
{
    public interface IAgentCommisionCalculator
    {
        decimal Commission(decimal amount);
        decimal SellPriceWithAgentCommission(decimal amount);
        decimal SellPriceWithoutCommission(decimal amount);
    }
}