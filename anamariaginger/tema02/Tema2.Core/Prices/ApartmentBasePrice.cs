using System;
using System.Collections.Generic;
using System.Text;
using Tema2.Core.Estates;

namespace Tema2.Core.Prices
{
    class ApartmentBasePrice : BasePrice
    {
        public override decimal GetInitialPrice(Estate estate)
        {
            decimal price = 0;
            if (estate.sf < 1000)
                price += 60000m;
            if (estate.sf > 1000 && estate.sf < 2000)
                price += 76000m;
            if (estate.sf > 2000)
                price += 80000m;

            if (estate.location == "center") price += 10000m;
            if (estate.location == "suburbs") price += 500m;

            return price;
        }
    }
}
