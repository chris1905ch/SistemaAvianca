using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.DAL
{
    public static class UsuarioDAL
    {
        public static Usuario ValidarLogin(string usuario, string clave)
        {
            Usuario u = null;

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE Usuario = @usuario AND Clave = @clave", conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    u = new Usuario
                    {
                        UsuarioID = (int)reader["UsuarioID"],
                        UsuarioNombre = reader["Usuario"].ToString(),
                        Clave = reader["Clave"].ToString(),
                        Rol = reader["Rol"].ToString()
                    };
                }
            }

            return u;
        }
    }
}
