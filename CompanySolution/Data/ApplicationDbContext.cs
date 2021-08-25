namespace CompanySolution.Data
{
    using CompanySolution.Domain.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> company { get; set; }

        public DbSet<CompanieDetails> CompanyDetails { get; set; }

        public DbSet<CompanyImage> CompanyImages { get; set; }

        public DbSet<Department> departments { get; set; }

        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("company");
            modelBuilder.Entity<CompanieDetails>().ToTable("CompanyDetails");
        }

    }
}
