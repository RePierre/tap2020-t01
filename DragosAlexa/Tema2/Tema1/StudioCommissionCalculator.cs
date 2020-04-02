using System;

namespace Tema2
{
    class StudioCommissionCalculator : CommissionCalculator {
        public override decimal CalculateCommission(RealEstateAgency rea, decimal price)
        {
            if (rea.yearBuilt < 1990)
            {
                if (rea.surface < 15 || rea.surface > 30)
                    throw new Exception("No studios with this surface! Please introduce a valid value for surface(15-30 square meters).");
                else if (rea.surface <= 30)
                    return price*0.008m;
            }
            else
            {
                if (rea.surface < 15 || rea.surface > 30)
                    throw new Exception("No studios with this surface! Please introduce a valid value for surface(15-30 square meters).");
                else if (rea.surface <= 30)
                    return price*0.012m;
            }
            throw new InvalidOperationException("Please verify year of construction of the studio!");
        }
    }
}




