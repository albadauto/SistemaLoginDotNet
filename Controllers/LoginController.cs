using Microsoft.AspNetCore.Mvc;
using SysLogin.Models;
using SysLogin.Repository;
using SysLogin.Repository.Interfaces;
using SysLogin.Services;

namespace SysLogin.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogin _loginRepository;
        public LoginController(ILogin login)
        {
            this._loginRepository = login;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public object LogIn(UserModel userModel)
        {
            var user = _loginRepository.Get(userModel.Email, userModel.Password);
            if(user == null)
            {
                return View("Error");
            }
            var token = TokenService.GenerateToken(userModel);
            return new
            {
                token = token,
            };

        }
    }
}
