using System;
namespace tema1
{
    class Program
    {

        static void Main()
        {
            RealEstate House = new House();
            RealEstate Apartment = new Apartment();
            RealEstate Singleroom = new Singleroom();

            String p = "periphery";
            String c = "center";

            decimal housecommission = House.CalculateCommission(19000, p);
            decimal apartmentcommission = Apartment.CalculateCommission(21000, c);
            decimal singleroomcommission = Singleroom.CalculateCommission(40000, c);

            Console.WriteLine("Type: house, Location: {0}, commission: {1}%, selling price: {2}\n", p, housecommission, House.CalculateSellingPrice(19000, p));
            Console.WriteLine("Type: apartment, Location: {0}, commission: {1}%, selling price: {2}\n", c, apartmentcommission, Apartment.CalculateSellingPrice(21000, c));
            Console.WriteLine("Type: singleroom, Location: {0}, commission: {1}%, selling price: {2}\n", c, singleroomcommission, Singleroom.CalculateSellingPrice(40000, c));

        }
    }
}
