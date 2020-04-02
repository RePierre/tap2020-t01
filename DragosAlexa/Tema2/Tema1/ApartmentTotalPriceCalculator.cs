namespace Tema2
{
    class ApartmentTotalPriceCalculator : TotalPriceCalculator
    {
        public override decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var apartmentCommisionCalculator = new ApartmentCommissionCalculator();
            return price + apartmentCommisionCalculator.CalculateCommission(rea, price);
        }
    }
}



