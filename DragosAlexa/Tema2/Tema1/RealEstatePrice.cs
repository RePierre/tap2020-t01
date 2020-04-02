using System;
using Uaic.Tema2.Core.Assets;
using Uaic.Tema2.Core.Calculators;

namespace Tema2
{
    partial class Program
    {
        class RealEstatePrice {
            
            public static void GetTotalPriceFrom(RealEstateAgency rea, decimal price, ITotalPriceCalculator totalPriceCalculator)
            {
                var totalPrice = totalPriceCalculator.CalculateTotalPrice(rea, price);
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("The total price for " + rea.GetType().Name + " is: " + totalPrice+"€");
            }
            public static void GetCommissionFrom(RealEstateAgency rea, decimal price, ICommissionCalculator commissionCalculator)
            {
                var commissionValue = commissionCalculator.CalculateCommission(rea, price);
                Console.WriteLine("The commission for " + rea.GetType().Name + " is " + commissionValue+ "€");
            }

        }

    }
}


