using UAIC.RealEstateAgency.Calculators;
using UAIC.RealEstateAgency.EstatesBase;

namespace UAIC.RealEstateAgency.Agents
{
    public abstract class EstateAgent
    {
        public decimal GetEstatePrice(EstateAgency estate, IEstateFeeCalculator estateFeeCalculator)
        {
            return estateFeeCalculator.CalculateEstatePrice(estate.Base_price);
        }
        public string GetEstateType(EstateAgency estate)
        {
            return estate.type;
        }
    }












}
