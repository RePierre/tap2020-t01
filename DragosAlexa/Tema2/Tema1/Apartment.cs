using System;

namespace Tema2
{
    public class Apartment : RealEstateAgency
    {
        public Apartment(decimal price, double surface, int yearBuilt, string address) : base(price, surface, yearBuilt, address) { }
    }
}

