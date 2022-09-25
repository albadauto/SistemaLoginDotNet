using SysLogin.Models;

namespace SysLogin.Repository.Interfaces
{
    public interface ILogin
    {
        UserModel Get(string username, string password);
    }
}
