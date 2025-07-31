using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.DAL
{
    public class RutaDAL
    {
        private static string connectionString = "Server=HPDEJEF\\SQLEXPRESS;Database=AviancaDB;Trusted_Connection=True;";

        public static List<Ruta> ObtenerTodas()
        {
            List<Ruta> lista = new List<Ruta>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Rutas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ruta r = new Ruta
                    {
                        RutaID = (int)reader["RutaID"],
                        AeropuertoOrigenID = (int)reader["AeropuertoOrigenID"],
                        AeropuertoDestinoID = (int)reader["AeropuertoDestinoID"]
                    };
                    lista.Add(r);
                }
            }
            return lista;
        }

        public static void Insertar(Ruta r)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Rutas (AeropuertoOrigenID, AeropuertoDestinoID) VALUES (@origen, @destino)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@origen", r.AeropuertoOrigenID);
                cmd.Parameters.AddWithValue("@destino", r.AeropuertoDestinoID);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Ruta r)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE Rutas SET AeropuertoOrigenID=@origen, AeropuertoDestinoID=@destino WHERE RutaID=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@origen", r.AeropuertoOrigenID);
                cmd.Parameters.AddWithValue("@destino", r.AeropuertoDestinoID);
                cmd.Parameters.AddWithValue("@id", r.RutaID);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Rutas WHERE RutaID=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        internal static List<Ruta> ObtenerRutas()
        {
            return ObtenerTodas();
        }
       
    }
}


