namespace UAIC.RealEstateAgency.Calculators
{
    public class HouseFeeCalculator : EstateFeeCalculator
    {
        public override decimal GetEstateCommission(decimal base_price)
        {
            return base_price * 0.1m;
        }
    }












}
