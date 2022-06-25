var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true);

var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync($"<h1>{builder.Configuration.GetSection("Message").Value}</h1>");
    await context.Response.WriteAsync($"<h1>{builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value}</h1>");
    await context.Response.WriteAsync($"<h1>{builder.Configuration.GetSection("Student:0:Name").Value}</h1> {builder.Environment.EnvironmentName}");
    await next.Invoke();
});

app.Run();
