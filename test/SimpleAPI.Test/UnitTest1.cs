namespace SimpleAPI.Test;
using SimpleAPI;
using SimpleAPI.Controllers;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController(null);
    [Fact]
    public void GetReturnsForecast()
    {
      IEnumerable<WeatherForecast> forecasts = controller.Get();

      Assert.True(forecasts.Any());
    }
}