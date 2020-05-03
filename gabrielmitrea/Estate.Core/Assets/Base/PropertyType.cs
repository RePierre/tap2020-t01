
namespace Uaic.Estate.Core.Assets.Base
{
    public abstract class PropertyType : PropertyTypeBase
    {
        public void Sell(string address,decimal initialPrice,decimal agentCommission,decimal totalPrice)
        {
            
            this.Address = address;
            this.InitialPrice = initialPrice;
            this.TotalPrice = totalPrice;
            this.AgentCommission = agentCommission;
        }
        public void Sellland(decimal cadastralNumber, decimal initialPrice, decimal agentCommission, decimal totalPrice)
        {
            this.CadastralNumber = cadastralNumber;
            this.InitialPrice = initialPrice;
            this.TotalPrice = totalPrice;
            this.AgentCommission = agentCommission;
        }
    }
}
