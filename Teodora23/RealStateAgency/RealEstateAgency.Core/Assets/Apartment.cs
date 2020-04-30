using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAgency.Core.Assets.Base;

namespace RealEstateAgency.Core.Assets
{
    public class Apartment : Property
    {
        public Apartment()
        {
            this.CommissionRate = 3m;
        }
    }
}
