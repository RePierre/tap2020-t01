using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAIC.RealEstateAgency.Agents;
using UAIC.RealEstateAgency.Calculators;
using UAIC.RealEstateAgency.Estates;
using UAIC.RealEstateAgency.EstatesBase;

namespace UAIC.RealEstateAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            Immobile estate1 = new House("Iasi", 199.000m);
            Lot estate2 = new Lot(200, 10.000m);
            ImmobileAgent immobileAgent = new ImmobileAgent();
            LotAgent lotAgent = new LotAgent();
            HouseFeeCalculator houseFeeCalculator = new HouseFeeCalculator();
            LotFeeCalculator lotFeeCalculator = new LotFeeCalculator();

            EstateAgentServices.CommunicateType(immobileAgent, estate1);
            EstateAgentServices.CommunicateAddress(estate1);
            EstateAgentServices.CommunicatePrice(immobileAgent, estate1, houseFeeCalculator);
            EstateAgentServices.CommunicateAgentCommission(estate1, houseFeeCalculator);

            Console.WriteLine();

            EstateAgentServices.CommunicateType(lotAgent, estate2);
            EstateAgentServices.CommunicateCadastralNumber(estate2);
            EstateAgentServices.CommunicatePrice(lotAgent, estate2, lotFeeCalculator);
            EstateAgentServices.CommunicateAgentCommission(estate2, lotFeeCalculator);

            Console.ReadKey();
        }
    }
}


