using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            var cmd = new MySqlCommand("SELECT id, nome FROM disciplinas", connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DisciplinaEntidade u = new DisciplinaEntidade();
                u.Id = reader.GetInt32("id");
                u.Nome = reader.GetString("nome");
                model.Add(u);
            }
            connection.Close();
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
            DisciplinaEntidade model = new DisciplinaEntidade();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            var comando = new MySqlCommand("SELECT id, nome FROM disciplinas where Id = ?", connection);
            comando.Parameters.AddWithValue("?", id);
            using var reader = comando.ExecuteReader();
            while (reader.Read())
            {
               model.Id = reader.GetInt32("id");
               model.Nome = reader.GetString("nome");
            }
            connection.Close();
            return View(model);
           
        }

        // POST: DisciplinasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DisciplinaEntidade dados)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var comando = new MySqlCommand(@"update Disciplinas
                        set Nome = @nome where Id = @id", connection);
                    comando.Parameters.AddWithValue("@nome", dados.Nome);
                    comando.Parameters.AddWithValue("@id", dados.Id);
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

        // GET: DisciplinasController/Delete/5
        public ActionResult Delete(int id)
        {
            DisciplinaEntidade model = new DisciplinaEntidade();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            var comando = new MySqlCommand("SELECT id, nome FROM disciplinas where Id = ?", connection);
            comando.Parameters.AddWithValue("?", id);
            using var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                model.Id = reader.GetInt32("id");
                model.Nome = reader.GetString("nome");
            }
            connection.Close();
            return View(model);
        }

        // POST: DisciplinasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DisciplinaEntidade dados)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var comando = new MySqlCommand(@"delete from Disciplinas
                        where Id = @id", connection);
                   
                    comando.Parameters.AddWithValue("@id", dados.Id);
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
    }
}
