using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using DeFiPulse.Entities;

namespace DeFiPulse
{
    public class DeFiPulse : IDeFiPulse
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public DeFiPulse(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        public async Task<GasPrice> GetGasPriceAsync()
        {
            var result =  await _httpClient.GetFromJsonAsync<GasPrice>($"egs/api/ethgasAPI.json?api-key={_apiKey}");
            return result;
        }
    }
}
