using LeagueDataAccess;
using LeagueOfData.Controllers;
using LeagueTests.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Microsoft.AspNetCore.Http;
using LeagueServices.SummonerService;
using Microsoft.AspNetCore.Hosting;
using LeagueServices.SummonerService.Dto;

namespace LeagueTests.UnitTests.LeagueServicesTests
{
    public class SummonerControllerTests
    {
        [Fact]
        public void CallGetMethod_NoParams_ReturnsJsonResult()
        {
            var options = InMemorySQLite.CreateOptions<LeagueContext>();

            using (var context = new LeagueContext(options))
            {
                context.Database.EnsureCreated();
                var controller = new SummonersController(context);

                var result = controller.Get();

                Assert.IsType<JsonResult>(result);
            }
        }

        [Fact]
        public void CallGetMethod_NoParams_DoesNotReturnNull()
        {
            var options = InMemorySQLite.CreateOptions<LeagueContext>();

            using (var context = new LeagueContext(options))
            {
                context.Database.EnsureCreated();
                var controller = new SummonersController(context);

                var result = controller.Get();

                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Koomuch")]
        [InlineData("golemko")]
        [InlineData("ubnix")]
        [InlineData("Shimeshugar")]
        public void CallGetMethod_ParamIsValidExistingSummonerName_ReturnsOkResult(
            string summonerName)
        {
            var options = InMemorySQLite.CreateOptions<LeagueContext>();

            using (var context = new LeagueContext(options))
            {
                context.Database.EnsureCreated();
                var controller = new SummonersController(context);

                var result = controller
                    .GetDetails(summonerName);

                var okResult = result as OkObjectResult;

                Assert.IsType<SummonerDto>(okResult.Value);
                Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            }
        }

        [Theory]
        [InlineData("XXXX")]
        public void CallGetMethod_ParamIsValidNonExistantSummonerName_ReturnsNotFoundResult(
            string summonerName)
        {
            var options = InMemorySQLite.CreateOptions<LeagueContext>();

            using (var context = new LeagueContext(options))
            {
                context.Database.EnsureCreated();
                var controller = new SummonersController(context);

                var result = controller.GetDetails(summonerName);

                var notFoundResult = result as NotFoundResult;

                Assert.Equal(StatusCodes.Status404NotFound, notFoundResult.StatusCode);
            }
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void CallGetMethod_ParamIsInvalidSummonerName_ThrowsArgumentNullException(
            string summonerName)
        {
            var options = InMemorySQLite.CreateOptions<LeagueContext>();

            using (var context = new LeagueContext(options))
            {
                context.Database.EnsureCreated();
                var controller = new SummonersController(context);

                Assert.Throws<ArgumentException>(() =>
                    controller.GetDetails(summonerName));
            }
        }
    }
}
