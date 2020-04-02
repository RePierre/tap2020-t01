using System;
using Uaic.Tema2.Core.Assets;
namespace Uaic.Tema2.Core.Calculators
{
    public abstract class CommissionCalculator : ICommissionCalculator
    {
        public abstract decimal CalculateCommission(RealEstateAgency rea, decimal price);

    }
}




