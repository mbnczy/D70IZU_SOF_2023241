using System;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace ShoeWebshop.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {//RIN3yAVqD0YwtcW sneakerstalker@outlook.com
            using (SmtpClient client = new SmtpClient()
            {
                Host = "smtp.office365.com",
                Port = 587,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("sneakerstalker@outlook.com", "RIN3yAVqD0YwtcW"),
                TargetName = "STARTTLS / smtp.office365.com",
                EnableSsl = true
            })
            {
                MailMessage message = new MailMessage()
                {
                    From = new MailAddress("sneakerstalker@outlook.com"),
                    Subject = subject,
                    IsBodyHtml = true,
                    Body = htmlMessage,
                    BodyEncoding = System.Text.Encoding.UTF8,
                    SubjectEncoding = System.Text.Encoding.UTF8,
                };
                message.To.Add(email);
                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                }
            }
            return Task.CompletedTask;
        }
    }
}
