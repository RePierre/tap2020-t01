using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
namespace Imobile.Core.Calculators.Comissioncalc
{
    public interface IComissionCalculator
    {
        decimal Get_poundage(Estate estate, decimal price);
        decimal Get_price(Estate estate, decimal price);
        decimal Get_poundage(Assets assets, decimal price);
        decimal Get_price(Assets assets, decimal price);
    }
}