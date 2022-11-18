using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

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

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();
app.UseSession();

app.UseStaticFiles();
app.UseRouting();
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
    name: "About",
    pattern: "About",
    defaults: new { controller = "Home", action = "About" }
);

app.MapControllerRoute(
    name: "People",
    pattern: "People",
    defaults: new { controller = "Home", action = "People" }
);

app.MapControllerRoute(
    name: "Countries",
    pattern: "Countries",
    defaults: new { controller = "Home", action = "Countries" }
);

app.MapControllerRoute(
    name: "Cities",
    pattern: "Cities",
    defaults: new { controller = "Home", action = "Cities" }
);

app.MapControllerRoute(
    name: "Languages",
    pattern: "Languages",
    defaults: new { controller = "Home", action = "Languages" }
);

app.MapControllerRoute(
    name: "GetCoffee",
    pattern: "GetCoffee",
    defaults: new { controller = "Home", action = "GetCoffee" }
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
