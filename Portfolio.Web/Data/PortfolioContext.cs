using Microsoft.EntityFrameworkCore;

namespace Portfolio.Web.Models
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext (DbContextOptions<PortfolioContext> options)
            : base(options)
        {
        }

        
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("Articles");
        }
    }
}