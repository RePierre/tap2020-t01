﻿using System;


namespace Imobile
{
    partial class Program
    {
        class RealEstatePrices
        {
            public static void GetInitialPriceFrom(Estate estate, InitialPrice initPrice)
            {
                var iPrice = initPrice.Get_price_fromLandlord(estate);
                Console.WriteLine("The initial price is " + estate.Get_price_fromLandlord(iPrice));
                // Console.WriteLine("{0}: {1}",estate.GetType().Name,estate.IPrice);
            }

           public static void GetComissionFrom(Estate estate, ComissionCalculator comission, InitialPrice initPrice)
            {
                var iPrice = initPrice.Get_price_fromLandlord(estate);
                var com = comission.Get_poundage(estate, estate.Get_price_fromLandlord(iPrice));
                Console.WriteLine("The poundage is: " + estate.Get_poundage(com));

            }

           public static void GetPriceFrom(Estate estate, ComissionCalculator calculator, InitialPrice initPrice)
            {

                var iPrice = initPrice.Get_price_fromLandlord(estate);
                var price = calculator.Get_price(estate, iPrice);
                Console.WriteLine("The total price is: " + estate.Get_price(price));
            }
        }
    }
}
