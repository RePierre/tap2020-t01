﻿namespace Estate
{
    public class Studio_Flat : Estate
    {
        public Studio_Flat(decimal price, string adress) : base(price, adress) { }
        public override decimal get_commission()
        {
            return price * 0.1m + 1500m;
        }

    }
}
