using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DeFiPulse.Entities
{
    public class DeFiProjectsMarketOverview
    {
        [JsonPropertyName("All")]
        public MarketOverview All { get; set; }

        [JsonPropertyName("Lending")]
        public MarketOverview Lending { get; set; }

        [JsonPropertyName("DEXes")]
        public MarketOverview Dexes { get; set; }

        [JsonPropertyName("Derivatives")]
        public MarketOverview Derivatives { get; set; }

        [JsonPropertyName("Payments")]
        public MarketOverview Payments { get; set; }

        [JsonPropertyName("Assets")]
        public MarketOverview Assets { get; set; }
    }
}
