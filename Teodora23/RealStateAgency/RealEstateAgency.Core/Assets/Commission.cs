using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAgency.Core.Assets.Base;

namespace RealEstateAgency.Core.Assets
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
