using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    public class Commission
    {   
        public decimal CommissionValue { get; set; }
        public decimal CalculateCommission(IAsset asset)
        {
            return asset.Price * asset.Commission;
        }
    }
}
