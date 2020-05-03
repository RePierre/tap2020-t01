using Uaic.RealEstateAgency.Core.Assets.Estates.Base;
namespace Uaic.RealEstateAgency.Core.Assets.Estates
{
    public class House : Estate {
        public House(string Address, decimal InitialPrice) : base(Address, InitialPrice) { }
    }
}
