namespace UAIC.RealEstateAgency.Calculators
{
    public class ApartmentFeeCalculator : EstateFeeCalculator
    {
        public override decimal GetEstateCommission(decimal base_price)
        {
            return base_price * 0.2m;
        }
    }
}
