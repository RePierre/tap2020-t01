namespace Land
{
    public class UrbanLand : Land
    {
        public UrbanLand(decimal price, string cad_num) : base(price, cad_num) { }
        public override decimal get_commission()
        {
            return price * 0.06m;
        }
    }
}
