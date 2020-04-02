using System;
using System.Collections.Generic;
using System.Text;
using Tema2.Core.Estates;

namespace Tema2.Core.Prices
{
    class LandBasePrice : BasePrice
    {
        public override decimal GetInitialPrice(Estate estate)
        {
            decimal price = 0;
            if (estate.sf < 1000)
                price += 20000m;
            if (estate.sf > 1000 && estate.sf < 2000)
                price += 30500m;
            if (estate.sf > 2000)
                price += 40000m;

            if (estate.cadastral_nr ==400) price += 10000m;
            if (estate.cadastral_nr ==456) price += 500m;

            return price;
        }
    }
}
