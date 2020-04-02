using System;

namespace Uaic.Tema2.Core.Assets
{
    public class House : RealEstateAgency
    {
        public House(decimal price,double surface, int yearBuilt,int floors,string address) : base(price, surface, yearBuilt,floors,address) {
        }
    }
}

