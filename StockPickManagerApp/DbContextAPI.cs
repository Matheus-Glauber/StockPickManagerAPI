using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Action = StockPickManagerApp.Models.Action;

namespace StockPickManagerApp
{
    public class DbContextAPI : DbContext
    {
        //CLASSES
        public DbSet<Action> Action { get; set; }

        public DbContextAPI(DbContextOptions<DbContextAPI> options) : base(options) { }
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DbContextAPI>
        {
            public DbContextAPI CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<DbContextAPI>();
                var connectionString = configuration.GetConnectionString("DefaultConecction");
                builder.UseNpgsql(connectionString);
                return new DbContextAPI(builder.Options);
            }
        }
    }
}
