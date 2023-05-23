using HELMo_bilite.Data;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//var connectionString = builder.Configuration.GetConnectionString("ValentinConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddTokenProvider<DataProtectorTokenProvider<User>>(TokenOptions.DefaultProvider);

builder.Services.AddScoped<UserManager<User>>();



builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();


using (var scope = app.Services.CreateScope())
{

    //obtention du role manager du type IdentityRole
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    //obtention du userManager du type User
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
    //obtention du context Db
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    //lancement de la creation des donnees de test
    DataGeneration.SeedAddresses(dbContext);
    DataGeneration.SeedRole(roleManager);
    DataGeneration.SeedUser(userManager, dbContext);
    DataGeneration.SeedVehicles(dbContext);
    DataGeneration.SeedDelivery(dbContext);

}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
