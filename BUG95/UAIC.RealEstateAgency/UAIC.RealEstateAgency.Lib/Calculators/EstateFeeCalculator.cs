namespace UAIC.RealEstateAgency.Calculators
{
    public abstract class EstateFeeCalculator : IEstateFeeCalculator
    {
        public decimal CalculateEstatePrice(decimal base_price)
        {
            return base_price + GetEstateCommission(base_price);
        }
        public abstract decimal GetEstateCommission(decimal base_price);
    }
}
