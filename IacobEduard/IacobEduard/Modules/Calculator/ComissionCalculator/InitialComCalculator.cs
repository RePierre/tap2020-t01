using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator;


namespace Modules.Core.Calculator.ComissionCalculator
{
    public interface InitialComCalculator
    {
        decimal GetComission(Estate estate, decimal price);
        decimal GetPrice(Estate estate, decimal price);

        decimal GetComission(Asset asset, decimal price);
        decimal GetPrice(Asset asset, decimal price);
    }
}
