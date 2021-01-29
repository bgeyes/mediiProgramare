using Microsoft.EntityFrameworkCore;

namespace Notes.DB
{
    public class AppDBContext : DbContext
    {

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=notes;Username=postgres;Password=password");

    }
}
