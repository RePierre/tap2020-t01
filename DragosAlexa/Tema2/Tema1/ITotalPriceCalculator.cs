namespace Tema2
{
    interface ITotalPriceCalculator
    {
        decimal CalculateTotalPrice(RealEstateAgency rea, decimal price);
    }
}