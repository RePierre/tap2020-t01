namespace Tema1
{
    public abstract class RealEstateAgency {
        public decimal price;
        public int yearBuilt;
        public int surface;
        
        public RealEstateAgency(decimal price,int surface, int yearBuilt) {
            this.price = price;
            this.surface = surface;
            this.yearBuilt = yearBuilt;
        }
        public abstract decimal calculate_commission();
        public decimal calculate_price() {
            return price + calculate_commission();
        }
    }
}

