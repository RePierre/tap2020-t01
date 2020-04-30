using Uaic.tema2.Core.Assets.Base;

namespace Uaic.tema2.Core.Calculators
{
   public class HouseCommissionCalculator : CommissionCalculator
    {
        public override decimal GetCommission()
        {
            return 2m;
        }
    }
   
}
