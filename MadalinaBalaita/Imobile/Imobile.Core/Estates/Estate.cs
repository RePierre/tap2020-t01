 using Imobile.Core.Calculators;
namespace Imobile.Core.Estates
{
    public abstract class Estate :Assets
    {




        public  string Get_location()
        {   
            return location;
        }
      
        //constructor for buildings: Flats,studios,houses
        public Estate( double sm,string location,string condition):base(sm,location,condition)
        {
            

        }
        
       
  

    } 
}
