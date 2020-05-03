using System;
using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
using Imobile.Core.Calculators.Comissioncalc;

namespace Imobile.Core.Calculators
{

    public class RealEstatePrices
        {
            public static void GetInitialPriceFrom(Estate estate, IInitialPrice initPrice)
            {
                var iPrice = initPrice.Get_price_fromLandlord(estate);
              
            // Console.WriteLine("{0}: {1}",estate.GetType().Name,estate.IPrice);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The initial price is " + estate.Get_price_fromLandlord(iPrice) +"€");
            

        }

           public static void GetComissionFrom(Estate estate, IComissionCalculator comission, IInitialPrice initPrice)
            {
                var iPrice = initPrice.Get_price_fromLandlord(estate);
                var com = comission.Get_poundage(estate, estate.Get_price_fromLandlord(iPrice));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The poundage is " + estate.Get_poundage(com) + "€");
        }

           public static void GetPriceFrom(Estate estate, IComissionCalculator calculator, IInitialPrice initPrice)
            {

                var iPrice = initPrice.Get_price_fromLandlord(estate);
                var price = calculator.Get_price(estate, iPrice);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The total price is " + estate.Get_price(price)+"€");

        }
        public static void GetLocationFrom(String location,Estate estate)
        {
            if (location=="center")
            {
                Console.WriteLine("We have the next New York's streets address for the available " + estate.GetType().Name + "s: " + "Wall Street, Houston Street, Maiden Lane.");

            }
            else if(location=="somewhere ok")
            {
                Console.WriteLine("We have the next New York's streets address for the available " + estate.GetType().Name + "s: " + "Fulton Street ,Lafayette Street, Lenox Avenue.");
            }
            else if (location == "suburbs")
            {
                Console.WriteLine("We have the next New York's streets address for the available " + estate.GetType().Name + "s: " + "Upper Montclair, Kensington, Great Neck Gardens.");
            }


        }
        public static void GetInitialPriceFrom(Assets asset, IInitialPrice initPrice)
        {
            var iPrice = initPrice.Get_price_fromLandlord(asset);

            // Console.WriteLine("{0}: {1}",estate.GetType().Name,estate.IPrice);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The initial price is " + asset.Get_price_fromLandlord(iPrice) + "€");


        }

        public static void GetComissionFrom(Assets asset, IComissionCalculator comission, IInitialPrice initPrice)
        {
            var iPrice = initPrice.Get_price_fromLandlord(asset);
            var com = comission.Get_poundage(asset, asset.Get_price_fromLandlord(iPrice));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The poundage is " + asset.Get_poundage(com) + "€");
        }

        public static void GetPriceFrom(Assets asset, IComissionCalculator calculator, IInitialPrice initPrice)
        {

            var iPrice = initPrice.Get_price_fromLandlord(asset);
            var price = calculator.Get_price(asset, iPrice);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The total price is " + asset.Get_price(price) + "€");

        }
    
        public static void GetLocationLandFrom(int cadastral_nr, Assets asset)
        {
          
            if (cadastral_nr == 543345)
            {
                Console.WriteLine("The land with the cadastral number "+cadastral_nr+ " is situated in NYC - Bronx" );

            }
            else if (cadastral_nr == 23214)
            {
                Console.WriteLine("The land with the cadastral number " + cadastral_nr + " is situated in Chautauqua");

            }
            else if (cadastral_nr == 61321)
            {
                Console.WriteLine("The land with the cadastral number " + cadastral_nr + " is situated in Ontario");

            }


        }
    }
}
