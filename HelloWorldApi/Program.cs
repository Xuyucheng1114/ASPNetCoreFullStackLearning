var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!Hello Web! My ASP.NET Core journey starts here!Ag.12th,2026");

app.Run();