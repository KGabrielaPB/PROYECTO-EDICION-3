using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BINAES
{
    internal class UsuarioDAO
    {
        public static Usuario revisarCredenciales(string usuario, string contrasennia)
        {
            string cadena = "Data Source=GABRIELA-DESKTO;Initial Catalog=PROYECTOv17;Integrated Security=True";
            Usuario usu = new Usuario();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "select u.nombre,u.email,r.texto rol from USUARIO u INNER JOIN ROL r ON u.id_rol = r.id WHERE u.email = @email AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", usuario);
                command.Parameters.AddWithValue("@password", contrasennia);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usu.nombre = reader["nombre"].ToString();
                        usu.email = reader["email"].ToString();
                        usu.rol = reader["rol"].ToString();
                    }
                }
                connection.Close();
            }
            return usu;
        }
    }
}
