using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoMovies.Middleware;

namespace ContosoMovies.Extentions
{
    public static class Logging
    {
        public static IApplicationBuilder UseRequestLogging(this IApplicationBuilder builder) =>
            builder.UseMiddleware<RequestLoggingMiddleware>();

        public static IApplicationBuilder UseResponceLogging(this IApplicationBuilder builder) =>
            builder.UseMiddleware<ResponceLoggingMiddleware>();

    }
}
