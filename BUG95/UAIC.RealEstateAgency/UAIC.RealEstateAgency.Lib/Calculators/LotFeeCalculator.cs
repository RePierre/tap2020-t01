namespace UAIC.RealEstateAgency.Calculators
{
    public class LotFeeCalculator : EstateFeeCalculator
    {
        public override decimal GetEstateCommission(decimal base_price)
        {
            return base_price * 0.5m;
        }
    }












}
