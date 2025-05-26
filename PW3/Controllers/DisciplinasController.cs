using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PW3.Controllers
{
    public class DisciplinasController : Controller
    {
        // GET: DisciplinasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DisciplinasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DisciplinasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DisciplinasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DisciplinasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DisciplinasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DisciplinasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DisciplinasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
