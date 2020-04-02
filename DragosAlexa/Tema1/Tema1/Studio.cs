using System;

namespace Tema2
{
    public class Studio : RealEstateAgency
    {
        public Studio(decimal price,double surface, int yearBuilt, string address) : base(price,surface, yearBuilt,address){}
        public override decimal calculate_commission()
        {
            if (yearBuilt < 1990)
            {
                if (surface < 15 || surface>30)
                    throw new Exception("No studios with this surface! Please introduce a valid value for surface(15-30 square meters).");
                else if (surface <= 30)
                    return price * 0.008m;
            }
            else
            {
                if (surface < 15|| surface>30)
                    throw new Exception("No studios with this surface! Please introduce a valid value for surface(15-30 square meters).");
                else if (surface <=30)
                    return price * 0.012m;
            }
            return price;
        }
    }
}

