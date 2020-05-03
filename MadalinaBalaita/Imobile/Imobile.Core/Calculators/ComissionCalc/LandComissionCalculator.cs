using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
using System;
namespace Imobile.Core.Calculators.Comissioncalc
{
    public class LandComissionCalculator : ComissionCalculator
    {
      
        public override decimal CalculateComission(Assets asset)
        {
            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3=0m;
            decimal poundage;

            if (asset.sm < 500) poundage1 = 0.005m;
            else if (asset.sm >= 500 && asset.sm <= 1500) poundage1 = 0.007m;
            else if (asset.sm > 1500) poundage1 = 0.01m;

            //cadastral number
            if (asset.cadastral_nr == 543345) poundage2 = 0.015m;
            else if (asset.cadastral_nr == 23214) poundage2 = 0.005m;
            else if (asset.cadastral_nr == 61321) poundage2 = 0.01m;

            //condition of the house

            if (asset.usage == "intravilan") poundage3 = 0.001m;
            else if (asset.usage == "extravilan") poundage3 = 0.005m;

            poundage = poundage1 + poundage2 + poundage3;
            return  poundage;
        }

        public override decimal CalculateComission(Estate estate)
        {
            throw new NotImplementedException();
        }
    }
}
