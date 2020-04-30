using System;
using RealEstateAgency.Core;
using RealEstateAgency.Core.Assets;
using RealEstateAgency.Core.Assets.Base;
using RealEstateAgency.Core.CommissionCalculator;

namespace RealEstateAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            IFrontDesk frontDesk = new FrontDesk();
            var commissionCalculator = new CommissionCalculator();

            Console.WriteLine("Select asset type: \n" +
                "1. House; \n" +
                "2. Apartment; \n" +
                "3. Single Room; \n" +
                "4. Urban Plot. \n");

            var assetType = Console.ReadLine();

            IAsset asset;
            switch (assetType)
            {
                case "1":
                    asset = new House();
                    Console.WriteLine("Insert the address of the House: ");
                    asset.SetAssetAttribute(Console.ReadLine());
                    Console.WriteLine("\nInsert the desired price: ");
                    asset.Price = Convert.ToDecimal(Console.ReadLine());
                    frontDesk.CalculateSellingPrice(asset, commissionCalculator);
                    break;
                case "2":
                    asset = new Apartment();
                    Console.WriteLine("Insert the address of the Apartment: ");
                    asset.SetAssetAttribute(Console.ReadLine());
                    Console.WriteLine("\nInsert the desired price: ");
                    asset.Price = Convert.ToDecimal(Console.ReadLine());
                    frontDesk.CalculateSellingPrice(asset, commissionCalculator);
                    break;
                case "3":
                    asset = new SingleRoom();
                    Console.WriteLine("Insert the address of the Single Room: ");
                    asset.SetAssetAttribute(Console.ReadLine());
                    Console.WriteLine("\nInsert the desired price: ");
                    asset.Price = Convert.ToDecimal(Console.ReadLine());
                    frontDesk.CalculateSellingPrice(asset, commissionCalculator);
                    break;
                case "4":
                    asset = new UrbanPlot();
                    Console.WriteLine("Insert the Cadastral Reference of the Urban Plot: ");
                    asset.SetAssetAttribute(Console.ReadLine());
                    Console.WriteLine("\nInsert the desired price: ");
                    asset.Price = Convert.ToDecimal(Console.ReadLine());
                    frontDesk.CalculateSellingPrice(asset, commissionCalculator);
                    break;
                default:
                    break;
            }
        }
    }
}
