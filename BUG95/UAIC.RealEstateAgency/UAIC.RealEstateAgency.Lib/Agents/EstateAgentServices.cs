using UAIC.RealEstateAgency.Calculators;
using UAIC.RealEstateAgency.EstatesBase;

namespace UAIC.RealEstateAgency.Agents
{
    public static class EstateAgentServices
    {
        public static void CommunicatePrice(EstateAgent estateAgent, EstateAgency estate, EstateFeeCalculator estateFeeCalculator)
        {
            System.Console.WriteLine($"Estate price: {estateAgent.GetEstatePrice(estate, estateFeeCalculator)}");
        }
        public static void CommunicateType(EstateAgent estateAgent, EstateAgency estate)
        {
            System.Console.WriteLine($"Estate type: {estateAgent.GetEstateType(estate)}");
        }
        public static void CommunicateAddress(Immobile immobile)
        {
            System.Console.WriteLine($"Immobile address: {immobile.address}");
        }
        public static void CommunicateCadastralNumber(Lot lot)
        {
            System.Console.WriteLine($"Cadastral number: {lot.cadastralNumber}");
        }
        public static void CommunicateAgentCommission(EstateAgency estate, EstateFeeCalculator estateFeeCalculator)
        {
            System.Console.WriteLine($"Agent commission: {estateFeeCalculator.GetEstateCommission(estate.Base_price)}");
        }
    }
}


