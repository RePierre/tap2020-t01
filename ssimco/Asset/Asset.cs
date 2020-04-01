using System;
using System.Collections.Generic;
using System.Text;

namespace Assets
{
    public abstract class Asset
    {
        public decimal price { get; protected set; }
        public Asset(decimal price)
        {

            this.price = price;
        }
        public abstract decimal get_commission();
        public decimal get_final_price()
        {
            return price + get_commission();
        }
    }
}

