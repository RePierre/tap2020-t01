namespace Uaic.RealEstateAgency.Core.Calculators
{

    public abstract class CommisionCalculator {
        public decimal SellingPriceCalculator(decimal initialPrice) {
            var commision = AgentCommisionCalculator(initialPrice);
            return initialPrice + commision;
        }

        public abstract decimal AgentCommisionCalculator(decimal initialPrice);
    }
}
