using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Calculator.ComissionCalculator;
using Modules.Core.Assets;

namespace Modules.Core.Calculator.BasePrice
{
    public abstract class BasePrice : InitialBasePrice
    {
        public abstract decimal GetInitialPrice(Estate estate);
        public abstract decimal GetInitialLandPrice(Asset asset);

        public decimal GetLandBasePrice(Asset asset)
        {
            var price = GetInitialLandPrice(asset);
            return price;
        }

        public decimal GetBasePrice(Estate estate)
        {
            var price = GetInitialPrice(estate);
            return price;
        }


    }
}
