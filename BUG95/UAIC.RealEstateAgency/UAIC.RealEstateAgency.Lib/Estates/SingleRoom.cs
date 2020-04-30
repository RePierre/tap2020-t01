using UAIC.RealEstateAgency.EstatesBase;

namespace UAIC.RealEstateAgency.Estates
{
    public class SingleRoom : EstateAgency
    {
        public SingleRoom(decimal base_price) : base("Single Room", base_price) { }
    }
}
