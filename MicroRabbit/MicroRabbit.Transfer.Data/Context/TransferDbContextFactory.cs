using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbit.Banking.Data.Context
{
    public class TransferDbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TransferDbContext>();
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=TransferDB;Trusted_Connection=true;MultipleActiveResultSets=true");

            return new TransferDbContext(optionsBuilder.Options);
        }
    }
}