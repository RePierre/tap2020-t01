using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator.ComissionCalculator;

namespace Modules.Core.Calculator.BasePrice
{
    public class HouseBasePrice : BasePrice
    {
        decimal basicPrice = 0;

        public override decimal GetInitialPrice(Estate estate)
        {
            if (estate.Rooms == 1) { basicPrice = estate.SM * 640; }
            else { basicPrice = estate.SM * 1175 + estate.Rooms * 100; }
            if (estate.Rooms > 3) { throw new InvalidOperationException("A house can't have more than 3 floors!"); }
            else { basicPrice += estate.Floor * 100; }
            return basicPrice;
        }

        public override decimal GetInitialLandPrice(Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}
