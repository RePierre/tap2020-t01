using UAIC.RealEstateAgency.EstatesBase;

namespace UAIC.RealEstateAgency.Estates
{
    public class Apartment : EstateAgency
    {
        public Apartment(decimal base_price) : base("Apartment", base_price) { }
    }
}
