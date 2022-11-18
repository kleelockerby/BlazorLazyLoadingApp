using BlazorLazyLoadingApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLazyLoadingApp.ServiceProxies 
{
    public interface IWeatherForecastService
    {
        ValueTask<IEnumerable<WeatherForecast>> GetWeatherForecasts();
    }
}
