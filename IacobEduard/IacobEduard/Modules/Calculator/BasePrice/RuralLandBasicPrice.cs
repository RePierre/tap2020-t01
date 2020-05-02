using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator;

namespace Modules.Core.Calculator.BasePrice
{
    public class RuralLandBasicPrice : BasePrice
    {
        decimal basicPrice = 0;

        public override decimal GetInitialLandPrice(Asset asset)
        {
            if(asset.SM > 0) { basicPrice = asset.SM * 1000; }
            else if(asset.SM < 0) { throw new InvalidOperationException("The number of square meters can't be a negative number!"); }
            return basicPrice;
        }

        public override decimal GetInitialPrice(Estate estate)
        {
            throw new NotImplementedException();
        }
    }
}
