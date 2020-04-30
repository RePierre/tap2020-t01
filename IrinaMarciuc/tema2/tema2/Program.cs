using Uaic.tema2;
using Uaic.tema2.Core;
using Uaic.tema2.Core.Assets;
using Uaic.tema2.Core.Assets.Base;
using Uaic.tema2.Core.Calculators;
namespace tema2
{
    class Program
    {
        static void Main()
        {
            RealEstateAgency rea = new RealEstateAgency();

            Asset house = new House();
            var housecommission = new HouseCommissionCalculator();

            Asset apartment = new Apartment();
            var apartmentcommission = new ApartmentCommissionCalculator();

            Asset singleroom = new Singleroom();
            var singleroomcommission = new SingleroomCommissionCalculator();

            Asset field = new Field();
            var fieldcommission = new FieldCommissionCalculator();

            rea.CalculatePricefor(house, 130000m, "center", housecommission);
            rea.CalculatePricefor(apartment, 140000m, "periphery", apartmentcommission);
            rea.CalculatePricefor(singleroom, 13000m, "center", singleroomcommission);
            rea.CalculatePricefor(field, 150000m, "center", fieldcommission);


        }
    }
}
