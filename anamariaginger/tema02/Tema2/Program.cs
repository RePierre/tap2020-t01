using System;
using Tema2.Core;
using Tema2.Core.Estates;
using Tema2.Core.Prices;
using Tema2.Core.Calculator;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string estate;
            int sf;
            string location;

            Console.WriteLine("Welcome!!");
            Console.WriteLine("Tell us what tipe of place you are looking for.");
            Console.WriteLine("House");
            Console.WriteLine  ("Apartment" );
            Console.WriteLine ("SingleRoom");
            Console.WriteLine("Land");
            estate =Console.ReadLine();
            if (estate == "House")
            {
                
                Console.WriteLine("How many square feet do you want your house to be ?");
                sf = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose the location you prefer (center or suburbs)");
                location = Console.ReadLine();
                House house=new House(sf, location);

                var price = new HouseBasePrice();
                var calculator = new HouseComissionCalculator();
                
                Prices.GetLocation(house, location);
                Prices.GetInitialPrice(house, price);
                Prices.GetComission(house,  calculator,price);
                Prices.GetPrice(house, calculator, price);
               

            }
            if (estate == "Apartment")
            {

                Console.WriteLine("How many square feet do you want your house to be ?");
                sf = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose the location you prefer (center or suburbs)");
                location = Console.ReadLine();
                Apartment apartment = new Apartment(sf, location);

                var price = new ApartmentBasePrice();
                var calculator = new ApartmentComissionCalculator();

                Prices.GetLocation(apartment, location);
                Prices.GetInitialPrice(apartment, price);
                Prices.GetComission(apartment, calculator, price);
                Prices.GetPrice(apartment, calculator, price);
              

            }
            if (estate == "SingleRoom")
            {

                Console.WriteLine("How many square feet do you want your house to be ?");
                sf = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose the location you prefer (center or suburbs)");
                location = Console.ReadLine();
                SingleRoom singleroom = new SingleRoom(sf, location);

                var price = new SingleRoomBasePrice();
                var calculator = new SingleRoomComissionCalculator();

                Prices.GetLocation(singleroom, location);
                Prices.GetInitialPrice(singleroom, price);
                Prices.GetComission(singleroom, calculator, price);
                Prices.GetPrice(singleroom, calculator, price);


            }
            if (estate == "Land")
            {

                Console.WriteLine("How many square feet do you want your house to be ?");
                sf = int.Parse(Console.ReadLine());
                Console.WriteLine("Tell us the cadastral number: 4578/ 3463/ 2098");
                int cadastral_nr = int.Parse(Console.ReadLine());
                Land land = new Land(sf, cadastral_nr);

                var price = new LandBasePrice();
                var calculator = new LandComissionCalculator();

                Prices.GetLocationLand(land, cadastral_nr);
                Prices.GetInitialPrice(land, price);
                Prices.GetComission(land, calculator, price);
                Prices.GetPrice(land, calculator, price);


            }



        }
    }
}
