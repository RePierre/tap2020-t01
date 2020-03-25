using System;

namespace RealEstateAgency.Core
{
    public interface IAsset
    {
        decimal Price { get; }
        decimal Commission { get; }
    }
}
