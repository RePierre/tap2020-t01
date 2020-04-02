using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2.Core.Estates
{
    public abstract class Estate: Assets
    {
        
        public string location;  //the location 
        public int sf; //square feet of the place
        public int cadastral_nr;

        public string Get_location()
        {
            return location;
        }
        public int Get_cadastral_nr() 
        {
            return cadastral_nr;
        }
        public Estate( int sf, string location)
        {
            
            this.sf = sf;
            this.location = location;
        }
        public Estate(int sf, int cadastral_nr) 
        {
            this.sf = sf;
            this.cadastral_nr = cadastral_nr;
        }
        

    }
}
