using SysLogin.Models;
using SysLogin.Repository.Interfaces;

namespace SysLogin.Repository
{
    public class Login : ILogin
    {
        public UserModel Get(string email, string password)
        {
            var users = new List<UserModel>
            {
                new () {Id = 1, Email = "admin", Password = "admin", Role = "Admin"},
            };
            return users.Where(x => x.Email.ToLower() == email.ToLower() && x.Password == x.Password).FirstOrDefault() ?? throw new Exception("error");
        }
    }
}
