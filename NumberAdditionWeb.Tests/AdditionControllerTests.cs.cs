using Microsoft.AspNetCore.Mvc;
using NumberAdditionWeb.Controllers;
using Xunit;

namespace NumberAdditionWeb.Tests
{
    public class AdditionControllerTests
    {
        private readonly AdditionController _controller;

        public AdditionControllerTests()
        {
            _controller = new AdditionController();
        }

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var result = _controller.Add(5, 3);
            Assert.IsType<ActionResult<double>>(result);
            Assert.Equal(8, result.Value);
        }

        [Fact]
        public void Add_WithNegativeNumbers_ReturnsCorrectSum()
        {
            var result = _controller.Add(-5, 3);
            Assert.IsType<ActionResult<double>>(result);
            Assert.Equal(-2, result.Value);
        }

        [Fact]
        public void Add_WithDecimals_ReturnsCorrectSum()
        {
            var result = _controller.Add(5.5, 3.3);
            Assert.IsType<ActionResult<double>>(result);
            Assert.Equal(8.8, result.Value, 2);
        }
    }
}