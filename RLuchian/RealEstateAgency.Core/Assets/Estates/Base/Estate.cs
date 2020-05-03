namespace Uaic.RealEstateAgency.Core.Assets.Estates.Base
{
    public class Estate:Assets {
        public string address;
        public Estate(string Address, decimal InitialPrice)
        {
            this.address = Address;
            this.initialPrice = InitialPrice;
        }
    }
}
