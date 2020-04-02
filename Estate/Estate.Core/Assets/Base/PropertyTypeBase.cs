namespace Uaic.Estate.Core.Assets.Base
{
   public abstract class PropertyTypeBase : IPropertyTypeBase
    {
        public decimal InitialPrice { get; protected set; }
        public decimal AgentCommission { get; protected set; }
        public decimal TotalPrice { get; protected set; }
        public string Address { get; protected set; }
        public decimal CadastralNumber { get; protected set; }
    }

}
