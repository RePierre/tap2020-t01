using System;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args) {
            Studio studio = new Studio(25000m,20, 1985,"Str.Salciilor,nr.2");
            Console.WriteLine("Studio price:{0} and commission:{1} Address of studio:{2} .",studio.calculate_price(),studio.calculate_commission(),studio.address);
            Apartment apartment = new Apartment(65000m,45, 1990, "Str.Vamesilor, nr.5");
            Console.WriteLine("Apartment price:" + apartment.calculate_price() + " and commission: " + apartment.calculate_commission());
            House house = new House(70000m, 70, 2014,"Str.Lalelelor, Horpaz",3);
            Console.WriteLine("House price:" + house.calculate_price() + " and commission: " + house.calculate_commission());
            House house1 = new House(45000m, 50, 1975,"Str. Alexandru Ioan Cuza, Valea Adanca",1);
            Console.WriteLine("House price:" + house1.calculate_price() + " and commission: " + house1.calculate_commission());
            Land land = new Land(40000m,"urban",1245, 1005000);
            Console.WriteLine("Land price:" + land.calculate_price() + " and commission: " + land.calculate_commission());
        }
    }
}

