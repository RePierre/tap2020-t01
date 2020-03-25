using UAIC.RealEstateAgency.EstatesBase;

namespace UAIC.RealEstateAgency.Agents
{
    public class LotAgent : EstateAgent, ILotAgent
    {
        public int GetCadastralNumber(Lot lot)
        {
            return lot.cadastralNumber;
        }
    }












}
