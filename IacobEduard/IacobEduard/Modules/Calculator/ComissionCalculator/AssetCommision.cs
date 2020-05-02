using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator;

namespace Modules.Core.Calculator.ComissionCalculator
{
    public class AssetCommision : InPriceNcomission
    {
        public decimal GetCommision(Estate estate, decimal price)
        {
            return price * 0.05m;
        }

        public decimal GetPrice(Estate estate, decimal price)
        {
            price = new AssetCalculator().GetBasePrice(estate);
            return price += estate.Comission;
        }

        public decimal GetCommision(Asset asset, decimal price)
        {
            return price * 0.05m;
        }

        public decimal GetPrice(Asset asset, decimal price)
        {
            price = new AssetCalculator().GetLandBasePrice(asset);
            return price += asset.Comission;
        }
    }
}
