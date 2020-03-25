namespace UAIC.RealEstateAgency.EstatesBase
{
    public abstract class EstateAgency
    {
        private decimal base_price;
        public string type;

        protected EstateAgency(string type, decimal base_price)
        {
            this.type = type;
            this.base_price = base_price;
        }
        public decimal Base_price { get => base_price; private set { } }
    }












}
