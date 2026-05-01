using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DATOS
{
    public class UsuarioDAO
    {
        public void Insertar(Usuario u)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();

                string query = "INSERT INTO Usuario (Nombre, Rol, Contrasena) VALUES (@n, @r, @c)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@n", u.Nombre);
                cmd.Parameters.AddWithValue("@r", u.Rol);
                cmd.Parameters.AddWithValue("@c", u.Contrasena);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Usuario> Listar()
        {
            var lista = new List<Usuario>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();

                string query = "SELECT * FROM Usuario";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.IdUsuario = (int)dr["IdUsuario"];
                    u.Nombre = dr["Nombre"].ToString();
                    u.Rol = dr["Rol"].ToString();
                    u.Contrasena = dr["Contrasena"].ToString();

                    lista.Add(u);
                }
            }

            return lista;
        }
    }
}
