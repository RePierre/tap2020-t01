using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    public class House : IProperty
    {
        public string Adress { get; set; }
        public decimal Price { get; set; }
        public decimal Commission { get; set; }

        public House()
        {
            this.Commission = 5 / 100m;
        }
    }
}
