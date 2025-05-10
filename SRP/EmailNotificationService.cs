
using System.Net.Mail;

namespace SRP
{
    public class EmailNotificationService
    {
        public void SendNotification(string emailAddress, string message)
        {
            throw new NotImplementedException();
        }

        public bool SendEmail(MailMessage message)
        {
            return true;
        }
        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}