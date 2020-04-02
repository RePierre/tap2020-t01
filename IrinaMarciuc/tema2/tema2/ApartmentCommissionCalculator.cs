using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class ApartmentCommissionCalculator : CommissionCalculator
    {
        public override decimal GetCommission()
        {
            return 1.6m;
        }
    }
}
