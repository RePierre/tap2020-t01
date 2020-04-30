using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core.Assets.Base
{
    public abstract class Plot : IPlot
    {
        public string CadastralReference { get; set; }
        public decimal Price { get; set; }
        public decimal CommissionRate { get; set; }

        public string GetAssetAttribute()
        {
            return this.CadastralReference;
        }
        public void SetAssetAttribute(string attribute)
        {
            this.CadastralReference = attribute;
        }
    }
}
