using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            var results = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            }).ToArray();

            // relational pattern matching is >, <, >=, <=
            // logical patterns matching are: and, or, not


            foreach (var rec in results)
            {
                //switch expression

                rec.Summary = rec.TemperatureF switch
                {
                    < 0 => "well below freezing",
                    >= 0 and < 32 => "freezing",
                    32 => "exactly freezing",
                    > 32 and < 65 => "cool",
                    >= 65 and < 85 => "warm",
                    >= 85 and < 100 => "hot",
                    _ => "unknown"  //_ is unknown
                };
            }

            return Task.FromResult(results);
        }
    }
}
