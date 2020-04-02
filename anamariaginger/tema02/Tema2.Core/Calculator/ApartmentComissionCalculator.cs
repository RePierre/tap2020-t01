using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2.Core.Calculator
{
    class ApartmentComissionCalculator : ComissionCalculator
    {
        public override decimal CalculateComission(decimal amount)
        {
            return amount*0.15m;
        }
    }
    
}
