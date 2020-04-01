using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class House : Estate
    {
        public House( int sf, string location) : base(sf, location)
        { }
        public override decimal get_price()
        {
            if (sf < 1000)
                price += 100000m;
            if (sf > 1000 && sf < 2000)
                price += 200000m;
            if (sf > 2000)
                price += 300000m;

            if (location == "center") price += 100000m;
            if (location == "suburbs") price += 5000m;

           return price;

        }
        public override decimal get_commision()
        {
            if (price < 1000m) return price * 0.02m;
            else if (price > 1000m && price < 2000m) return price * 0.03m;
            else if (price > 2000m) return price * 0.04m;
            return price;
        }
    }
}
