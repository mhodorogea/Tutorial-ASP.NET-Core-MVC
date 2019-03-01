using Microsoft.EntityFrameworkCore;
using Moq;
using MvcMovies.Controllers;
using MvcMovies.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TestingControllerSample.Tests.UnitTests
{
    public class MoviesControllerTests
    {
        [Fact]
        public async Task Index_ReturnsGoodData()
        {
            // Arrange
            var controller = new MoviesController(null);

            // Act
            var result = await controller.Index("SF");

            // Assert
            //var viewResult = Assert.IsType<ViewResult>(result);
            //var model = Assert.IsAssignableFrom<IEnumerable<StormSessionViewModel>>(
            //    viewResult.ViewData.Model);
            //Assert.Equal(2, model.Count());
        }
    }
}
