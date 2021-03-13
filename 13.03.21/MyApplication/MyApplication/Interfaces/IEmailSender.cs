using MyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Interfaces
{
    public interface IEmailSender
    {
        public async Task<bool> SendEmailAsync(MessageData data) {
            return false;
        }
    }
}
