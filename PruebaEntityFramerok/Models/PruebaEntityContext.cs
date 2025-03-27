using Microsoft.EntityFrameworkCore;

namespace PruebaEntityFramerok.Models
{
    public partial class PruebaEntityContext : DbContext
    {
        public PruebaEntityContext(){}

        public PruebaEntityContext(DbContextOptions<PruebaEntityContext> options) : base(options) { }
        public DbSet<HckPersona> HckPersonas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HckPersona>().HasNoKey();
        }

    }
}
