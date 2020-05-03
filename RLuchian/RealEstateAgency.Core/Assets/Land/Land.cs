namespace Uaic.RealEstateAgency.Core.Assets.Land
{
    public class Land:Assets {
        public string cadastralNumber;
        public Land(string CadastralNumber, decimal InitialPrice)
        {
            this.cadastralNumber = CadastralNumber;
            this.initialPrice = InitialPrice;
        }

    }
}
