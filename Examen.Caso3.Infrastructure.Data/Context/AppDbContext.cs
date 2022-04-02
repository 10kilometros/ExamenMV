using Examen.Caso3.Domain.Aggregates.ClienteAgg;
using Examen.Caso3.Infrastructure.Data.Context.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Examen.Caso3.Infrastructure.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteEntityTypeConfiguration());
        }
    }

    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=ClientTest;User Id=mvillanueva;Password=@Examen.2021");

            return new AppDbContext(optionsBuilder.Options);
        }
    }

}
