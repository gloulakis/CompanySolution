namespace CompanySolution.Data
{
    using CompanySolution.Domain.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> company { get; set; }

        public DbSet<CompanieDetails> CompanyDetails { get; set; }

        public DbSet<CompanyImage> CompanyImages { get; set; }
    }
}
