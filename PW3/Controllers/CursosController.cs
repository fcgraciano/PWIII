using Microsoft.AspNetCore.Mvc;

namespace PW3.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
