﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    public class House : IProperty
    {
        public string Adress { get; protected set; }
        public decimal Price { get; protected set; }
        public decimal Commission { get; protected set; }

        public House()
        {
            this.Commission = 7 / 100m;
        }
    }
}
