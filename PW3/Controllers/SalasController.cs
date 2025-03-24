using Microsoft.AspNetCore.Mvc;

namespace PW3.Controllers
{
    public class SalasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
