using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Actividad6.Data
{
    public class PanaderiaContextFactory : IDesignTimeDbContextFactory<PanaderiaContext>
    {
        public PanaderiaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PanaderiaContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PanaderiaDb;Trusted_Connection=True;");

            return new PanaderiaContext(optionsBuilder.Options);
        }
    }
}
