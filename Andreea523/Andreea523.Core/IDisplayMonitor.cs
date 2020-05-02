using Uaic.Andreea523.Core.Assets;
using Uaic.Andreea523.Core.Calculators;
using Uaic.Andreea523.Core.Assets.Base;
namespace Uaic.Andreea523.Core
{
    public interface IDisplayMonitor
    {
        void Message(IRealEstate realEstate, IFeeCalculator feeCalculator);
    }
}