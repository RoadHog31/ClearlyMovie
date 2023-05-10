using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ClearlyMovie.Data;


/*ASP.NET Core is built with dependency injection (DI). Services, such as the database context, are registered with DI in Program.cs. These services are provided to components that require them via constructor parameters.

In the Controllers/MoviesController.cs file, the constructor uses Dependency Injection to inject the MvcMovieContext database context into the controller. The database context is used in each of the CRUD methods in the controller.

 The ASP.NET Core configuration system reads the "MvcMovieContext" database connection string.*/
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ClearlyMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ClearlyMovieContext") ?? throw new InvalidOperationException("Connection string 'ClearlyMovieContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Movies/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");

app.Run();
