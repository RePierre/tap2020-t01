using System;
using System.Collections.Generic;
using System.Text;
using Tema2.Core.Estates;

namespace Tema2.Core.Prices
{
    public interface InitialPrice
    {
        decimal GetInitialPrice(Estate estate);
    }
}
