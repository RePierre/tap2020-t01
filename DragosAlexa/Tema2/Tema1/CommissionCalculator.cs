using System;

namespace Tema2
{
    abstract class CommissionCalculator : ICommissionCalculator
    {
        public abstract decimal CalculateCommission(RealEstateAgency rea, decimal price);

    }
}




