namespace Tema2
{
    class StudioTotalPriceCalculator : TotalPriceCalculator
    {
        public override decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var studioCommisionCalculator = new StudioCommissionCalculator();
            return price + studioCommisionCalculator.CalculateCommission(rea, price);
        }
    }
}



