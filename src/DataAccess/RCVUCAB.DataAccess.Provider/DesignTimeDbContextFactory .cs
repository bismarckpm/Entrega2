using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RCVUCAB.DataAccess.Provider.DataBase;


namespace RCVUCAB.DataAccess.Provider
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProviderDBContext>
    {
        public ProviderDBContext CreateDbContext(string[]? args)
        {
            var builder = new DbContextOptionsBuilder<ProviderDBContext>();
            var connectionString = "Server=localhost;Database=RCVUCAB_Providers;Port=5432;User Id=postgres;Password=postgres";
            builder.UseNpgsql(connectionString);
            return new ProviderDBContext(builder.Options);
        }
    }
}
