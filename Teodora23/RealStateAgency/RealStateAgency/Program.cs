using System;
using RealEstateAgency.Core;

namespace RealStateAgency
{
    public class Program
    {
        static void Main(string[] args)
        {
            var commission = new Commission();
            var property = new House();
            property.Price = 100m;
            var sellingPrice = property.Price + commission.CalculateCommission(property);
            Console.WriteLine(sellingPrice);

        }
    }
}
