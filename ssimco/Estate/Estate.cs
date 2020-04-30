using System;
using System.Collections.Generic;
using System.Text;

using Assets;
namespace Estate
{
    public abstract class Estate : Asset
    {
        public string adress { get; private set; }

        public Estate(decimal price, string adress) : base(price)
        {
            this.adress = adress;
        }
    }
}
