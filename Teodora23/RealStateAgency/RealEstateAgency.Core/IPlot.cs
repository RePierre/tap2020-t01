using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    interface IPlot : IAsset
    {
        string CadastralReference { get; set; }
    }
}
