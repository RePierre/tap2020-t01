using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;
using Modules.Core.Calculator;


namespace Modules.Core.Calculator.ComissionCalculator
{
    public class RuralLandComission : ComCalculator
    {
        protected override decimal CalculateComission(Estate estate)
        {
            throw new NotImplementedException();
        }

        protected override decimal CalculateComission(Asset asset)
        {
            decimal comission = 0m;
            if(asset.SM < 500) { comission = 0.045m; }
            else if (asset.SM > 500 && asset.SM < 2500) { comission = 0.065m; }
            else { comission = 0.086m; }
            return comission;
        }
    }
}