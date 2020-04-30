using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAgency.Core.Assets.Base;

namespace RealEstateAgency.Core.Assets
{
    public class House : Property
    {
        public House()
        {
            this.CommissionRate = 3m;
        }
    }
}
