using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorLazyLoadingApp.Shared;

namespace BlazorLazyLoadingApp.ServiceProxies 
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient httpClient;

        public WeatherForecastService(HttpClient httpClient) => this.httpClient = httpClient;

        public async ValueTask<IEnumerable<WeatherForecast>> GetWeatherForecasts()
        {
            WeatherForecast[]? forecasts = await this.httpClient.GetFromJsonAsync<WeatherForecast[]>("data/weather.json");
            return forecasts?.AsEnumerable()!;
        }
    }
}