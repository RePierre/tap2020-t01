using System;


namespace Tema2
{
    partial class Program
    {
        class RealEstatePrice {
            
            public static void GetTotalPriceFrom(RealEstateAgency rea, decimal price, TotalPriceCalculator totalPriceCalculator)
            {
                var totalPrice = totalPriceCalculator.CalculateTotalPrice(rea, price);
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("The total price for " + rea.GetType().Name + " is: " + totalPrice+"€");
            }
            public static void GetCommissionFrom(RealEstateAgency rea, decimal price, CommissionCalculator commissionCalculator)
            {
                var commissionValue = commissionCalculator.CalculateCommission(rea, price);
                Console.WriteLine("The commission for " + rea.GetType().Name + " is " + commissionValue+ "€");
            }

        }

    }
}


