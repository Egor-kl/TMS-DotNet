using System;
using EmailApp.BL;

namespace EmailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailService = new EmailService();
            emailService.SendEmail();
        }
    }
}
