using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Calculator.BasePrice;
using Modules.Core.Assets;

namespace Modules.Core.Calculator.ComissionCalculator
{
    public class AssetCalculator : InitialBasePrice
    {
        public decimal GetBasePrice(Estate estate)
        {
            return 90000;
        }
        public decimal GetLandBasePrice(Asset asset)
        {
            return 150000;
        }
    }
}
