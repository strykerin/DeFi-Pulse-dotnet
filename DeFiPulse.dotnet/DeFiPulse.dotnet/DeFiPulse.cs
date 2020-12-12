using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using DeFiPulse.Entities;
using System.Web;
using System.Collections.Specialized;
using System.Collections.Generic;

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

        public async Task<List<HistoricalTLV>> GetHistory(string project = null, string period = null, string format = null)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);
            if (!(project is null))
                query[$"{nameof(project)}"] = project;
            if (!(period is null))
                query[$"{nameof(period)}"] = period;
            if (!(format is null))
                query[$"{nameof(format)}"] = format;

            string queryString = query.ToString();
            return await _httpClient.GetFromJsonAsync<List<HistoricalTLV>>($"defipulse/api/GetHistory?api-key={_apiKey}" + queryString);
        }
    }
}
