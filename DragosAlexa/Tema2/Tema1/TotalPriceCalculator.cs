namespace Tema2
{
    abstract class TotalPriceCalculator : ITotalPriceCalculator
    {
        public abstract decimal CalculateTotalPrice(RealEstateAgency rea, decimal price);
    }

}



