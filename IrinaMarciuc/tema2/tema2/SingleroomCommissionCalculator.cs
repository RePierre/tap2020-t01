using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    class SingleroomCommissionCalculator : CommissionCalculator
    {
        public override decimal GetCommission()
        {
            return 1.1m;
        }
   
    }
}
