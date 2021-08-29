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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CompanyDetails>()
                .HasOne(p => p.company)
                .WithMany(d => d.details)
                .HasForeignKey(k => k.CompanyId);
 
        }
        public DbSet<Company> company { get; set; }

        public DbSet<CompanyDetails> DbCompanyDetails { get; set; }

    }
}
