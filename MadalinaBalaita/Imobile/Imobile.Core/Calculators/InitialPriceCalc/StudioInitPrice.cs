using Imobile.Core.Estates;
using Imobile.Core.Calculators.Comissioncalc;
using System;
namespace Imobile.Core.Calculators.InitialPriceCalc
{
    public class StudioInitPrice : InitialPrice
    {
        
       public override decimal GetInitPrice(Estate estate)
        {
            decimal price = 0;
            if (estate.sm >= 15 && estate.sm <= 30) price= 15000;
            else if (estate.sm > 30) price=22000;
            return price;
        }

        public override decimal GetInitPrice(Assets asset)
        {
            throw new NotImplementedException();
        }
    }
}
