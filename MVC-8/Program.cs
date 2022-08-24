var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();
builder.Services.AddMvc();
var app = builder.Build();
app.UseSession();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "setFilter",
    pattern: "SetFilter",
    defaults: new { controller = "Home", action = "SetFilter" }
);

app.MapControllerRoute(
    name: "addPerson",
    pattern: "AddPerson",
    defaults: new { controller = "Home", action = "AddPerson" }
);

app.MapControllerRoute(
    name: "addPerson",
    pattern: "api",
    defaults: new { controller = "Home", action = "API" }
);

app.MapControllerRoute(
    name: "addPerson",
    pattern: "apiGetPeople",
    defaults: new { controller = "Home", action = "ApiGetPeople" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "",
    defaults: new { controller = "Home", action = "Index" }
);

app.Run();
