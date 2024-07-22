using Microsoft.EntityFrameworkCore;
using Pizza_Service_App.Pizaa_App_DbContext;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var conn_str = builder.Configuration.GetConnectionString("PizzaDbContextConnection");
builder.Services.AddDbContext<PizzaAppDbContext>(options =>
options.UseSqlServer(conn_str));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Index");
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
