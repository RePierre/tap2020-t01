using System;
using Imobile.Core;
using Imobile.Core.Calculators;
using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
using Imobile.Core.Calculators.Comissioncalc;

namespace Imobile
{
   
    partial class Program
    {


        static void Main(string[] args)
        {
            string estate;
            int cad_nr;
            double sqm;
            string loc, cond,answer;
            int k=0;
            Console.WriteLine("Welcome to our Real Estate Agency!");
            while (k == 0)
            {
                Console.WriteLine("What are you looking for?(House/Flat/Studio/Land)");
                estate = Console.ReadLine();
                Console.WriteLine(" ");

                if (estate == "House")
                {

                    var initialPrice = new HouseInitPrice();
                    var calculator = new HouseComissionCalculator();
                    Console.WriteLine("How many square meters?");
                    sqm = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose a location (center/somewhere ok/suburbs)");
                    loc = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the house condition(new/medium/old)");
                    cond = Console.ReadLine();
                    Console.WriteLine(" ");

                    House house = new House(sqm, loc, cond);
                    //Console.WriteLine(house.sm);
                    // Console.WriteLine("(Price withouth fee:" + house.Get_price_fromLandlord(initialPrice.Get_price_fromLandlord(house)) + " , the poundage:" + house.Get_poundage(calculator.Get_poundage(house, initialPrice.Get_price_fromLandlord(house))) + ")" + "The total price of this house is: " + house.Get_price(calculator.Get_price(house, initialPrice.Get_price_fromLandlord(house))));
                    RealEstatePrices.GetInitialPriceFrom(house, initialPrice);
                    RealEstatePrices.GetComissionFrom(house, calculator, initialPrice);
                    RealEstatePrices.GetPriceFrom(house, calculator, initialPrice);
                    RealEstatePrices.GetLocationFrom(loc, house);
                    //TestGoodPrice(house);

                }
                else if (estate == "Flat")
                {

                    var initialPrice = new FlatInitPrice();
                    var calculator = new FlatComissionCalculator();
                    Console.WriteLine("How many square meters?");
                    sqm = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose a location (center/somewhere ok/suburbs)");
                    loc = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the house condition(new/medium/old)");
                    cond = Console.ReadLine();
                    Console.WriteLine(" ");

                    Flat flat = new Flat(sqm, loc, cond);
                    RealEstatePrices.GetInitialPriceFrom(flat, initialPrice);
                    RealEstatePrices.GetComissionFrom(flat, calculator, initialPrice);
                    RealEstatePrices.GetPriceFrom(flat, calculator, initialPrice);
                    //Console.WriteLine("(Price withouth fee:" + flat.Get_price_fromLandlord(initialPrice.Get_price_fromLandlord(flat)) + " , the poundage:" + flat.Get_poundage(calculator.Get_poundage(flat, initialPrice.Get_price_fromLandlord(flat))) + ")" + "The total price of this house is: " + flat.Get_price(calculator.Get_price(flat, initialPrice.Get_price_fromLandlord(flat))));
                    RealEstatePrices.GetLocationFrom(loc, flat);

                }
                else if (estate == "Studio")
                {

                    var initialPrice = new StudioInitPrice();
                    var calculator = new StudioComissionCalculator();
                    Console.WriteLine("How many square meters?");
                    sqm = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose a location (center/somewhere ok/suburbs)");
                    loc = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the house condition(new/medium/old)");
                    cond = Console.ReadLine();

                    Studio studio = new Studio(sqm, loc, cond);
                    RealEstatePrices.GetInitialPriceFrom(studio, initialPrice);
                    RealEstatePrices.GetComissionFrom(studio, calculator, initialPrice);
                    RealEstatePrices.GetPriceFrom(studio, calculator, initialPrice);
                    // Console.WriteLine("(Price withouth fee:" + studio.Get_price_fromLandlord(initialPrice.Get_price_fromLandlord(studio)) + " , the poundage:" + studio.Get_poundage(calculator.Get_poundage(studio,initialPrice.Get_price_fromLandlord(studio))) + ")" + "The total price of this house is: " + studio.Get_price(calculator.Get_price(studio, initialPrice.Get_price_fromLandlord(studio))));
                    RealEstatePrices.GetLocationFrom(loc, studio);
                }

                else if (estate == "Land")
                {
                    var initialPrice = new LandInitPrice();
                    var calculator = new LandComissionCalculator();

                    Console.WriteLine("How many square meters?");
                    sqm = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose a cadastral number (543345/23214/61321)");
                    cad_nr = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose the usage(intravilan/extravilan)");
                    cond = Console.ReadLine();
                    Console.WriteLine(" ");

                    UrbanLand land = new UrbanLand(sqm, cad_nr, cond);
                    RealEstatePrices.GetInitialPriceFrom(land, initialPrice);
                    RealEstatePrices.GetComissionFrom(land, calculator, initialPrice);
                    RealEstatePrices.GetPriceFrom(land, calculator,initialPrice);
                    RealEstatePrices.GetLocationLandFrom(cad_nr, land);
                    // Console.WriteLine("(Price withouth fee:" + land.Get_price_fromLandlord(initialPrice.Get_price_fromLandlord(land)) + " , the poundage:" + land.Get_poundage(calculator.Get_poundage(land, initialPrice.Get_price_fromLandlord(land))) + ")" + "The total price of this house is: " + land.Get_price(calculator.Get_price(land, initialPrice.Get_price_fromLandlord(land))));

                }
                
                Console.WriteLine(" ");
                Console.WriteLine("Are you searching for something else?(yes/no)");
                answer = Console.ReadLine();
                if (answer != "yes") k = 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Thank you for choosing us! We hope you found what you were looking for! Have a good day!");
        }
        static void TestGoodPrice(Estate estate)
        {
            estate.Get_price_fromLandlord(new AssetsCalculator().Get_price_fromLandlord(estate));
            estate.Get_poundage(new AssetsCom().Get_poundage(estate, estate.Get_price_fromLandlord(new AssetsCalculator().Get_price_fromLandlord(estate))));
            estate.Get_price(new AssetsCom().Get_price(estate, estate.Get_poundage(new AssetsCom().Get_poundage(estate, estate.Get_price_fromLandlord(new AssetsCalculator().Get_price_fromLandlord(estate))))));
            if(estate.IPrice+estate.Comission==estate.Price){ Console.WriteLine("The calculus looks good! Everything is going as planned! Keep up the good work!"); }
            Console.WriteLine("{0}: {1}: {2}", estate.IPrice, estate.Comission, estate.Price);
        }
        /*static void Locations(Estate estate)
        {
            if(estate.location=="Center")
                Console.WriteLine("We have the next locations in the center of the city:"+ estate.IPrice, estate.Comission, estate.Price);
        }
        */
    }
}
