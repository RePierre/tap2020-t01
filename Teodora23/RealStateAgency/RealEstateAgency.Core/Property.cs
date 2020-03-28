using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core
{
    public abstract class Property : IProperty
    {
        public string Address { get; set; }
        public decimal Price { get; set; }
        public decimal CommissionRate { get; set; }

        public string GetAssetAttribute()
        {
            return this.Address;
        }
        public void SetAssetAttribute(string attribute)
        {
            this.Address = attribute;
        }
    }
}
