using Microsoft.Extensions.DependencyInjection;
using BlazorLazyLoadingApp.ServiceProxies;
using System;
using System.Net.Http;

namespace BlazorLazyLoadingApp.Client 
{
    public class WeatherForecastLazyService
    {
        private readonly IServiceProvider services;

        public WeatherForecastLazyService(IServiceProvider services)
        {
            this.services = services;
        }

        public IWeatherForecastService Create()
        {
            HttpClient http = this.services.GetRequiredService<HttpClient>();
            return new WeatherForecastService(http);
        }
    }
}
