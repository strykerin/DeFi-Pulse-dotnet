using System.Text.Json.Serialization;

namespace DeFiPulse.Entities
{
    /// <summary>
    /// Note: To convert the provided values to gwei, divide by 10
    /// </summary>
    public class GasPrice
    {
        /// <summary>
        /// Recommended fast(expected to be mined in < 2 minutes) gas price in x10 Gwei(divite by 10 to convert it to gwei)
        /// </summary>
        public decimal Fast { get; set; }

        /// <summary>
        /// Recommended fastest(expected to be mined in < 30 seconds) gas price in x10 Gwei(divite by 10 to convert it to gwei)
        /// </summary>
        public decimal Fastest { get; set; }

        /// <summary>
        /// Recommended safe(expected to be mined in < 30 minutes) gas price in x10 Gwei(divite by 10 to convert it to gwei)
        /// </summary>
        public decimal SafeLow { get; set; }

        /// <summary>
        /// Recommended average(expected to be mined in < 5 minutes) gas price in x10 Gwei(divite by 10 to convert it to gwei)
        /// </summary>
        public decimal Average { get; set; }

        /// <summary>
        /// Average time(in seconds) to mine one single block
        /// </summary>
        [JsonPropertyName("block_time")]
        public decimal BlockTime { get; set; }

        /// <summary>
        /// Latest block number
        /// </summary>
        [JsonPropertyName("blockNum")]
        public decimal BlockNumber { get; set; }

        /// <summary>
        /// Smallest value of (gasUsed / gaslimit) from last 10 blocks
        /// </summary>
        public decimal Speed { get; set; }

        /// <summary>
        /// Waiting time(in minutes) for safeLow gas price
        /// </summary>
        [JsonPropertyName("safeLowWait")]
        public decimal SafeLowWait { get; set; }

        /// <summary>
        /// Waiting time(in minutes) for average gas price
        /// </summary>
        [JsonPropertyName("avgWait")]
        public decimal AverageWait { get; set; }

        /// <summary>
        /// Waiting time(in minutes) for fast gas price
        /// </summary>
        public decimal FastWait { get; set; }

        /// <summary>
        /// Waiting time(in minutes) for fastest gas price
        /// </summary>
        public decimal FastestWait { get; set; }
    }
}
