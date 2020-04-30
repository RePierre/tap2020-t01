namespace tema2
{
    public interface IRealEstateAgency
    {
        void CalculatePricefor(Asset asset, decimal price, string location, CommissionCalculator commissionCalculator);
    }
}