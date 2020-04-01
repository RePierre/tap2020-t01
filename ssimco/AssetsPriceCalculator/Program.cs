using System;
using Assets;
using Estate;
using Land;
namespace MainProgram
{
    class Program
    {
        static void print(Asset asset, string loc) {
            Console.WriteLine("Location: {0}",loc);
            Console.WriteLine("Price: {0}",asset.get_final_price());
            Console.WriteLine("Commission: {0}\n",asset.get_commission());
        }

        static void Main(string[] args)
        {
            UrbanLand land = new UrbanLand(40000m, "what is a cadastral number?");
            Flat flat = new Flat(34000m, "st. Street 2");
            House house = new House(100000m, "st. Street 4");
            print(land, land.cad_num);
            print(flat, flat.adress);
            print(house, house.adress); 
        }
    }
}
