using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class HouseCommissionCalculator : CommissionCalculator
    {
        public override decimal GetCommission()
        {
            return 2m;
        }
    }
   
}
