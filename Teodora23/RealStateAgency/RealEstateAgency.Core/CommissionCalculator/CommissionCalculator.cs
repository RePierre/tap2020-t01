using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core.CommissionCalculator
{
    public class CommissionCalculator : ICommissionCalculator
    {
        public decimal CalculateCommission(decimal amount, decimal commissionRate)
        {
            return amount * commissionRate / 100m;
        }
    }
}
