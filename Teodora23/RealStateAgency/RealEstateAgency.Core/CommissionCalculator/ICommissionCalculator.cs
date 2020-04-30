using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Core.CommissionCalculator
{
    public interface ICommissionCalculator
    {
        decimal CalculateCommission(decimal amount, decimal commissionRate);
    }
}
