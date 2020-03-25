namespace UAIC.RealEstateAgency.Calculators
{
    public interface IEstateFeeCalculator
    {
        decimal CalculateEstatePrice(decimal base_price);
        decimal GetEstateCommission(decimal base_price);
    }












}
