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

        public DbSet<Value> Values { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(
                new Value { Id = 1, Name = "Value 1" },
                 new Value { Id = 2, Name = "Value 2" },
                  new Value { Id = 3, Name = "Value 3" },
                   new Value { Id = 4, Name = "Value 4" },
                    new Value { Id = 5, Name = "Value 5" },
                     new Value { Id = 6, Name = "Value 6" }
                );
        }

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
