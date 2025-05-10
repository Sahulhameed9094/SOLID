
namespace SRP
{
    public class AuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            return username == "exampleUser" && password == "examplePassword"; // Placeholder 
        }
    }
}