using System;
namespace Uaic.Andreea523.Core.Assets.Base
{
    public class RealEstate : IRealEstate
    {

        public decimal Price { get; protected set; }
        public string Address { get; protected set; }
        public string Zone { get; protected set; }
    }
}
