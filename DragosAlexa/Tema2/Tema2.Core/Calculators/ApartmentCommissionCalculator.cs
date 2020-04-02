using System;
using Uaic.Tema2.Core.Assets;

namespace Uaic.Tema2.Core.Calculators
{
    public class ApartmentCommissionCalculator : CommissionCalculator
    {
        public override decimal CalculateCommission(RealEstateAgency rea, decimal price)
        {
            if (rea.yearBuilt < 1990)
            {
                if (rea.surface < 30 || rea.surface > 90)
                    throw new Exception("No apartments with this surface! Please introduce a valid value for surface(30-90 square meters).");
                else if (rea.surface <= 60)
                    return price*0.016m;
            }
            else
            {
                if (rea.surface < 30 || rea.surface > 90)
                    throw new Exception("No apartments with this surface! Please introduce a valid value for surface(30-90 square meters).");
                else if (rea.surface <= 60)
                    return price*0.02m;
            }
            throw new InvalidOperationException("Please verify year of construction of the apartment!");
        }
    }
}




