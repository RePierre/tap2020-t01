using System;
namespace tema1
{
    public class Singleroom : RealEstate
    {
        public override decimal CalculateCommission(decimal amount, String location)
        {
            decimal commission;
            if (location == "periphery")
                commission = 1.1m;
            else commission = 1.2m;
            return commission;
        }
    }
}
