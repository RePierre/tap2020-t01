using System;
using System.Collections.Generic;
using System.Text;
using Tema2.Core.Estates;

namespace Tema2.Core.Calculator
{
    public abstract class ComissionCalculator
    {
        public decimal CalculateFullPrice(Estate estate, decimal amount)
        {
            var comission = CalculateComission(amount);
            return amount + comission;
        }
        public abstract decimal CalculateComission(decimal amount);
        
    }
}
