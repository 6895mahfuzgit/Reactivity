using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Reactivity.Domain.Models;

namespace Reactivity.Infra.Data.Context
{
    public class ReactivlyDBContext : DbContext
    {
        public ReactivlyDBContext(DbContextOptions options) : base(options)
        {
        }   

        public DbSet<Value>  Values{ get; set; }
    }

    public class ReactivlyDBContextFactory : IDesignTimeDbContextFactory<ReactivlyDBContext>
    {
        public ReactivlyDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ReactivlyDBContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-TT5P3OP6\\SQLEXPRESS;Database=ReactivlyBD;Trusted_Connection=True;MultipleActiveResultSets=True;");
            return new ReactivlyDBContext(optionsBuilder.Options);
        }
    }
}
