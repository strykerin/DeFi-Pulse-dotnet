using System.Text.Json.Serialization;

namespace DeFiPulse.Entities
{
    public class GasPrice
    {
        public decimal Fast { get; set; }

        public decimal Fastest { get; set; }

        public decimal SafeLow { get; set; }

        public decimal Average { get; set; }

        [JsonPropertyName("block_time")]
        public decimal BlockTime { get; set; }

        [JsonPropertyName("blockNum")]
        public decimal BlockNumber { get; set; }

        public decimal Speed { get; set; }

        [JsonPropertyName("safeLowWait")]
        public decimal SafeLowWait { get; set; }

        [JsonPropertyName("avgWait")]
        public decimal AverageWait { get; set; }

        public decimal FastWait { get; set; }

        public decimal FastestWait { get; set; }
    }
}
