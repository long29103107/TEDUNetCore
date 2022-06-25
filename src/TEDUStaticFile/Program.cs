var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    ApplicationName = typeof(Program).Assembly.FullName,
    ContentRootPath = Directory.GetCurrentDirectory(),
    WebRootPath = "resources"
});

var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();
