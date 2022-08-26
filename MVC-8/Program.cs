var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();
builder.Services.AddMvc();
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
    name: "TestErrorCode",
    pattern: "TestErrorCode",
    defaults: new { controller = "Home", action = "TestErrorCode" }
);

app.MapControllerRoute(
    name: "setFilterGetPeopleList",
    pattern: "SetFilterGetPeopleList",
    defaults: new { controller = "Home", action = "SetFilterGetPeopleList" }
);


app.MapControllerRoute(
    name: "PersonDetails",
    pattern: "PersonDetails",
    defaults: new { controller = "Home", action = "ShowPerson" }
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
