using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AviancaApp.Models;

namespace AviancaApp.DAL
{
    public class AeropuertoDAL
    {
        private static string cadena = "Server=HPDEJEF\\SQLEXPRESS;Database=AviancaDB;Trusted_Connection=True;";
        private static object ex;

        public static List<Aeropuerto> Obtener()
        {
            var lista = new List<Aeropuerto>();
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();
                string query = "SELECT * FROM Aeropuertos";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Aeropuerto
                    {
                        AeropuertoID = (int)reader["AeropuertoID"],
                        Nombre = reader["NombreAeropuerto"].ToString(),
                        Ciudad = reader["Ciudad"].ToString(),
                        Pais = reader["Pais"].ToString(),
                         CodigoIATA = reader["CodigoIATA"].ToString()
                    });
                }
            }
            return lista;
        }

        public static void Insertar(Aeropuerto aeropuerto)
        {
            try { 

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();
                string query = "INSERT INTO Aeropuertos (NombreAeropuerto, Ciudad, Pais, CodigoIATA) VALUES (@NombreAeropuerto, @Ciudad, @Pais, @CodigoIATA)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreAeropuerto", aeropuerto.Nombre);
                cmd.Parameters.AddWithValue("@Ciudad", aeropuerto.Ciudad);
                cmd.Parameters.AddWithValue("@Pais", aeropuerto.Pais);
                cmd.Parameters.AddWithValue("@CodigoIATA", aeropuerto.CodigoIATA);
                    cmd.ExecuteNonQuery();
            }
        }

            catch (Exception ex)
            {
                // Esto te dirá exactamente qué está fallando
                System.Windows.Forms.MessageBox.Show("Error al insertar aeropuerto: " + ex.Message);
            }
        }

        public static void Actualizar(Aeropuerto aeropuerto)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();
                string query = "UPDATE Aeropuertos SET Nombre = @NombreAeropuerto, Ciudad = @Ciudad, Pais = @Pais, CodigoIATA=@CodigoIATA WHERE AeropuertoID = @AeropuertoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreAeropuerto", aeropuerto.Nombre);
                cmd.Parameters.AddWithValue("@Ciudad", aeropuerto.Ciudad);
                cmd.Parameters.AddWithValue("@Pais", aeropuerto.Pais);
                cmd.Parameters.AddWithValue("@CodigoIATA", aeropuerto.CodigoIATA);
                cmd.Parameters.AddWithValue("@AeropuertoID", aeropuerto.AeropuertoID);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();
                string query = "DELETE FROM Aeropuertos WHERE AeropuertoID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

