using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Data
{
    public class PanaderiaContextFactory : IDesignTimeDbContextFactory<PanaderiaContext>
    {
        public PanaderiaContext CreateDbContext(string[] args)
        {

            var configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false)
              .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<PanaderiaContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new PanaderiaContext(optionsBuilder.Options);
        }
    }
}
