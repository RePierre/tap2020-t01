using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    class Land : IAsset
    {
        public string CadastralReference { get; set; }
        public decimal Price { get; set; }
        public decimal Commission { get; set; }

        public Land()
        {
            this.Commission = 5 / 100m;
        }
    }
}
