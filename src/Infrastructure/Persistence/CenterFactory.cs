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

            /*var dir = Directory.GetParent(Directory.GetCurrentDirectory());
            do
                dir = dir.Parent;
            while (dir.Name != "EnglishCenter");
            dir = dir.Parent;
            var path = dir.FullName;
            
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(path+"\\EnglishCenter")
            .AddJsonFile("appsettings.json")
            .Build();
             */
             

            /*IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();*/

            //var connectionString = configuration.GetConnectionString("TourDB");
            var optionsBuilder = new DbContextOptionsBuilder<CenterContext>();
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EnglishCenterDB;Trusted_Connection=True;");

            return new CenterContext(optionsBuilder.Options);
        }
    }
}