using System;

namespace Tema2
{
    public class House : RealEstateAgency
    {
        public House(decimal price,double surface, int yearBuilt,int floors,string address) : base(price, surface, yearBuilt,floors,address) {
        }
    }
}

