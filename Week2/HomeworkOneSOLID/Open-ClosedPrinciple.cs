using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOneSOLID.OpenClosedPrinciple
{
    public interface INotification
    {
        void Send(string to, string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine("Email ile Başarıyla Mesaj Gönderilmiştir.");
        }
    }
    public class SMSNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine("SMS ile Başarıyla Mesaj Gönderilmiştir.");
        }
    }

    public class Notification(INotification _notification)
    {
       public void Send(string to, string message)
       {
            _notification.Send(to, message);
       }
    }
}
