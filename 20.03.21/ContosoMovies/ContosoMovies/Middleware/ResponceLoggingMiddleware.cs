using ContosoMovies.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using ContosoMovies.Models;
using System;

namespace ContosoMovies.Middleware
{
    public class ResponceLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        private AppDbContext _context;

        public ResponceLoggingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, AppDbContext context)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<RequestLoggingMiddleware>();
        }

        public async Task Invoke( HttpContext context, AppDbContext dbContext)
        {
            _context = dbContext;

            Log log = new Log { Status = "Info", Message = $"Satus Conde {context.Response?.StatusCode}" };

            try{
                await _context.Logs.AddAsync(log);

                _logger.LogInformation(
                 "Responce {url} => {statusCode}",
                  context.Request?.Path.Value,
                 context.Response?.StatusCode);
            }
            catch (Exception ex){
                _logger.LogError(exception: ex, message: ex.Message);
            }
        }
    }
}
