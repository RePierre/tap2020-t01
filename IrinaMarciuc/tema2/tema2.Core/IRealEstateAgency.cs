using System;
using Uaic.tema2.Core.Assets.Base;
using Uaic.tema2.Core.Calculators;

namespace Uaic.tema2.Core
{
    public interface IRealEstateAgency
    {
        void CalculatePricefor(Asset asset, decimal price, string location, CommissionCalculator commissionCalculator);
    }
}