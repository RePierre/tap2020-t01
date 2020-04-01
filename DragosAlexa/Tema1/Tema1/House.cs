using System;

namespace Tema1
{
    public class House : RealEstateAgency
    {
        public int floors;
        public House(decimal price, int surface, int yearBuilt,int floors) : base(price, surface, yearBuilt) {
            this.floors = floors;
        }
        public override decimal calculate_commission()
        {
            if (floors <1 || floors >3)
                throw new Exception("No houses with " + floors + " floor/floors. Please verifiy that dates are correct!");
            else if (floors > 0 || floors < 2)
            {
                if (yearBuilt < 1990)
                {
                    if (surface < 50 || surface > 350)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (surface <= 150)
                        return price * 0.01m;
                }
                else
                {
                    if (surface < 30 || surface > 90)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (surface <= 150)
                        return price * 0.015m;
                }
                return price;
            }
            else if (floors >= 2 || floors <= 3) {
                if (yearBuilt < 1990)
                {
                    if (surface < 50 || surface > 350)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (surface <= 150)
                        return price * 0.015m;
                }
                else
                {
                    if (surface < 30 || surface > 90)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (surface <= 150)
                        return price * 0.025m;
                } 
            }

         return price;
        }
    }
}

