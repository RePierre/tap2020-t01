using System;
using Uaic.tema2.Core.Assets.Base;
using Uaic.tema2.Core.Calculators;

namespace Uaic.tema2.Core
{
    public class RealEstateAgency : IRealEstateAgency
    {
        public void CalculatePricefor(Asset asset, decimal price, string location, CommissionCalculator commissionCalculator)
        {
            var commission = commissionCalculator.GetCommission();
            var totalAmount = commissionCalculator.CalculateCommission(asset, price);
            Console.WriteLine("Asset type: {0}, final price: {1}, commission: {2}%, location/number: {3}\n", asset.GetType().Name, totalAmount, commission, location);
        }
    }
}
