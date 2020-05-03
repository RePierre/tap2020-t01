
using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
using System;
namespace Imobile.Core.Calculators.Comissioncalc
{

   
        public class AssetsCalculator : IInitialPrice
        {
            public decimal Get_price_fromLandlord(Assets asset)
            {
                return 130000;
            }
        public decimal Get_price_fromLandlord(Estate estate)
        {
            return 30000;
        }
    }

}
