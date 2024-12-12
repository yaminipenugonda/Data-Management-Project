using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using MVCDHProject2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews(configure =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    configure.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddScoped<ICustomerDAL, CustomerXmlDAL>();
builder.Services.AddDbContext<MVCCoreDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));
builder.Services.AddScoped<ICustomerDAL, CustomerSqlDAL>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MVCCoreDbContext>();
//builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
//{
//    options.Password.RequiredLength = 8;
//    options.Password.RequireDigit = false;
//}).AddEntityFrameworkStores<MVCCoreDbContext>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequiredLength = 8;
    options.Password.RequireDigit = false;
}).AddEntityFrameworkStores<MVCCoreDbContext>().AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // app.UseStatusCodePages();
     app.UseStatusCodePagesWithRedirects("/ClientError/{0}");
   //app.UseStatusCodePagesWithReExecute("/ClientError/{0}");

     app.UseExceptionHandler("/Home/Error");
     // app.UseExceptionHandler("/ServerError");

    app.UseHsts();
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
