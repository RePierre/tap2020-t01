using System;
namespace tema1
{
    public class Apartment : RealEstate
    {
        public override decimal CalculateCommission(decimal amount, String location)
        {
            decimal commission;
            if (location == "periphery")
                commission = 1.5m;
            else commission = 2m;
            return commission;
        }

    }
}

