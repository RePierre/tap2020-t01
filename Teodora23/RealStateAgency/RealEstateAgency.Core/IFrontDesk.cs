using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAgency.Core.Assets.Base;
using RealEstateAgency.Core.CommissionCalculator;

namespace RealEstateAgency.Core
{
    public interface IFrontDesk
    {
        void CalculateSellingPrice(IAsset asset, ICommissionCalculator commissionCalculator);
    }
}
