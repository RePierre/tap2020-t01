using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    class Apartment : IProperty
    {
        public string Adress { get; protected set; }
        public decimal Price { get; protected set; }
        public decimal Commission { get; protected set; }

        public Apartment()
        {
            this.Commission = 5 / 100m;
        }
    }
}
