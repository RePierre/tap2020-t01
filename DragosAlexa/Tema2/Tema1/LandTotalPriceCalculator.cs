namespace Tema2
{
    class LandTotalPriceCalculator : TotalPriceCalculator
    {
        public override decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var landCommisionCalculator = new LandCommissionCalculator();
            return price + landCommisionCalculator.CalculateCommission(rea, price);
        }
    }
}



