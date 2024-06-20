using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOneSOLID.DependencyInversionPrinciple
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Email sent to: {to}, Subject: {subject}, Body: {body}");
        }
    }
    public class NotificationService(IEmailService _emailService)
    {
        public void Notify(string to, string message)
        {
            _emailService.SendEmail(to, "Notification", message);
        }
    }
}
