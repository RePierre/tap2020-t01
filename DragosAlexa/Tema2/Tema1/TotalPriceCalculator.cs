namespace Tema2
{
    class TotalPriceCalculator
    {   
        public decimal CalculateTotalPrice(RealEstateAgency rea, decimal price)
        {
            var commissionCalculator = new CommissionCalculator();
            return price + price * commissionCalculator.GetCommission(rea);
        }
    }

}



