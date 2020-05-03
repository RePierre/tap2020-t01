using Imobile.Core.Estates;
using Imobile.Core.Calculators.Comissioncalc;
namespace Imobile.Core.Calculators.InitialPriceCalc
{
    public interface IInitialPrice
    {
        decimal Get_price_fromLandlord(Estate estate);
        decimal Get_price_fromLandlord(Assets asset);
    }
}