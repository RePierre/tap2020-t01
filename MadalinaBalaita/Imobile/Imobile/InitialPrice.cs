﻿using System;

namespace Imobile
{
    abstract class InitialPrice
    { 
        
        protected abstract decimal GetInitPrice(Estate estate);
        public decimal Get_price_fromLandlord(Estate estate)
        {
            var price = GetInitPrice(estate);
            return price;
        }

     
      

    }
}