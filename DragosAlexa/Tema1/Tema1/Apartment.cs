using System;

namespace Tema1
{
    public class Apartment : RealEstateAgency {
        public Apartment(decimal price, int surface, int yearBuilt) : base(price, surface, yearBuilt) { }
        public override decimal calculate_commission()
        {
            if (yearBuilt < 1990)
            {
                if (surface < 30 || surface > 90)
                    throw new Exception("No apartments with this surface! Please introduce a valid value for surface(30-90 square meters).");
                else if (surface <=60)
                    return price * 0.016m;
            }
            else
            {
                if (surface < 30 || surface > 90)
                    throw new Exception("No apartments with this surface! Please introduce a valid value for surface(30-90 square meters).");
                else if (surface <= 60)
                    return price * 0.02m;
            }
            return price;
        }
    }
}

