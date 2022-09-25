using Microsoft.AspNetCore.Mvc;

namespace SysLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
