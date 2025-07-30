using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AviancaApp.DAL
{
    public class TripulacionDAL
    {
        private static string connectionString = "Data Source=.;Initial Catalog=AviancaDB;Integrated Security=True;";

        public static List<Tripulacion> ObtenerTodos()
        {
            List<Tripulacion> lista = new List<Tripulacion>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM TripulacionVuelo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tripulacion t = new Tripulacion
                    {
                        TripulacionID = Convert.ToInt32(reader["TripulacionID"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Cargo = reader["Cargo"].ToString(),
                        VueloID = Convert.ToInt32(reader["VueloID"])
                    };
                    lista.Add(t);
                }
            }

            return lista;
        }

        public static void Insertar(Tripulacion t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO TripulacionVuelo (Nombre, Apellido, Cargo, VueloID) VALUES (@Nombre, @Apellido, @Cargo, @VueloID)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", t.Apellido);
                cmd.Parameters.AddWithValue("@Cargo", t.Cargo);
                cmd.Parameters.AddWithValue("@VueloID", t.VueloID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Tripulacion t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE TripulacionVuelo SET Nombre = @Nombre, Apellido = @Apellido, Cargo = @Cargo, VueloID = @VueloID WHERE TripulacionID = @TripulacionID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", t.Apellido);
                cmd.Parameters.AddWithValue("@Cargo", t.Cargo);
                cmd.Parameters.AddWithValue("@VueloID", t.VueloID);
                cmd.Parameters.AddWithValue("@TripulacionID", t.TripulacionID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int tripulacionID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM TripulacionVuelo WHERE TripulacionID = @TripulacionID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TripulacionID", tripulacionID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}