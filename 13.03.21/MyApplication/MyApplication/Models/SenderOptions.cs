using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class SenderOptions
    {
        public const string EmailBlock = "Email";
        public string SourceEmail { get; set; }
        public string SourcePassword { get; set; }
        public int Port { get; set; }
        public int UseSSL { get; set; }

    }
}
