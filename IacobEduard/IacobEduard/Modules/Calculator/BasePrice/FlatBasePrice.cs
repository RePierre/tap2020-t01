using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator;


namespace Modules.Core.Calculator.BasePrice
{
    public class FlatBasePrice : BasePrice
    {
        decimal basicPrice = 0;

        public override decimal GetInitialPrice(Estate estate)
        {
            if (estate.Rooms== 2) { basicPrice = 69000; }
            else { basicPrice = estate.SM * 1175; }
            if (estate.Floor >= 2 || estate.Floor <= 8) { basicPrice += 100; }
            else if (estate.Floor == 13) { basicPrice -= 130; }//for the ppl with Triskaidekaphobia (13 number phobia)
            else { basicPrice -= 50; }
            return basicPrice;
        }

        public override decimal GetInitialLandPrice(Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}
