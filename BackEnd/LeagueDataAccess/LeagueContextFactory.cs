using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LeagueDataAccess
{
    //When your DbContext exists in another project, like a shared library.

    //Meaning that is has no context to run from.

    //EF Core migrations works by actually running your code, if that is not possible, 
    //then you need to provide information about how your DbContext can be created, 
    //which you do with this factory
    public class LeagueContextFactory : IDesignTimeDbContextFactory<LeagueContext>
    {
        public IConfigurationRoot Configuration { get; set; }

        public LeagueContextFactory()
        {
        }

        public LeagueContextFactory(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }

        public LeagueContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"{Directory.GetCurrentDirectory()} /appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<LeagueContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("LeagueConnection"));

            return new LeagueContext(optionsBuilder.Options);
        }
    }
}
