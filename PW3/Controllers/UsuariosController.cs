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

        /*
         
         

         public Usuario? BuscarPorId(int id)
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Open();

        var cmd = new MySqlCommand("SELECT id, nome FROM usuarios WHERE id = @id", connection);
        cmd.Parameters.AddWithValue("@id", id);
        using var reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            return new Usuario
            {
                Id = reader.GetInt32("id"),
                Nome = reader.GetString("nome")
            };
        }

        return null;
    }

    public List<Usuario> BuscarPorNome(string nome)
    {
        var usuarios = new List<Usuario>();

        using var connection = new MySqlConnection(_connectionString);
        connection.Open();

        var cmd = new MySqlCommand("SELECT id, nome FROM usuarios WHERE nome LIKE @nome", connection);
        cmd.Parameters.AddWithValue("@nome", $"%{nome}%");

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            usuarios.Add(new Usuario
            {
                Id = reader.GetInt32("id"),
                Nome = reader.GetString("nome")
            });
        }

        return usuarios;
    }
}

        */
    }
}
