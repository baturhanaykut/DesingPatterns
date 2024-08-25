using Microsoft.EntityFrameworkCore;
using UnitOfWorkDesignPattern.BusinessLayer.Abstract;
using UnitOfWorkDesignPattern.BusinessLayer.Concrete;
using UnitOfWorkDesignPattern.DataAccessLayer.Abstract;
using UnitOfWorkDesignPattern.DataAccessLayer.Concrete;
using UnitOfWorkDesignPattern.DataAccessLayer.EntityFramework;
using UnitOfWorkDesignPattern.DataAccessLayer.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnetion")));

builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<IUowDal,UowDal>();

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