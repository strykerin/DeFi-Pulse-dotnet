using System.Text.Json.Serialization;

namespace DeFiPulse.Entities
{
    public class HistoricalTLV
    {
        public long Timestamp { get; set; }

        [JsonPropertyName("tvlUSD")]
        public decimal TVLUSD { get; set; }

        [JsonPropertyName("tvlETH")]
        public decimal TVLETH { get; set; }

        [JsonPropertyName("ETH")]
        public decimal ETH { get; set; }

        [JsonPropertyName("DAI")]
        public decimal DAI { get; set; }
    }
}
