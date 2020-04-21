using System.Collections.Generic;
using System.Linq;
using Shop.Models;

namespace Shop.Repositories
{
    public static class UserRepository
    {
        public static User GetUser(string username, string password)
        {
            var users = new List<User>();

            users.Add(new User { Id = 1, Username = "batman", Password = "1234", Role = "manager" });
            users.Add(new User { Id = 2, Username = "robin", Password = "4321", Role = "employee" });
        
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password.ToLower() == password.ToLower()).FirstOrDefault();
        }
    }
}