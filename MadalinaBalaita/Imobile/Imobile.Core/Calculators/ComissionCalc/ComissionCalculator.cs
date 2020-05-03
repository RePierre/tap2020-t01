using System;
using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
namespace Imobile.Core.Calculators.Comissioncalc
{
    public abstract class ComissionCalculator : IComissionCalculator
    {

        public abstract decimal CalculateComission(Estate estate);
        public abstract decimal CalculateComission(Assets asset);
        public decimal Get_poundage(Estate estate, decimal price)
        {
            var comission = CalculateComission(estate);
            return price * comission;
        }
        public decimal Get_price(Estate estate, decimal price)
        {

            var comission = Get_poundage(estate, price);
            return price += comission;

        }

        public decimal Get_price(Assets asset, decimal price)
        {
            
            var comission = Get_poundage(asset, price);
            return price += comission;

        }
        public decimal Get_poundage(Assets asset, decimal price)
        {
            var comission = CalculateComission(asset);
            return price * comission;
        }

       
    }
}
