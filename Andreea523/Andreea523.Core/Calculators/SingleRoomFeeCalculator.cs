using System;
using System.Collections.Generic;
using System.Text;

namespace Uaic.Andreea523.Core.Calculators

{
   public class SingleRoomFeeCalculator : FeeCalculator
    {
        protected override decimal CalculateCommissionn(decimal price, string zone) 
        {
            if (zone == "central")
                return price * 0.7m / 100;
            else 
                return price * 0.4m / 100;
            
        }

    }
}
