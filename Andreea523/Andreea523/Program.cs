using System;
using System.Collections.Generic;
using System.Text;
using Uaic.Andreea523;
using Uaic.Andreea523.Core;
using Uaic.Andreea523.Core.Assets;
using Uaic.Andreea523.Core.Calculators;
using Uaic.Andreea523.Core.Assets.Base;

namespace Andreea523
{
    class Program
    {
        static private string realEstate, address, zone, answer;


        static private decimal priceRealEstate;


        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************Real Estate Calculator**********************************************\n");
            //Console.WriteLine("");
            Console.Write("The price in euro for the real estate is: ");

            priceRealEstate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("The zone is (central, periphery): ");
            answer = (Console.ReadLine()).ToLower();
            switch (answer)
            {
                case "central":
                    zone = answer; break;
                case "periphery":
                    zone = answer; break;
                default:
                    Console.WriteLine("Invalid value!");
                    break;
            }


            IDisplayMonitor dsp = new DisplayMonitor();
            Console.WriteLine("Choose for what type of real estate you need to calculate the commission (single room, apartment, house, parcel): ");
            realEstate = Console.ReadLine().ToLower();
            switch (realEstate)
            {
                case "single room":
                    Console.Write("The address is: ");
                    address = Console.ReadLine();

                    FeeCalculator singleRoomCalculator = new SingleRoomFeeCalculator();
                    IRealEstate room = new SingleRoom(priceRealEstate, zone, address);
                    dsp.Message(room, singleRoomCalculator);

                    break;
                case "apartment":
                    Console.Write("The address is: ");
                    address = Console.ReadLine();

                    var apartmentCalculator = new ApartmentFeeCalculator();
                    IRealEstate apartment = new Apartment(priceRealEstate, zone, address);
                    dsp.Message(apartment, apartmentCalculator);
                    break;
                case "house":
                    Console.Write("The address is: ");
                    address = Console.ReadLine();

                    IRealEstate house = new House(priceRealEstate, zone, address);
                    var houseCalculator = new HouseFeeCalculator();
                    dsp.Message(house, houseCalculator);
                    break;

                case "parcel":
                    Console.Write("The cadastral number is: ");
                    address = Console.ReadLine();
                   
                    var parcelCalculator = new ParcelFeeCalculator();
                    IRealEstate parcel = new Parcel(priceRealEstate, zone, address);
                    dsp.Message(parcel, parcelCalculator);
             
                    TestParcel();
                    break;

                default:
                    Console.WriteLine("You must to choose one of the single room, apartment, hose or parcel!");
                    break;

            }
        }

        static void TestParcel()
        {
            Console.WriteLine("This is an verification test for parcel to see if the values corresponds!");
            var dsp = new DisplayMonitor();
            Console.Write("The price in euro for the parcel is: ");

            priceRealEstate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("The zone is (central, periphery): ");
            zone = Console.ReadLine();
            Console.Write("The cadastral number is: ");
            address = Console.ReadLine();

            var realEstate = new Parcel(priceRealEstate, zone,address);
            dsp.Message(realEstate, new DummyCalculator());
        }
    }

   class DummyCalculator : IFeeCalculator
    {
        public decimal CalculTotal(decimal price, string zone)
        {
            return price + CalculateCommissionn(price, zone);
        }
        public decimal CalculateCommissionn(decimal price, string zone)
        {

            if (zone == "central")
                return price * 2.5m / 100;
            else if (zone == "periphery")
                return price * 2.1m / 100;
            throw new InvalidOperationException("You didn't choose one of that value!");
        }
        public decimal returnCommissionn(decimal price, string zone)
        {
            return CalculateCommissionn(price, zone);
        }

    }
}