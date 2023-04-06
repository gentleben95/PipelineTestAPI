namespace PipelineTestAPI.Tests.Controllers
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_Returns_Expected_Number_Of_WeatherForecasts()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            result.Should().NotBeNull();
            result.Count().Should().Be(5);
        }
    }
}
