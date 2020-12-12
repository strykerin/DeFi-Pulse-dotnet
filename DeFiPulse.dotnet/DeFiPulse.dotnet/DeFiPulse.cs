using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using DeFiPulse.Entities;
using System.Web;
using System.Collections.Specialized;
using System.Collections.Generic;
using DeFiPulse.Exceptions;

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
            return await _httpClient.GetFromJsonAsync<GasPrice>($"egs/api/ethgasAPI.json?api-key={_apiKey}");
        }

        public async Task<DeFiProjectsMarketOverview> GetDeFiProjectsMarketOverview()
        {
            return await _httpClient.GetFromJsonAsync<DeFiProjectsMarketOverview>($"defipulse/api/MarketData?api-key={_apiKey}");
        }

        public async Task<List<HistoricalTLV>> GetHistory(string project = null, string period = null, string length = null, 
                                                          string resolution = null, string category = null)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);
            if (!(project is null))
                query[$"{nameof(project)}"] = project;
            if (!(period is null))
                query[$"{nameof(period)}"] = period;
            if (!(length is null))
                query[$"{nameof(length)}"] = length;
            if (!(resolution is null))
                query[$"{nameof(resolution)}"] = resolution;
            if (!(category is null))
                query[$"{nameof(category)}"] = category;

            string queryString = query.ToString();
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<HistoricalTLV>>($"defipulse/api/GetHistory?api-key={_apiKey}&" + queryString);
                return result;
            }
            catch (System.Text.Json.JsonException ex)
            {
                throw new DeFiPulseException("Invalid method parameter", ex);
            }
        }
    }
}
