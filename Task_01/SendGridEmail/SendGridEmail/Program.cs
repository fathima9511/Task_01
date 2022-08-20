using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;


    class Program
    {
        static void Main(string[] args)
        {
         
            SendEmail().Wait();
        }

        static async Task SendEmail()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("fathimanifranizar6@gmail.com", "Fathima");
            var subject = "Sending with SendGrid";
            var to = new EmailAddress("fathima9735@gmail.com", "Nifra");
            var plainTextContent = "My First Email";
            var htmlContent = "<strong>This is my first Templated Email in C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }

