using System;

namespace Tema2
{
    class LandCommissionCalculator : CommissionCalculator
    {
        public override decimal CalculateCommission(RealEstateAgency rea, decimal price)
        {
            if (rea.type.ToLower() == "urban")
            {
                if (rea.surface < 3000)
                    return price*0.02m;
                else if (rea.surface > 3000 || rea.surface < 10000)
                    return price*0.035m;
                else
                    return price*0.05m;
            }
            else if (rea.type.ToLower() == "rural")
            {
                if (rea.surface < 3000)
                    return price*0.01m;
                else if (rea.surface > 3000 || rea.surface < 10000)
                    return price*0.015m;
                else
                    return price*0.03m;
            }
            throw new Exception("Invalid type of land(Please verify that type are rural/urban)");
        }
    }
}




