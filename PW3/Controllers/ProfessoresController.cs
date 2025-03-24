using Microsoft.AspNetCore.Mvc;

namespace PW3.Controllers
{
    public class ProfessoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
