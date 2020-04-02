using Uaic.tema2.Core.Assets.Base;

namespace Uaic.tema2.Core.Calculators
{
    public class ApartmentCommissionCalculator : CommissionCalculator
    {
        public override decimal GetCommission()
        {
            return 1.6m;
        }
    }
}
