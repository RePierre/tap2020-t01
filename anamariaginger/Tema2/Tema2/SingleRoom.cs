using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class SingleRoom: Estate
    {
        public SingleRoom( int sf, string location) : base( sf, location)
        { }
        public override decimal get_price()
        {
            if (sf < 1000)
                price += 167700m;
            if (sf > 1000 && sf < 2000)
                price += 200m;

            if (location == "here") price += 1090m;
            if (location == "suburbs") price += 5000m;

            return price;

        }
        public override decimal get_commision()
        {
            if (price < 1000m) return price * 0.2m;
            else if (price > 1000m && price < 2000m) return price * 0.35m;
            else if (price > 2000m) return price * 0.4m;
            return price;
        }
    }
}
