using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Controllers
{
    public class ErrorController : Controller
    {

        public ErrorController()
        {

        }

        [Route("{code}")]
        public IActionResult Show(string code)
        {
            ViewBag.Code = code;
            return View();
        }
    }
}
