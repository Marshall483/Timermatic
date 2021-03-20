using ContosoMovies.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using ContosoMovies.Models;
using System;

namespace ContosoMovies.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        private AppDbContext _context;

        public RequestLoggingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, AppDbContext context)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<RequestLoggingMiddleware>();
        }
    

        public async Task Invoke( HttpContext context, AppDbContext dbContext)
        {
            _context = dbContext;

            try
            {
                Log request = new Log { Status = "Information", Type = "Request", Message = $"Method {context.Request?.Method}, Patch {context.Request?.Path.Value}" };

                _context.Logs.Add(request);

                await _next(context);
            }catch(Exception ex){
                _logger.LogError(exception: ex, message: ex.Message);
            }
            finally{
                _logger.LogInformation(
                    "Request {method} {url} => {statusCode}",
                    context.Request?.Method,
                    context.Request?.Path.Value,
                    context.Response?.StatusCode);
            }
        }
    }
}

