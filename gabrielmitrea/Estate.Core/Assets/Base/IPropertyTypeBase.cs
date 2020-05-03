namespace Uaic.Estate.Core.Assets.Base
{
    public interface IPropertyTypeBase
    {
        string Address { get; }
        decimal AgentCommission { get; }
        decimal CadastralNumber { get; }
        decimal InitialPrice { get; }
        decimal TotalPrice { get; }
    }
}