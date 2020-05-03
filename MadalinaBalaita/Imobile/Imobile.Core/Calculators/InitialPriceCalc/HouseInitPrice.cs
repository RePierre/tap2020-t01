using Imobile.Core.Estates;
using Imobile.Core.Calculators.Comissioncalc;
using System;

namespace Imobile.Core.Calculators.InitialPriceCalc
{
    public class HouseInitPrice : InitialPrice
    {
        public double sm;
        public override decimal GetInitPrice(Estate estate)
        {
            decimal price=0;
            if (estate.sm < 70) price=80000;
            else if (estate.sm >= 70 && estate.sm <= 80) price= 130000;
            else if (estate.sm > 80) price=200000;
            return price;
            
        }

        public override decimal GetInitPrice(Assets asset)
        {
            throw new NotImplementedException();
        }
    }
}
