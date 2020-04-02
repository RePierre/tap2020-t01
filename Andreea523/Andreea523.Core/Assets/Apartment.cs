using System;
using System.Collections.Generic;
using System.Text;
using Uaic.Andreea523.Core.Assets.Base;

namespace Uaic.Andreea523.Core.Assets
{
    public class Apartment : RealEstate
    {

        public Apartment(decimal priceRealEstate, string zone, string address)
        {
            this.Price = priceRealEstate;
            this.Zone = zone;
            this.Address = address;
        }

        //protected override decimal CalculationCommissionn(decimal price, string zone) => price * 2.5 / 100;

    }
}
