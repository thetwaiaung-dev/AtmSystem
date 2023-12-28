using ATM;
using ATM.Helper;
using ATM.Models;
using ATM.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AtmDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("con"));
}, ServiceLifetime.Transient, ServiceLifetime.Transient);

builder.Services.AddTransient<AtmService>();
builder.Services.AddTransient<HelperService>();
builder.Services.AddTransient<UserService>();


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

