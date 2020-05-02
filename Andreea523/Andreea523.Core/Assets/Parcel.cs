namespace Uaic.Andreea523.Core.Assets
{
    using Uaic.Andreea523.Core.Assets.Base;

    public class Parcel : RealEstate
    {
        public Parcel()
        {
        }

        public Parcel(decimal priceRealEstate, string zone, string address)
        {
            this.Price = priceRealEstate;
            this.Zone = zone;
            this.Address = address;
        }
    }
}