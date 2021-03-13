using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Middleware
{
    public class LoggerMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<LoggerMiddleware> _logger;

        public LoggerMiddleware(RequestDelegate next, ILogger<LoggerMiddleware> logger)
        {
            this._next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string patch = context.Request.Path.Value.ToLower();
            _logger.Log(LogLevel.Information, $"Processing request {patch}");

            await _next.Invoke(context);
        }
    }
}
