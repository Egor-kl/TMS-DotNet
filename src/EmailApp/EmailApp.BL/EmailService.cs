using System;
using System.Net;
using System.Net.Mail;

namespace EmailApp.BL
{
    public class EmailService
    {
        /// <summary>
        /// Отправка сообщения.
        /// </summary>
        public void SendEmail()
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(Constants.MESSAGE_SENDER_ADDRESS, Constants.DISPLAY_NAME);
            Console.WriteLine("Кому вы хотите отправить сообщение? Введите email адрес: ");

            var emailAdress = Console.ReadLine();
            message.To.Add(emailAdress);

            Console.WriteLine("Введите тему сообщения: ");
            message.Subject = Console.ReadLine();

            Console.WriteLine("Введите текст сообщения: ");
            message.Body = Console.ReadLine();

            using (var client = new SmtpClient(Constants.GMAIL_HOST))
            {
                client.Credentials = new NetworkCredential(Constants.MESSAGE_SENDER_ADDRESS, Constants.EMAIL_PASSWORD);
                client.Port = 587;
                client.EnableSsl = true;

                client.Send(message);
            }
        }
    }
}
