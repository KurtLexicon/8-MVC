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
    name: "GetCoffee",
    pattern: "GetCoffee",
    defaults: new { controller = "Home", action = "GetCoffee" }
);

app.MapControllerRoute(
    name: "GetPeople",
    pattern: "GetPeople",
    defaults: new { controller = "Home", action = "GetPeople" }
);

app.MapControllerRoute(
    name: "GetPerson",
    pattern: "GetPerson",
    defaults: new { controller = "Home", action = "GetPerson" }
);

app.MapControllerRoute(
    name: "AddRandomPerson",
    pattern: "AddRandomPerson",
    defaults: new { controller = "Home", action = "AddRandomPerson" }
);

app.MapControllerRoute(
    name: "AddOrUpdatePerson",
    pattern: "AddOrUpdatePerson",
    defaults: new { controller = "Home", action = "AddOrUpdatePerson" }
);

app.MapControllerRoute(
    name: "DeletePerson",
    pattern: "DeletePerson",
    defaults: new { controller = "Home", action = "DeletePersonGetPeopleList" }
);

app.Run();
