using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    interface IProperty : IAsset
    {
        string Adress { get; }
    }
}
