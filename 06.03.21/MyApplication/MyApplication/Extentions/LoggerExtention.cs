using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApplication.Middleware;

namespace MyApplication.Extentions
{
    public static class LoggerExtention
    {
        public static IApplicationBuilder UseLogger(this IApplicationBuilder builder) => builder.UseMiddleware<LoggerMiddleware>();
    }
}
