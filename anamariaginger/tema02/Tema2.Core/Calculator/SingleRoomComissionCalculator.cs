﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2.Core.Calculator
{
    class SingleRoomComissionCalculator : ComissionCalculator
    {
        public override decimal CalculateComission(decimal amount)
        {
            return amount*0.1m;
        }
    }
   
}
