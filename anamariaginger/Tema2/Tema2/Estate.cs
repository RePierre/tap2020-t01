using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    public abstract class Estate
    {
        protected decimal price;
        public string location;  //the location 
        public int sf; //square feet of the place

        public Estate(int price)
        {
            this.price = price;
        }
        public Estate( int sf, string location)
        {
            
            this.sf = sf;
            this.location = location;
        }
        public abstract decimal get_price();
        public abstract decimal get_commision();

    }
}
