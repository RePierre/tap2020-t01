
using System;
namespace tema1
{
    public abstract class RealEstate
    {
        protected decimal Amount { get; set; }
        protected String Location { get; set; }

        public abstract decimal CalculateCommission(decimal amount, String location);

        public decimal CalculateSellingPrice(decimal amount, String location)
        {
            return amount + amount * CalculateCommission(amount, location) / 100;
        }

    }
}

