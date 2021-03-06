using Microsoft.AspNetCore.Mvc;
using MyApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly IPrinter _printer;

        public BookController(IPrinter printer)
        {
            _printer = printer;
        }

        public IActionResult Print()
        {
            _printer.Print();
            return Ok();
        }
    }
}
