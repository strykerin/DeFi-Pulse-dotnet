using DeFiPulse.Parameters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace DeFiPulse.Extensions
{
    public static class DeFiPulseExtension
    {
        public static void AddDeFiPulse(this IServiceCollection services, string apiKey)
        {
            services.AddHttpClient("DeFiPulse", c => c.BaseAddress = new Uri(DeFiPulseParameters.BaseAddress));
            services.AddScoped<IDeFiPulse>(ctx =>
            {
                var clientFactory = ctx.GetRequiredService<IHttpClientFactory>();
                var httpClient = clientFactory.CreateClient("DeFiPulse");

                return new DeFiPulse(httpClient, apiKey);
            });
        }
    }
}
