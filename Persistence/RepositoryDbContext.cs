using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class RepositoryDbContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=GIG001P10552\SQLEXPRESS;Initial Catalog=Accounting_db;Integrated Security=True");
        }


    }
}
