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

        public Value Value { get; set; }

        [JsonPropertyName("dominance_pct")]
        public decimal DominancePercentage { get; set; }
    }

    public class Value
    {
        public Total Total { get; set; }
        public Balance Balance { get; set; }
        [JsonPropertyName("tvl")]
        public Total TVL { get; set; }
    }

    public class Balance
    {
        [JsonPropertyName("ERC20")]
        public Total ERC20 { get; set; }
    }

    public class Total
    {
        [JsonPropertyName("USD")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Currency USD { get; set; }
        [JsonPropertyName("ETH")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Currency ETH { get; set; }
        [JsonPropertyName("BTC")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Currency BTC { get; set; }
        [JsonPropertyName("DAI")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Currency DAI { get; set; }
    }

    public class Currency
    {
        public decimal Value { get; set; }
    }
}
