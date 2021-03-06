using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyApplication.Interfaces;
using MyApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _sender;


        public HomeController(ILogger<HomeController> logger, IConfiguration config, IEmailSender sender)
        {
            _logger = logger;
            _configuration = config;
            _sender = sender;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Send(EmailModel model) {
            if (ModelState.IsValid){
                var senderOptions = new SenderOptions();
                _configuration.GetSection(SenderOptions.EmailBlock).Bind(senderOptions);

                bool res = false;

                try{
                    res = await _sender.SendEmailAsync(new MessageData { Email = model, Options = senderOptions });
                }
                catch(Exception e){
                    _logger.LogError($"Error while send email \n {e.Message}");
                }

                if (res == true)
                    return Ok("Ok");
            }
            return NoContent();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
