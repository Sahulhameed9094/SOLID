using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{


    public class UserService

    {
        private readonly AuthenticationService _authenticationService;

        private readonly UserDataService _userDataService;

        private readonly EmailNotificationService _emailNotificationService;

        public UserService(AuthenticationService authenticationService,
                           UserDataService userDataService,
                           EmailNotificationService emailNotificationService)

        {
            _authenticationService = authenticationService;

            _userDataService = userDataService;

            _emailNotificationService = emailNotificationService;

        }

        public void ProcessUser(string username, string password, string emailAddress)

        {

            // Authenticate user

            if (_authenticationService.AuthenticateUser(username, password))

            {

                // If authenticated, manage user data

                _userDataService.ManageUserData(username);

                // Send email notification

                string message = "Your account has been accessed.";

                _emailNotificationService.SendNotification(emailAddress, message);

            }

            else

            {

                Console.WriteLine("Authentication failed.");

            }

        }

        public void Register(string email, string password)
        {
            if (!_emailNotificationService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = _authenticationService.AuthenticateUser(email, password);

            _emailNotificationService.SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }
    }
}
