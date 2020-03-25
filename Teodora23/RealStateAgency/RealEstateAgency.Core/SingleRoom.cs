using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    class SingleRoom
    {
        public string Adress { get; protected set; }
        public decimal Price { get; protected set; }
        public decimal Commission { get; protected set; }

        public SingleRoom()
        {
            this.Commission = 3 / 100m;
        }
    }
}
