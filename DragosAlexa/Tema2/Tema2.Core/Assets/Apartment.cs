using System;
using Uaic.Tema2.Core;


namespace Uaic.Tema2.Core.Assets
{
    public class Apartment : RealEstateAgency
    {
        public Apartment(decimal price, double surface, int yearBuilt, string address) : base(price, surface, yearBuilt, address) { }
    }
}

