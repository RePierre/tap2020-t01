using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator.ComissionCalculator;

namespace Modules.Core.Calculator.ComissionCalculator
{
    public interface InPriceNcomission
    {
        decimal GetPrice(Estate estate , decimal price);
        decimal GetCommision(Estate estate, decimal price);
    }

}
