using System;

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
            estate=Console.ReadLine();
            if (estate == "House")
            {
                Console.WriteLine("How many square feet do you want your house to be ?");
                sf = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose the location you prefer (center or suburbs)");
                location = Console.ReadLine();
                House house=new House(sf, location);
                Console.WriteLine("The price will be:" + house.get_price());
                Console.WriteLine("Our commision will be: " + house.get_commision());

            }
            if (estate == "Apartment")
            {
                Console.WriteLine("How many square feet do you want your house to be ?");
                sf = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose the location you prefer (center or suburbs)");
                location = Console.ReadLine();
                Apartment apartment = new Apartment(sf, location);
                Console.WriteLine("The price will be:" + apartment.get_price());
                Console.WriteLine("Our commision will be: " + apartment.get_commision());

            }
            if (estate == "SingleRoom")
            {
                Console.WriteLine("How many square feet do you want your house to be ?");
                sf = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose the location you prefer (center or suburbs)");
                location = Console.ReadLine();
                SingleRoom singleroom = new SingleRoom(sf, location);
                Console.WriteLine("The price will be:" + singleroom.get_price());
                Console.WriteLine("Our commision will be: " + singleroom.get_commision());

            }

        }
    }
}
