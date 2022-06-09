using Microsoft.EntityFrameworkCore;

namespace StickyNoteClone.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {

            StickyNoteDbContext context = app.ApplicationServices
               .CreateScope().ServiceProvider.GetRequiredService<StickyNoteDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.State.Any())
            {
                context.State.AddRange(
                    new State { StateName = "Private" },
                    new State { StateName = "Public" });
            }
            context.SaveChanges();

            context.SaveChanges();
        }
    }

}