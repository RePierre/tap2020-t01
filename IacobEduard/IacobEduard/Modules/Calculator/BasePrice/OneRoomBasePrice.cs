using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator;


namespace Modules.Core.Calculator.BasePrice
{
    public class OneRoomBasePrice : BasePrice
    {
        decimal basicPrice = 0;

        public override decimal GetInitialPrice(Estate estate)
        {
            if (estate.Rooms == 1) { basicPrice = estate.SM * 800; }
            else if (estate.Rooms != 1) { throw new InvalidOperationException("The number of rooms must be 1!"); }
            if (estate.Floor >= 2 || estate.Floor <= 8) { basicPrice += 100; }
            else if (estate.Floor == 13) { basicPrice -= 130; }
            else { basicPrice -= 50; }
            return basicPrice;
        }

        public override decimal GetInitialLandPrice(Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}
