using DeFiPulse.Entities;
using System.Threading.Tasks;

namespace DeFiPulse
{
    public interface IDeFiPulse
    {
        Task<GasPrice> GetGasPriceAsync();
    }
}
