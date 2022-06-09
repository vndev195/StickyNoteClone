using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StickyNoteClone.Configurations;

namespace StickyNoteClone.Models
{
    public class StickyNoteDbContext : IdentityDbContext<User>
    {
        public DbSet<Note> Notes { get; set; }
        public DbSet<State> State { get; set; }

        public StickyNoteDbContext(DbContextOptions<StickyNoteDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Note>(e =>
            {
                e.HasOne(c => c.UserNavigation)
                .WithMany(c => c.Notes)
                .HasForeignKey(c => c.UserId)
                .HasConstraintName("FK_User_Note_UserId");
            });

            modelBuilder.Entity<Note>(e =>
            {
                e.HasOne(c => c.StateNavigation)
                .WithMany(c => c.Notes)
                .HasForeignKey(c => c.StateId)
                .HasConstraintName("FK_State_Note_StateId");
            });

            modelBuilder.Entity<Note>(e =>
            {
                e.Property(p => p.IsDisplayed).HasDefaultValue(false);
            });

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
