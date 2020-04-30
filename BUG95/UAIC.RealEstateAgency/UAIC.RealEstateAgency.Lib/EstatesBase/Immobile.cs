namespace UAIC.RealEstateAgency.EstatesBase
{
    public abstract class Immobile : EstateAgency
    {
        public string address;

        protected Immobile(string type, string address, decimal base_price) : base(type, base_price)
        {
            this.address = address;
        }
    }
}
