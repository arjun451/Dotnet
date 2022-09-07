using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using Microsoft.AspNetCore.Identity;
using WebApplication1.Repository;
using WebApplication1.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApplication1.Helper;
using WebApplication1.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server=LAPTOP-E8KR8L2K;Database=Tweets;Trusted_Connection=True"));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();;
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimFactory>();

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 4;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredUniqueChars = 1;
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = false;
});
 builder.Services.ConfigureApplicationCookie(options =>
 {

     options.LoginPath = $"/Views/Account/SignIn";
     
 });


// Add services to the container.
builder.Services.AddControllersWithViews();
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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
