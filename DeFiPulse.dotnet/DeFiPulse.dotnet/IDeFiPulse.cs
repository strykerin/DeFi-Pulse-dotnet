using DeFiPulse.Entities;
using System.Collections.Generic;
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

        /// <summary>
        /// Returns current Total Value Locked (TVL) in each category and their dominant projects on DeFi Pulse.
        /// </summary>
        /// <returns></returns>
        Task<DeFiProjectsMarketOverview> GetDeFiProjectsMarketOverview();

        /// <summary>
        /// Returns historical Total Value Locked (TVL) for a given project over a given period of time.
        /// </summary>
        /// <param name="project">Project name. Corresponds to the slug of a project when clicking on it on defipulse.com. Example below</param>
        /// <param name="period">Time period 1w, 1m, 3m, 1y or all. The 1wperiod will return to hourly values, all other periods will return daily values. Default all.</param>
        /// <param name="format">Use csv to obtain data in CSV format instead of json. </param>
        /// <returns></returns>
        Task<List<HistoricalTLV>> GetHistory(string project = null, string period = null, string length = null, string resolution = null, string category = null);
    }
}
