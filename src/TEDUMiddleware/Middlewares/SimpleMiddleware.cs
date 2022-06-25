namespace TEDUMiddleware.Middlewares
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;
        public SimpleMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("<h1>Start SimpleMiddleware !</h1>");
            await _next(context);
        }
    }
}
