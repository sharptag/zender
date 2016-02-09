using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Zender.Mail;

namespace ZenderSendMail
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can register your e-mail address to get the API Key
            ZenderMessage message = new ZenderMessage("Your zender API Key");
            MailAddress from = new MailAddress("yourmail@example.com");
            MailAddress to = new MailAddress("tomail@example.com");
            message.From = from;
            message.To.Add(to);
            message.Subject = "Welcome!";
            message.Body = "<p><b>Lorem ipsum</b> dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>";
            message.IsBodyHtml = true;
            message.SendMailAsync();
        }
    }
}
