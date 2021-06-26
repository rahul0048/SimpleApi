using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleApi.Tests
{
    public class UnitTest1
    {
        //Arrange
        WeatherForecastController wController = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            // Act
               var output = wController.FetchData(1);
             //Assert
               Assert.Equal("Rahul Garg",output);
        }
    }
}
