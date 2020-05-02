using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator.ComissionCalculator;

namespace Modules.Core.Calculator.ComissionCalculator
{
    public abstract class ComCalculator : InitialComCalculator
    {
        protected abstract decimal CalculateComission(Estate estate);
        protected abstract decimal CalculateComission(Asset asset);

        public decimal GetComission(Estate estate, decimal price)
        {
            var comission = CalculateComission(estate);
            return price * comission;
        }

        public decimal GetPrice(Estate estate, decimal price)
        {
            var comission = GetComission(estate, price);
            return price += comission;
        }

        public decimal GetComission(Asset asset, decimal price)
        {
            var comission = CalculateComission(asset);
            return price * comission;
        }

        public decimal GetPrice(Asset asset, decimal price)
        {
            var comission = GetComission(asset, price);
            return price += comission;
        }
    }
}
