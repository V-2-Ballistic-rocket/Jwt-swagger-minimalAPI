using Microsoft.AspNetCore.Identity;
using minimalAPI2.Models;

namespace minimalAPI2.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "luke_admin", EmailAddress = "admin@email.com", Password =
                "0000", GivenName = "Luke", Surname = "Rogers", Role = "Administrator" },
            new() { Username = "lydia_standard", EmailAddress = "standard@email.com",
                Password = "0000", GivenName = "Elyse", Surname = "Burton", Role =
                "Standard"},
        };
    }
}
