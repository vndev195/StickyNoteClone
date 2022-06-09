using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StickyNoteClone.Factory;
using StickyNoteClone.Models;
using StickyNoteClone.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//AddControllersWithViews - sets up the shared objects required by applications using MVC framework and the razor view engine
builder.Services.AddControllersWithViews();

//Entity Framework Core must be configured so that it knows the type of database to which it will connect
builder.Services.AddDbContext<StickyNoteDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:StickyNoteConnection"]);
});

builder.Services.AddIdentity<User, IdentityRole>(opt =>
 {
     opt.Password.RequiredLength = 7;
     opt.Password.RequireDigit = true;
     opt.Password.RequireNonAlphanumeric = false;
     opt.User.RequireUniqueEmail = true;
 }).AddEntityFrameworkStores<StickyNoteDbContext>();

//register CustomClaimsFactory class in the service collection
builder.Services.AddScoped<IUserClaimsPrincipalFactory<User>, CustomClaimsFactory>();
builder.Services.AddScoped<INoteRepository, NoteRepository>();

builder.Services.AddRazorPages();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
SeedData.EnsurePopulated(app);
app.Run();
