using System;
using System.Collections.Generic;
using System.Text;
using Tema2.Core.Estates;
using Tema2.Core.Calculator;

namespace Tema2.Core.Prices
{
    class Prices
    {
        public static void GetLocation(Estate estate, String location)
        {
            if (location == "center")
            {
                Console.WriteLine("The location is: Iasi, Piata Unirii");
            }
            if (location == "suburbs")
            {
                Console.WriteLine("The location is: Iasi, Str. Stramosilor");
            }
        }
        public static void GetLocationLand(Estate estate, int cadastral_nr)
        {
            if (cadastral_nr == 4578)
            {
                Console.WriteLine("The land is located in Iasi");
            }
            if (cadastral_nr == 3463)
            {
                Console.WriteLine("The land is located in Vaslui");
            }
            if (cadastral_nr == 2098)
            {
                Console.WriteLine("The land is located in Galati");
            }
        }
        public static void GetInitialPrice(Estate estate, InitialPrice price)
        {
            var initPrice = price.GetInitialPrice(estate);

            Console.WriteLine("The initial price is: " + initPrice);
           
        }

        public static void GetComission(Estate estate, ComissionCalculator calculator, InitialPrice price)
        {
            var initPrice = price.GetInitialPrice(estate);
            var comission = calculator.CalculateComission(initPrice);

            Console.WriteLine("Our comission will be:" + comission);
        }
        public static void GetPrice(Estate estate, ComissionCalculator calculator, InitialPrice price)
        {
            var initPrice = price.GetInitialPrice(estate);
            var finalPrice = calculator.CalculateFullPrice(estate, initPrice);
            Console.WriteLine("The final price will be: " + finalPrice);
        }
    }
}
