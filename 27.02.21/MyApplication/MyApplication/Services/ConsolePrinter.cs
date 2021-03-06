using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApplication.Interfaces;

namespace MyApplication.Services
{
    public class ConsolePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Распечатали");
        }
    }
}
