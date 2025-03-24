using Microsoft.AspNetCore.Mvc;

namespace PW3.Controllers
{
    public class DisciplinasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
