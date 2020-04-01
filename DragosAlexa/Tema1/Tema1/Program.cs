using System;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args) {
            Studio studio = new Studio(25000m,20, 1985);
            Console.WriteLine("Studio price:" + studio.calculate_price() + " and commission: " + studio.calculate_commission());
            Apartment apartment = new Apartment(65000m,45, 1990);
            Console.WriteLine("Apartment price:" + apartment.calculate_price() + " and commission: " + apartment.calculate_commission());
            House house = new House(70000m, 70, 2014,3);
            Console.WriteLine("House price:" + house.calculate_price() + " and commission: " + house.calculate_commission());
            House house1 = new House(45000m, 50, 1975,1);
            Console.WriteLine("House price:" + house1.calculate_price() + " and commission: " + house1.calculate_commission());
        }
    }
}

