using System;
using System.Collections.Generic;
using System.Text;
using Tema2.Core.Estates;

namespace Tema2.Core.Prices
{
    public abstract class BasePrice: InitialPrice
    {
        public abstract decimal GetInitialPrice(Estate estate);
        public decimal GetBasePrice(Estate estate)
        {
            var price = GetInitialPrice(estate);
            return price;
        }
    }
}
