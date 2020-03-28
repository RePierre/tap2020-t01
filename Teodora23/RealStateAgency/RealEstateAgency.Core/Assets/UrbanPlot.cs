using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAgency.Core.Assets.Base;

namespace RealEstateAgency.Core.Assets
{
    public class UrbanPlot : Plot
    {
        public UrbanPlot()
        {
            this.CommissionRate = 4m;
        }
    }
}
