using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator;


namespace Modules.Core.Calculator.ComissionCalculator
{
    public class UrbanLandComission : ComCalculator
    {
        protected override decimal CalculateComission(Estate estate)
        {
            throw new NotImplementedException();
        }

        protected override decimal CalculateComission(Asset asset)
        {
            decimal comission = 0m;
            if (asset.SM < 50) { comission = 0.085m; }
            else if (asset.SM > 50 && asset.SM < 250) { comission = 0.10m; }
            else { comission = 0.15m; }
            return comission;
        }
    }
}