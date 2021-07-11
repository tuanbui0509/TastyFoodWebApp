using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.Data.EF
{
    class TastyFoodDbContextFactory : IDesignTimeDbContextFactory<TastyFoodDBContext>
    {
        public TastyFoodDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("TastyFoodDb");

            var optionsBuilder = new DbContextOptionsBuilder<TastyFoodDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TastyFoodDBContext(optionsBuilder.Options);
        }
    }
}
