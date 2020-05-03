using Imobile.Core.Estates;
using Imobile.Core.Calculators.Comissioncalc;
using System;
namespace Imobile.Core.Calculators.InitialPriceCalc
{
    public class FlatInitPrice : InitialPrice
    {
        
        public override decimal GetInitPrice(Estate estate)
        {
            decimal price = 0;
            if (estate.sm < 43) price = 20000;
            else if (estate.sm >= 43 && estate.sm <= 59) price = 35000;//one room flat
            else if (estate.sm >= 60 && estate.sm <= 69) price = 47000;//two rooms flat
            else if (estate.sm >= 70 && estate.sm <= 90) price = 60000;//three rooms flat
            else if (estate.sm > 90) price = 95000;//penthouse
            return price;
        }

        public override decimal GetInitPrice(Assets asset)
        {
            throw new NotImplementedException();
        }
    }
}
