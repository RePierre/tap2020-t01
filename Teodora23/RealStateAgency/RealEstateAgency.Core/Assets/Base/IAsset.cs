using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core.Assets.Base
{
    public interface IAsset
    {
        decimal Price { get; set; }
        decimal CommissionRate { get; set; }
        void SetAssetAttribute(string attribute);
        string GetAssetAttribute();
    }
}
