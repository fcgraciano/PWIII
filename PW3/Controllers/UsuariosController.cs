using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using PW3.Entidades;
using System.Collections.Generic;

namespace PW3.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly string connectionString = "Server=localhost;Database=aulabd2;Uid=root;Pwd=;";
        public IActionResult Index()
        {
            List<UsuarioEntidade> model = new List<UsuarioEntidade>();

            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            var cmd = new MySqlCommand("SELECT id, email FROM usuarios", connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                UsuarioEntidade u = new UsuarioEntidade();
                u.Id = reader.GetInt32("id");
                u.Email = reader.GetString("email");
                model.Add(u);
            }
            connection.Close();
            return View(model);
        }
       
        public IActionResult Create()
        {
            return View();
        }
    }
}
