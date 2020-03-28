using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    public interface IProperty : IAsset
    {
        string Address { get; set; }
    }
}
