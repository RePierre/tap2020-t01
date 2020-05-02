using System;
using System.Collections.Generic;
using System.Text;
using Modules.Core.Assets;

namespace Land
{
    class RuralLand : Asset
    {
        public RuralLand(decimal price, decimal sm, string address) : base(sm, address) { }
    }
}