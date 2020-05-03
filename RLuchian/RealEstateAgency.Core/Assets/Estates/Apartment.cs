using Uaic.RealEstateAgency.Core.Assets.Estates.Base;
namespace Uaic.RealEstateAgency.Core.Assets.Estates
{
    public class Apartment : Estate {
        public Apartment(string Address, decimal InitialPrice) : base(Address, InitialPrice) { }
    }
}
