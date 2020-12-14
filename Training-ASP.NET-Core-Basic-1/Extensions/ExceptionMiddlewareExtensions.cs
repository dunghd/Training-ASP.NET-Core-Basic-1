using Microsoft.AspNetCore.Builder;
using Training_ASP.NET_Core_Basic_1.CustomExceptionMiddleware;

namespace Training_ASP.NET_Core_Basic_1.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
