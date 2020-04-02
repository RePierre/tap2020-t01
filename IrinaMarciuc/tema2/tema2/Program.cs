using System;

namespace tema2
{
    class Program
    {
        static void Main()
        {
            RealEstateAgency rea = new RealEstateAgency();
            Asset house = new House();
            var housecommission = new HouseCommissionCalculator();

            rea.CalculatePricefor(house, 130000m, "center", housecommission);

        }
    }
}
