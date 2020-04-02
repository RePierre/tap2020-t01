using System;

namespace Tema2
{
    public class Apartment : RealEstateAgency {
        public Apartment(decimal price, double surface, int yearBuilt,string address) : base(price, surface, yearBuilt,address) { }
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

