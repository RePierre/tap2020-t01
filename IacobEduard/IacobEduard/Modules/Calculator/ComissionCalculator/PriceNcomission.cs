using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator.BasePrice;

namespace Modules.Core.Calculator.ComissionCalculator
{
    public abstract class PriceNcomission : InPriceNcomission
    {
        public abstract decimal CalculateComission(Estate estate);

        public decimal GetCommision(Estate estate, decimal price)
        {
            var comission = CalculateComission(estate);
            return price * comission;
        }

        public decimal GetPrice(Estate estate, decimal price)
        {
            var comission = GetCommision(estate, price);
            return price += comission;
        }
    }
}
