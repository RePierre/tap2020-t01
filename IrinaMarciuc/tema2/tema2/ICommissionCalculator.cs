namespace tema2
{
    public interface ICommissionCalculator
    {
        decimal CalculateCommission(Asset asset, decimal price);
        decimal GetCommission();
    }
}