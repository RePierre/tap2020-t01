using System;
using RealEstateAgency.Core;

namespace RealStateAgency
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available Properties: \n\n" +
                 "1. Land \n" +
                 "2. House \n" +
                 "3. Apartment \n" +
                 "4. Single Room \n" +
                 "Choose Property Type: ");

            IAsset property;

            Console.WriteLine("Enter The Initial Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());


            switch{
                case 1:
                    property = new Apartment(price);
                    Commission commission = new Commission();
                    Console.WriteLine("The final price is " + price + commission.CalculateCommission(property) + " from which the applied commission is " + 
                        commission.CalculateCommission(property) + "."+" The adress is: " + property.Adress + ".");
                    break;
                
            }

        }
    }
}
