using Microsoft.AspNetCore.Mvc;

namespace PW3.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
