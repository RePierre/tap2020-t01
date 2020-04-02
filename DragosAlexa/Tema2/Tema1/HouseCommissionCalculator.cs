using System;

namespace Tema2
{
    class HouseCommissionCalculator : CommissionCalculator
    {
        public override decimal CalculateCommission(RealEstateAgency rea, decimal price)
        {
            if (rea.floors < 1 || rea.floors > 3)
                throw new Exception("No houses with " + rea.floors + " floor/floors. Please verifiy that dates are correct!");
            else if (rea.floors > 0 || rea.floors < 2)
            {
                if (rea.yearBuilt < 1990)
                {
                    if (rea.surface < 50 || rea.surface > 350)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (rea.surface <= 350)
                        return price*0.01m;
                }
                else
                {
                    if (rea.surface < 50 || rea.surface > 350)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (rea.surface <= 350)
                        return price*0.015m;
                }
            }
            else if (rea.floors >= 2 || rea.floors <= 3)
            {
                if (rea.yearBuilt < 1990)
                {
                    if (rea.surface < 50 || rea.surface > 350)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (rea.surface <= 350)
                        return price*0.015m;
                }
                else
                {
                    if (rea.surface < 50 || rea.surface > 350)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (rea.surface <= 350)
                        return price*0.025m;
                }
            }

            throw new InvalidOperationException("Please verify the number of floors!");
        }
    }
}




