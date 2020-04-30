using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAgency.Core.Assets.Base;

namespace RealEstateAgency.Core.Assets
{
    public class SingleRoom : Property
    {
        public SingleRoom()
        {
            this.CommissionRate = 1.5m;
        }
    }
}
