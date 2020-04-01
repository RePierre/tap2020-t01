﻿using Imobile.Core.Estates;
namespace Imobile.Core.Calculators
{
    public class StudioComissionCalculator : ComissionCalculator
    {

        protected override decimal CalculateComission(Estate estate)
        {

            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3=0m;
            decimal poundage;

            if (estate.sm >= 15 && estate.sm <= 30) poundage1 = 0.005m;
            else if (estate.sm > 30) poundage1 = 0.01m;


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
