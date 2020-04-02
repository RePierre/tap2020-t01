using System;
using System.Collections.Generic;
using System.Text;
using Uaic.Andreea523.Core.Assets;
using Uaic.Andreea523.Core.Calculators;
using Uaic.Andreea523.Core.Assets.Base;

namespace Uaic.Andreea523.Core
{
    public class DisplayMonitor : IDisplayMonitor
    {
        public void Message(IRealEstate realEstate, IFeeCalculator feeCalculator)
        {
            var totalCost = feeCalculator.CalculTotal(realEstate.Price, realEstate.Zone);
            var commissionn = feeCalculator.returnCommissionn(realEstate.Price, realEstate.Zone);
            Console.WriteLine();
            Console.WriteLine("******************************************************************************************************************");
            Console.WriteLine(" The price for a/an {0}, before applying the commission is {1} euro.", realEstate.GetType().Name, realEstate.Price);
            if (realEstate.GetType().Name != "Parcel")
                Console.WriteLine(" The address is: {0}, in the {1} zone.", realEstate.Address, realEstate.Zone);
            else Console.WriteLine(" The cadastral number is: {0}, in the {1} zone.", realEstate.Address, realEstate.Zone);
            Console.WriteLine(" The price with commissionn is {0} euro and the commissionn is {1} euro.", totalCost, commissionn);
            Console.WriteLine("******************************************************************************************************************");

        }

    }
}
