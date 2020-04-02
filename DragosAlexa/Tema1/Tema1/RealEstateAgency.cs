namespace Tema2
{
    public abstract partial class RealEstateAgency {
        public decimal price;
        public int cadastral_number;
        public int yearBuilt;
        public string address;
        public double surface;
        public string type;
        public RealEstateAgency(decimal price,double surface, int yearBuilt,string address) {
            this.price = price;
            this.surface = surface;
            this.yearBuilt = yearBuilt;
            this.address = address;
        }

        public RealEstateAgency(decimal price,string type, int cadastral_number, double surface) {
            this.price = price;
            this.cadastral_number = cadastral_number;
            this.surface = surface;
            this.type = type;
        }
 
        public abstract decimal calculate_commission();
        public decimal calculate_price() {
            return price + calculate_commission();
        }
    }
}

