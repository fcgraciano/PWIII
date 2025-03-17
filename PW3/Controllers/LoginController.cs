using Microsoft.AspNetCore.Mvc;

namespace PW3.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Logar()
        {
            return View();
        }
    }
}
