using System;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args) {
            var commission=new CommissionCalculator();
            var totalPrice = new TotalPriceCalculator();
            Studio studio = new Studio(25000m,20, 1985,"Str.Salciilor,nr.2");
            Console.WriteLine("Studio price:{0} and commission:{1} Address of studio:{2} .",totalPrice.CalculateTotalPrice(studio,studio.price),commission.CalculateCommission(studio,studio.price) ,studio.address);
           Apartment apartment = new Apartment(65000m,45, 1990, "Str.Vamesilor, nr.5");
            Console.WriteLine("Apartment price:" + totalPrice.CalculateTotalPrice(apartment, apartment.price) + " and commission: " +commission.CalculateCommission(apartment,apartment.price));
            /*House house = new House(70000m, 70, 2014,3,"Str.Lalelelor, Horpaz");
            Console.WriteLine("House price:" + house.calculate_price() + " and commission: " + house.calculate_commission());*/
            House house1 = new House(45000m, 350, 1975,1,"Str. Alexandru Ioan Cuza, Valea Adanca");
            Console.WriteLine("House price:" +totalPrice.CalculateTotalPrice(house1,house1.price) + " and commission: " + commission.CalculateCommission(house1,house1.price));
            Land land = new Land(40000m,"URBAN",1245, 1005000);
            Console.WriteLine("Land price:" + totalPrice.CalculateTotalPrice(land,land.price) + " and commission: " + commission.CalculateCommission(land,land.price));
        }
    }
}


