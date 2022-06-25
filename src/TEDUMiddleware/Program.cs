using TEDUMiddleware.Extensions;
using TEDUMiddleware.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<h1> Start Middleware 1 </h1>");
    await next.Invoke(context);
});

//app.UseMiddleware<SimpleMiddleware>();
app.UseMiddlewaresExtention();

app.Run();
