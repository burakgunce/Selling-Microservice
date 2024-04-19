using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Api.Infrastructure.Context
{
    public class CatalogContextDesignFactory : IDesignTimeDbContextFactory<CatalogContext>
    {
        public CatalogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CatalogContext>()
                .UseSqlServer("DESKTOP-7G5LBG3\\SQLSERVERBG;database=MicroserviceCatalogDB;integrated security=true;MultipleActiveResultSets=true");

            return new CatalogContext(optionsBuilder.Options);
        }
    }
}
