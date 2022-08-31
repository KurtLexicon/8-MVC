using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();
builder.Services.AddMvc();

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();
app.UseSession();

app.UseStaticFiles();
app.UseRouting();

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
    name: "GetCoffee",
    pattern: "GetCoffee",
    defaults: new { controller = "Home", action = "GetCoffee" }
);

app.MapControllerRoute(
    name: "ItemActions",
    pattern: "{controller}/{action}"
);

app.Run();
