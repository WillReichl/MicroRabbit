using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=BankingDB;Trusted_Connection=true;MultipleActiveResultSets=true");

            return new BankingDbContext(optionsBuilder.Options);
        }
    }
}