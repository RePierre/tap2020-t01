using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;

namespace Land
{
    class UrbanLand : Asset
    {
        public UrbanLand(decimal price, decimal sm, string address) : base(sm, address) { }
    }
}
