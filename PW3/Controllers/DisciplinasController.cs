using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using PW3.Entidades;

namespace PW3.Controllers
{
    public class DisciplinasController : Controller
    {
        private readonly string connectionString = "Server=localhost;Database=aulabd2;Uid=root;Pwd=;";
        // GET: DisciplinasController
        public ActionResult Index()
        {
            List<DisciplinaEntidade> model = new List<DisciplinaEntidade>();

            DisciplinaEntidade item1 = new DisciplinaEntidade();
            item1.Id = 1;
            item1.Nome = "Programação Web";
            item1.Ativo = true;
            model.Add(item1);

            DisciplinaEntidade item2 = new DisciplinaEntidade();
            item2.Id = 2;
            item2.Ativo = true;
            item2.Nome = "Educação Física";
            model.Add(item2);




            return View(model);
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
        public ActionResult Create(DisciplinaEntidade dados)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var comando = new MySqlCommand(@"Insert into Disciplinas
                        (Nome) values (?)", connection );
                    comando.Parameters.AddWithValue("?", dados.Nome);
                    comando.ExecuteNonQuery();

                    connection.Close();
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
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
