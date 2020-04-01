namespace Estate
{
    public class Flat : Estate
    {
        public Flat(decimal price, string adress) : base(price, adress) { }
        public override decimal get_commission()
        {
            return price * 0.1m;
        }
    }
}
