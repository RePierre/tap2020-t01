using RealEstateAgency.Core.Assets;
using RealEstateAgency.Core.Assets.Base;
using RealEstateAgency.Core.CommissionCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    public class FrontDesk : IFrontDesk
    {
        public void CalculateSellingPrice(IAsset asset, ICommissionCalculator commissionCalculator)
        {
            decimal commission = commissionCalculator.CalculateCommission(asset.Price, asset.CommissionRate);

            decimal sellingPrice = asset.Price + commission;

            if (typeof(UrbanPlot).IsInstanceOfType(asset))
            {
                Console.WriteLine("\nThe selling price for the Asset with the Cadastral Reference '" + asset.GetAssetAttribute() +
                                  "' is " + sellingPrice + " RON. \n" + "The applied commission is " + commission + " RON.");
            }
            else
            {
                Console.WriteLine("\nThe selling price for the Asset with the address '" + asset.GetAssetAttribute() +
                                  "' is " + sellingPrice + " RON. \n" + "The applied commission is " + commission + " RON.");
            }
        }
    }
}
