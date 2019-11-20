using LeagueDataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LeagueOfData
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        readonly string AllowedOrigins = "AllowedOrigins";
        readonly string LocalhostOrigin = "LocalHost";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy(LocalhostOrigin,
                    builder =>
                    {
                    builder
                        .WithOrigins(Configuration.GetSection(AllowedOrigins).GetValue<string>(LocalhostOrigin))
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });

            services.AddDbContext<LeagueContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("LeagueConnection")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseCors(LocalhostOrigin);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
