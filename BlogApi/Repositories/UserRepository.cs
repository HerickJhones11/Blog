using BlogApi.Models;

namespace BlogApi.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "luke_admin", EmailAddress = "luke_admin@gmail.com", Password = "Mypassword", GivenName="Luje", Surname="Rogers", Role ="Administrator" },
            new() { Username = "luke_admi2n", EmailAddress = "luke_admin@gmail2.com", Password = "Mypassword", GivenName = "Luje2", Surname = "Rogers2", Role = "Standard" },
        };
    }
}
