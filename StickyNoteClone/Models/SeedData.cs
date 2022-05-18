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
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        FirstName = "Harald",
                        LastName = "Henniger",
                        UserName = "hhenniger0",
                        Email = "hhenniger0@google.co.jp"
                    },
                    new User
                    {
                        FirstName = "Cicily",
                        LastName = "Giametti",
                        UserName = "cleward1",
                        Email = "hhenniger0@google.co.jp"
                    },
                    new User
                    {
                        FirstName = "Nathanael",
                        LastName = "Cannicott",
                        UserName = "ssulland2",
                        Email = "hhenniger0@google.co.jp"
                    },
                    new User
                    {
                        FirstName = "Renard",
                        LastName = "Simond",
                        UserName = "lgiametti3",
                        Email = "hhenniger0@google.co.jp"
                    });
            }
            context.SaveChanges();
            if (!context.Notes.Any())
            {
                context.Notes.AddRange(
                    new Note
                    {
                        Title = "Small Wonders",
                        Content = "Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.",
                        IsDisplayed = true,
                        StateId = 1,
                        UserId = 2
                    },
                    new Note
                    {
                        Content = "Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.",
                        Color = "#25be7b",
                        StateId = 1,
                        UserId = 1
                    },
                    new Note
                    {
                        Title = "Comic Book Confidential",
                        Content = "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.",
                        Color = "#2576be",
                        StateId = 1,
                        UserId = 1
                    },
                    new Note
                    {
                        Title = "Wyvern Wonders",
                        Content = "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.",
                        Color = "#fbdc29",
                        IsDisplayed = true,
                        StateId = 2,
                        UserId = 1
                    },
                    new Note
                    {
                        Title = "Enemy at the Gates",
                        Content = "Sed ante. Vivamus tortor. Duis mattis egestas metus..",
                        IsDisplayed = true,
                        Color = "#dc29fb",
                        StateId = 2,
                        UserId = 4
                    });
            }
            context.SaveChanges();
        }
    }
}