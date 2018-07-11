using System;
using FluentAssertions;
using FluentAssertions.Collections;
using Moq;
using Xunit;

namespace temperature.test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "เปลี่ยนค่า องศา Fahrenheit ให้เป็น Celsius ได้สำเร็จ")]
        [InlineData(32, 0)]
        [InlineData(41, 5)]
        [InlineData(36.5, 2.5)]
        public void ConvertFahrenheitToCelsiusSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertFahrenheitToCelsius(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา Kelvin ให้เป็น Celsius ได้สำเร็จ")]
        [InlineData(363.15, 90)]
        [InlineData(273.15, 0)]
        [InlineData(0, -273.15)]
        public void ConvertKelvinToCelsiusSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertKelvinToCelsius(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา celsius ให้เป็น Fahrenheit ได้สำเร็จ")]
        [InlineData(90, 194)]
        [InlineData(0, 32)]
        [InlineData(2, 35.6)]
        public void ConvertCelsiusToFahrenheitSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertCelsiusToFahrenheit(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา Kelvin ให้เป็น Fahrenheit ได้สำเร็จ")]
        [InlineData(90, -297.67)]
        [InlineData(0, -459.67)]
        [InlineData(1, -457.87)]
        public void ConvertKelvinToFahrenheitSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertKelvinToFahrenheit(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา Fahrenheit ให้เป็น Kelvin ได้สำเร็จ")]
        [InlineData(-297.67, 90)]
        [InlineData(-459.67, 0)]
        [InlineData(-279.67, 100)]
        public void ConvertFahrenheitToKelvinSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertFahrenheitToKelvin(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา celsius ให้เป็น Kelvin ได้สำเร็จ")]
        [InlineData(90, 363.15)]
        [InlineData(0, 273.15)]
        [InlineData(27, 300.15)]
        public void ConvertCelsiusToKelvinSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertCelsiusToKelvin(input);

            x.Should().Be(expectedResult);
        }
    }
}