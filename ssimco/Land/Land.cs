using Assets;
namespace Land
{
    public abstract class Land : Asset
    {
        public Land(decimal price, string cad_num) : base(price)
        {
            this.cad_num = cad_num;
        }
        public string cad_num { get; private set; }
        public decimal area { get; private set; }

    }
}
