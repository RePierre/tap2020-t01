using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core.Assets.Base
{
    public interface IProperty : IAsset
    {
        string Address { get; set; }
    }
}
