﻿using System;
using System.Collections.Generic;
using System.Text;
using Uaic.Andreea523.Core.Assets.Base;

namespace Uaic.Andreea523.Core.Assets
{
    public class SingleRoom : RealEstate
    {

        public SingleRoom(decimal priceRealEstate, string zone, string address)
        {
            this.Price = priceRealEstate;
            this.Zone = zone;
            this.Address = address;
        }
    }
}
