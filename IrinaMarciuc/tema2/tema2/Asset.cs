using System;
using System.Collections.Generic;
using System.Text;

namespace tema2
{
    public abstract class Asset : IAsset
    {
        public decimal price { get; protected set; }
        public string location { get; protected set; }
    }
}
