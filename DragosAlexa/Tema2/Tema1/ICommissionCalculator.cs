namespace Tema2
{
    interface ICommissionCalculator
    {
        decimal CalculateCommission(RealEstateAgency rea, decimal price);
    }
}