using System;
namespace tema1
{
    class House : RealEstate
    {
        public override decimal CalculateCommission(decimal amount, String location)
        {
            decimal commission;
            if (amount < 10000m && location == "periphery") //euro
                commission = 1m;
            else if (amount < 10000m && location == "center")
                commission = 1.8m;
            else if (amount < 20000m && location == "periphery")
                commission = 1.6m;
            else if (amount < 20000m && location == "center")
                commission = 1.9m;
            else if (amount < 30000m && location == "periphery")
                commission = 2m;
            else if (amount < 30000m && location == "center")
                commission = 2.5m;
            else commission = 3m;
            return commission;
        }

    }
}
