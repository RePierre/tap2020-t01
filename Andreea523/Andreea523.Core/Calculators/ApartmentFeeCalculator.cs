using System;
using System.Collections.Generic;
using System.Text;

namespace Uaic.Andreea523.Core.Calculators
{
   public class ApartmentFeeCalculator : FeeCalculator
    {
        protected override decimal CalculateCommissionn(decimal price, string zone)
        {
            if (zone == "central")
                return price * 1.2m / 100;
            else 
                return price * 0.9m / 100;
           
        }
    }
}
