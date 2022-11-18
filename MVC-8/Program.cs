using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models;

var builder = WebApplication.CreateBuilder(args);

var corsPolicyLocalHost = "LocalHost";
builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicyLocalHost,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});


builder.Services.AddSession();
builder.Services.AddMvc();
builder.Services.AddSession(options => {
    options.IdleTimeout = TimeSpan.FromMinutes(60);
});

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services
    .AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.Configure<IdentityOptions>(o => {
    o.Password.RequireLowercase = false;
    o.Password.RequireUppercase = false;
    o.Password.RequireDigit = false;
    o.Password.RequireNonAlphanumeric = false;
    o.Password.RequiredLength = 3;
    o.Password.RequiredUniqueChars = 1;
});

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
// global cors policy
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials()); // allow credentials

app.MapControllerRoute(
    name: "default",
    pattern: "",
    defaults: new { controller = "Home", action = "Index" }
);

app.MapControllerRoute(
    name: "IndexActions",
    pattern: "{controller}/Index",
    defaults: new { action = "Index" }
);

app.MapControllerRoute(
    name: "ItemPostActions",
    pattern: "{controller}/{action}"
);

app.MapControllerRoute(
    name: "ItemGetActions",
    pattern: "{controller}/{action}/{value}"
);

app.Run();
