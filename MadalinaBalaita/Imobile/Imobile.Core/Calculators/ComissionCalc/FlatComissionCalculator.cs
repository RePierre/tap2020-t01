﻿using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
namespace Imobile.Core.Calculators.Comissioncalc
{
    public class FlatComissionCalculator : ComissionCalculator
    {
       

        protected override decimal CalculateComission(Estate estate)
        {
            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3=0m;
            decimal poundage;

             if (estate.sm < 43) poundage1 = 0.005m;
            else if (estate.sm >= 43 && estate.sm <= 59) poundage1 = 0.01m;//one room flat
            else if (estate.sm >= 60 && estate.sm <= 69) poundage1 = 0.015m;//two rooms flat
            else if (estate.sm >= 70 && estate.sm <= 90) poundage1 = 0.02m;//three rooms flat
            else if (estate.sm > 90) poundage1 = 0.05m;//penthouse

            //location of the house
            if (estate.location == "center") poundage2 = 0.015m;
            else if (estate.location == "suburbs") poundage2 = 0.005m;
            else if (estate.location == "somewhere ok") poundage2 = 0.01m;

            //condition of the house

            if (estate.condition == "old") poundage3 = 0.001m;
            else if (estate.condition == "medium") poundage3 = 0.005m;
            else if (estate.condition == "new") poundage3 = 0.01m;
           


            poundage = poundage1 + poundage2 + poundage3;
            return poundage;
        }


    }
}
