using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2.Core.Estates
{
    public abstract class Assets
    {
        //string Location { get; set; }
        public decimal Price { get;  set; }
        public decimal Comission { get; set; }
        public decimal Get_Price(decimal price)
        {
            Price = price;
            return Price;
        }
        public decimal Get_Comission(decimal comission)
        {
            Comission = comission;
            return Comission;
        }

    }
}
