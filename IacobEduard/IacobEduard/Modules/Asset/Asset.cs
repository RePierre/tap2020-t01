using System;
using System.Collections.Generic;
using System.Text;
using System.Device.Location;
using Modules.Core.Calculator;

namespace Modules.Core.Assets
{
    public abstract class Asset
    {
        public decimal Price { get; set; }
        public decimal SM { get; set; }
        public decimal Comission { get; set; }
        public string Address { get; set; }
        private string[] Location { get; set; }

        public Asset( decimal sm, string address)
        {
            this.SM = sm;
            this.Address = address;
        }

        public decimal GetComission(decimal comission)
        {
            this.Comission = comission;
            return Comission;
        }

        public decimal GetPrice(decimal price)
        {
            this.Price = price;
            return Price;
        }

        public void SetLocatie(string[] value) { this.Location = value; }

        public double getDistance(GeoCoordinate sCoord, GeoCoordinate eCoord)
        {
            return sCoord.GetDistanceTo(eCoord);
        }

        public string[] GetLocatie(string[] location)
        {
            this.Location = location;
            return Location;
        }
    }
}
