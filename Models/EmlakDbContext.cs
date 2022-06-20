using finalcal.Models;
using Microsoft.EntityFrameworkCore;


namespace finalcal
{
    public class EmlakDbContext : DbContext
    {
        public DbSet<Emlak> Emlaklar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EmlakDbMvcFinalcal;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emlak>().ToTable("tblemlaklar");

            modelBuilder.Entity<Emlak>().Property(o => o.konum).HasColumnType("varchar").HasMaxLength(25).IsRequired();

            modelBuilder.Entity<Emlak>().Property(o => o.fiyat).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            
        }
    }
}
