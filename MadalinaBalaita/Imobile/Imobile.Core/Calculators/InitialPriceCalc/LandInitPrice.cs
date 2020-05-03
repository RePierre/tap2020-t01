using Imobile.Core.Estates;
using Imobile.Core.Calculators.Comissioncalc;
using System;
namespace Imobile.Core.Calculators.InitialPriceCalc
{
    public class LandInitPrice : InitialPrice
    {
        
       public override decimal GetInitPrice(Assets asset)
        {
            decimal price = 0;
            if (asset.usage == "intravilan")
            {
                if (asset.sm < 500) price = 8000;
                else if (asset.sm >= 500 && asset.sm <= 1500) price = 14000;
                else if (asset.sm > 1500) price = 20000;
            }
            else if (asset.usage == "extravilan")
            {
                if (asset.sm < 500) price = 5000;
                else if (asset.sm >= 500 && asset.sm <= 1500) price = 10000;
                else if (asset.sm > 1500) price = 15000;
            }
            return price;
        }
        public override decimal GetInitPrice(Estate estate)
        {
            throw new NotImplementedException();
        }

    }
}
