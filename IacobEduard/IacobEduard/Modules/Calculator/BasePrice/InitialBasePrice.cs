using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator.ComissionCalculator;


namespace Modules.Core.Calculator.BasePrice
{
    public interface InitialBasePrice
    {
        decimal GetBasePrice(Estate estate);
        decimal GetLandBasePrice(Asset asset);
    }
}
