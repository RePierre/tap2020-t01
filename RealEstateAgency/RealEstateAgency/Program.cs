using System;
using Uaic.RealEstateAgency.Core.Assets;
using Uaic.RealEstateAgency.Core.Assets.Estates;
using Uaic.RealEstateAgency.Core.Assets.Land;
using Uaic.RealEstateAgency.Core.Calculators;

namespace RealEstateAgency {
    class Program{
        static void Main()
        {
            Apartment apartament = new Apartment("2nd Street", 50000);
            ApartmentCommisionCalculator apartmentCommision = new ApartmentCommisionCalculator();
            Console.WriteLine("Apartment \nAddress: {0} \nSelling Price: {1} \nAgent's Commision: {2}",apartament.address, apartmentCommision.SellingPriceCalculator(apartament.initialPrice), apartmentCommision.AgentCommisionCalculator(apartament.initialPrice));
            Studio studio = new Studio("Jefferson Boulevard", 30000);
            StudioCommisionCalculator studioCommision = new StudioCommisionCalculator();
            Console.WriteLine("Studio \nAddress: {0} \nSelling Price: {1} \nAgent's Commision: {2}", studio.address, studioCommision.SellingPriceCalculator(studio.initialPrice), studioCommision.AgentCommisionCalculator(studio.initialPrice));
            House house = new House("Anderson Street", 120000);
            HouseCommisionCalculator houseCommision = new HouseCommisionCalculator();
            Console.WriteLine("House \nAddress: {0} \nSelling Price: {1} \nAgent's Commision: {2}", house.address, houseCommision.SellingPriceCalculator(house.initialPrice), houseCommision.AgentCommisionCalculator(house.initialPrice));
            Land land = new Land("096846", 48000);
            LandCommisionCalculator landCommision = new LandCommisionCalculator();
            Console.WriteLine("Land \nCadastral Number: {0} \nSelling Price: {1} \nAgent's Commision: {2}", land.cadastralNumber, landCommision.SellingPriceCalculator(land.initialPrice), landCommision.AgentCommisionCalculator(land.initialPrice));
        }
    }
}
