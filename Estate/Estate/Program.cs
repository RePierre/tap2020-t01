using Uaic.Estate;
using Uaic.Estate.Core;
using Uaic.Estate.Core.Assets;
using Uaic.Estate.Core.Assets.Base;
using Uaic.Estate.Core.Calculators;
namespace Estate
{
     class Program
    {
        static void Main(string[] args)
        {
            var houseCalculator = new HouseAgentCommission();
            var apartmentCalculator = new ApartmentAgentCommission();
            var studioApartmentCalculator = new StudioApartmentAgentCommission();
            var landCalculator = new LandAgentCommission();
            PropertyType house = new House();
            PropertyType apartment = new Apartment();
            PropertyType studioApartment = new StudioApartment();
            PropertyType land = new Land();
            Agency.PriceForPropetyType(house, "Calea Unirii, nr.80", 210000, houseCalculator);
            Agency.PriceForPropetyType(apartment, "Aleea Decebal, nr.3", 72000, apartmentCalculator);
            Agency.PriceForPropetyType(studioApartment, "Piata Victoriei, nr.6", 31500, studioApartmentCalculator);
            Agency.PriceForPropetyType1(land,13216,1200000,landCalculator);
          

        }  
        }
 }
