using LeagueDataAccess;
using LeagueTests.Helpers;
using System.Linq;
using Xunit;

namespace LeagueTests.UnitTests
{
    public class InMemorySQLiteTest
    {
        [Fact]
        public void TestSQLiteOk()
        {
            var options = InMemorySQLite.CreateOptions<LeagueContext>();

            using (var context = new LeagueContext(options))
            {
                context.Database.EnsureCreated();

              //  context.SeedDbWithFiveSummoners();

                var actual = context.Summoners.Count();

                Assert.Equal(6, actual);
            }
        }
    }
}
