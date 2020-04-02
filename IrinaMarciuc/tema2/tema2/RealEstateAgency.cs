using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    public class RealEstateAgency : IRealEstateAgency
    {
        public void CalculatePricefor(Asset asset, decimal price, string location, CommissionCalculator commissionCalculator)
        {
            var commission = commissionCalculator.GetCommission();
            var totalAmount = commissionCalculator.CalculateCommission(asset, price);
            Console.WriteLine("{0}, {1}, {2}%, {3}\n", asset.GetType().Name, totalAmount, commission, location);
        }
    }
}
