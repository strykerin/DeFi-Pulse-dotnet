using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DeFiPulse.Entities
{
    public class MarketOverview
    {
        public decimal Total { get; set; }

        [JsonPropertyName("dominance_name")]
        public string DominanceName { get; set; }

        [JsonPropertyName("dominance_value")]
        public decimal DominanceValue { get; set; }

        [JsonPropertyName("")]
        public decimal DominanceValue { get; set; }
    }
}
