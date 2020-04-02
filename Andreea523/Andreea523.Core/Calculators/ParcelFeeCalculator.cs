using System;
using System.Collections.Generic;
using System.Text;

namespace Uaic.Andreea523.Core.Calculators
{
    public class ParcelFeeCalculator : FeeCalculator
    {
        protected override decimal CalculateCommissionn(decimal price, string zone)
        {

            if (zone == "central")
                return price * 2.5m / 100;
            else 
                return price * 2.1m / 100;
            

        }
    }
}
