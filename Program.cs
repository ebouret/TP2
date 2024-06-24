using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using TPLOCAL1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TPLOCAL1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TPLOCAL1Context") ?? throw new InvalidOperationException("Connection string 'TPLOCAL1Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();