using System;

namespace RealEstateAgency.Core
{
    public interface IAsset
    {
        decimal Price { get; set; }
        decimal Commission { get; set; }
    }
}
