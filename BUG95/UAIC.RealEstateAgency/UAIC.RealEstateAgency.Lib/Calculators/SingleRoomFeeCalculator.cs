namespace UAIC.RealEstateAgency.Calculators
{
    public class SingleRoomFeeCalculator : EstateFeeCalculator
    {
        public override decimal GetEstateCommission(decimal base_price)
        {
            return base_price * 0.3m;
        }
    }
}
