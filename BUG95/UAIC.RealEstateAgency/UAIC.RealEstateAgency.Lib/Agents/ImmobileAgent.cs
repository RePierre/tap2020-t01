using UAIC.RealEstateAgency.EstatesBase;

namespace UAIC.RealEstateAgency.Agents
{
    public class ImmobileAgent : EstateAgent, IImmobileAgent
    {
        public string GetAddress(Immobile immobile)
        {
            return immobile.address;
        }
    }
}