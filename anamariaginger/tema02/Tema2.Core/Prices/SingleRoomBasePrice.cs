using System;
using System.Collections.Generic;
using System.Text;
using Tema2.Core.Estates;

namespace Tema2.Core.Prices
{
    public class SingleRoomBasePrice : BasePrice
    {
        public override decimal GetInitialPrice(Estate estate)
        {
            decimal price = 0;
            if (estate.sf < 1000)
                price += 9000m;
            if (estate.sf > 1000 && estate.sf < 2000)
                price += 10000m;
            if (estate.sf > 2000)
                price += 15000m;

            if (estate.location == "center") price += 1000m;
            if (estate.location == "suburbs") price += 500m;

            return price;
        }
    }
}
