namespace UAIC.RealEstateAgency.EstatesBase
{
    public class Lot : EstateAgency
    {
        public int cadastralNumber;

        public Lot(int cadastralNumber, decimal base_price) : base("Lot", base_price)
        {
            this.cadastralNumber = cadastralNumber;
        }
    }












}
