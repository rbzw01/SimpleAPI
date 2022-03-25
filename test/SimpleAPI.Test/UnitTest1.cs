using System.Linq;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsStuff()
    {
        var returnValue = controller.GetData();

        var v = returnValue.Aggregate((a, b) => $"{a}{b}");

        Assert.Equal("e-FreezingBracingChillyCoolMildWarmBalmyHotSwelteringScorching", v);
    }

    [Fact]
    public void Test1()
    {

    }
}