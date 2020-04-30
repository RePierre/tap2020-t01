using Uaic.tema2.Core.Assets.Base;

namespace Uaic.tema2.Core.Calculators
{
   public class SingleroomCommissionCalculator : CommissionCalculator
    {
        public override decimal GetCommission()
        {
            return 1.1m;
        }
   
    }
}
