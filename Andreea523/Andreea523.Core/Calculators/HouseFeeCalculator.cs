using System;
using System.Collections.Generic;
using System.Text;

namespace Uaic.Andreea523.Core.Calculators
{
   public class HouseFeeCalculator:FeeCalculator
    {
        protected override decimal CalculateCommissionn(decimal price, string zone)
        {
            if (zone == "central")
                return price * 1.8m / 100;
            else 
                return price * 1.5m / 100;
            
        }
    }
}
