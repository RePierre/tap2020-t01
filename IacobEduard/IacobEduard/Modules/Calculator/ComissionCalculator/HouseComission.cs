using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator;


namespace Modules.Core.Calculator.ComissionCalculator
{
    public class HouseComission : ComCalculator
    {
        protected override decimal CalculateComission(Estate estate)
        {
            decimal comission = 0.10m;
            return comission;
        }

        protected override decimal CalculateComission(Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}