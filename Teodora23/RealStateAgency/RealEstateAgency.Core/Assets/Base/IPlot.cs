using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core.Assets.Base
{
    interface IPlot : IAsset
    {
        string CadastralReference { get; set; }
    }
}
