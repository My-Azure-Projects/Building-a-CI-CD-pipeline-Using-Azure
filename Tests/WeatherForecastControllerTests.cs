using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using Moq;
using WebApi.Controllers;
using Xunit;


namespace Tests
{
    public class WeatherForecastControllerTests
    {
        private Mock<ILogger<WeatherForecastController>> loggerStub = new Mock<ILogger<WeatherForecastController>>();

        [Fact]
        public void Get_NoArguments_ReturnsDefaultForecastDays()
        {
            var controller = new WeatherForecastController(loggerStub.Object);
            var expectedDays = 7;

            var forecasts = controller.Get();

            Assert.NotNull(forecasts);
            Assert.Equal(expectedDays, forecasts.Count());
        }
    }
}
