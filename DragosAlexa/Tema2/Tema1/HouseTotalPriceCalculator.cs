namespace Tema2
{
    class HouseTotalPriceCalculator : TotalPriceCalculator
    {
        public override decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var houseCommisionCalculator = new HouseCommissionCalculator();
            return price + houseCommisionCalculator.CalculateCommission(rea, price);
        }
    }
}



