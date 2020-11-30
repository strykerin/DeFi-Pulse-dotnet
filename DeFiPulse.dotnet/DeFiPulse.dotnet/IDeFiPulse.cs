using DeFiPulse.Entities;
using System.Threading.Tasks;

namespace DeFiPulse
{
    public interface IDeFiPulse
    {
        /// <summary>
        /// Returns the current recommended fast, standard and safe low gas prices on the Ethereum network, along with the current block and wait times for each "speed".
        /// </summary>
        /// <returns></returns>
        Task<GasPrice> GetGasPriceAsync();
    }
}
