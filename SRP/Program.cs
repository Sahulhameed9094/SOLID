using System.Reflection.Metadata;

namespace SRP
{
    public class Program
    {
        public static void Main(string[] args)
        {


           /* Problem Statement

            A lab to follow the SRP principle while doing your code in C#.

            Do refer to the below UserService class that handles user authentication, user data management, and email notifications.
            Refactor the UserService class into separate classes to handle the different responsibilities.
            Ensure each class has a single responsibility and update the main program to use the new classes: UserService, AuthenticationService, UserDataService, EmailNotificationService.*/

            string username = "exmuser";
            string password = "exp";
            string email = "example@ex.com";

            AuthenticationService authenticationService = new AuthenticationService();
            UserDataService userDataService = new UserDataService();
            EmailNotificationService notificationService = new EmailNotificationService();

            UserService userService = new UserService(authenticationService, userDataService, notificationService);
            userService.ProcessUser(username, password, email);

            Console.ReadLine();
        }
    }
}
