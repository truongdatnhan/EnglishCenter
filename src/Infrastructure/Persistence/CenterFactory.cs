using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Infrastructure.Persistence
{
    public class CenterFactory : IDesignTimeDbContextFactory<CenterContext>
    {
        public CenterContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration.GetConnectionString("TourDB");
            var optionsBuilder = new DbContextOptionsBuilder<CenterContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CenterContext(optionsBuilder.Options);
        }
    }
}