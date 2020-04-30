namespace Estate
{
    public class House : Estate
    {
        public House(decimal price, string adress) : base(price, adress) { }
        public override decimal get_commission()
        {
            if (price < 250000m)
                return price * 0.05m;
            else if (price < 500000m)
                return price * 0.08m;
            else return price * 0.1m;
        }

    }
}
