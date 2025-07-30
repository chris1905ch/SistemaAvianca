using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AviancaApp.DAL
{
    public class AvionDAL
    {
        private static string connectionString = "Server=HPDEJEF\\SQLEXPRESS;Database=AviancaDB;Trusted_Connection=True;";
        public static List<Avion> ObtenerTodos()
        {
            List<Avion> lista = new List<Avion>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Aviones";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Avion avion = new Avion
                    {
                        AvionID = (int)reader["AvionID"],
                        Modelo = reader["Modelo"].ToString(),
                        Capacidad = (int)reader["Capacidad"],
                        Matricula = reader["Matricula"].ToString(),
                        Estado = reader["Estado"].ToString()
                    };
                    lista.Add(avion);
                }
            }

            return lista;
        }

        public static void Insertar(Avion avion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Aviones (Modelo, Capacidad, Matricula, Estado) VALUES (@Modelo, @Capacidad, @Matricula, @Estado)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);
                cmd.Parameters.AddWithValue("@Capacidad", avion.Capacidad);
                cmd.Parameters.AddWithValue("@Matricula", avion.Matricula);
                cmd.Parameters.AddWithValue("@Estado", avion.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Avion avion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE Aviones SET Modelo = @Modelo, Capacidad = @Capacidad, Matricula = @Matricula, Estado = @Estado WHERE AvionID = @AvionID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);
                cmd.Parameters.AddWithValue("@Capacidad", avion.Capacidad);
                cmd.Parameters.AddWithValue("@Matricula", avion.Matricula);
                cmd.Parameters.AddWithValue("@Estado", avion.Estado);
                cmd.Parameters.AddWithValue("@AvionID", avion.AvionID);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Aviones WHERE AvionID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

