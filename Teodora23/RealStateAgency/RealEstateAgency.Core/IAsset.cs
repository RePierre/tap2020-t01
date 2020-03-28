using System;

namespace RealEstateAgency.Core
{
    public interface IAsset
    {
        decimal Price { get; set; }
        decimal CommissionRate { get; set; }
        void SetAssetAttribute(string attribute);
        string GetAssetAttribute();
    }
}
