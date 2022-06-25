using TEDUMiddleware.Middlewares;

namespace TEDUMiddleware.Extensions
{
    public static class MiddlewaresExtension
    {
        public static IApplicationBuilder UseMiddlewaresExtention(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SimpleMiddleware>();
        }
    }
}
