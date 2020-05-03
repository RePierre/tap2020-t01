using System;
using Imobile.Core.Estates;
using Imobile.Core.Calculators.Comissioncalc;
namespace Imobile.Core.Calculators.InitialPriceCalc
{
    public abstract class InitialPrice : IInitialPrice
    {

        public abstract decimal GetInitPrice(Estate estate);
        public decimal Get_price_fromLandlord(Estate estate)
        {
            var price = GetInitPrice(estate);
            return price;
        }

       public abstract decimal GetInitPrice(Assets asset);
        public decimal Get_price_fromLandlord(Assets asset)
        {
            var price = GetInitPrice(asset);
            return price;
        }



    }
}
