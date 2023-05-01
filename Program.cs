using HELMo_bilite.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//ajout de la configuration de la base de données
/*builder.Services.AddDbContext<DeliveryDbContext>(options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Delivery;Encrypt=True;TrustServerCertificate=True;Trusted_Connection=True;"));
*/
builder.Services.AddDbContext<DeliveryDbContext>(options =>
    options.UseSqlServer("Server=192.168.128.18;Database=in21b10093;User Id=in21b10093;Password=0093;Encrypt=true;TrustServerCertificate=true"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
