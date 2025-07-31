using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviancaApp.Models;

namespace AviancaApp.DAL
{

    public static class TarifaDAL
    {
        public static void Agregar(Tarifa tarifa)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tarifas (VueloID, ClaseAsiento, Precio, AsientosDisponibles) VALUES (@VueloID, @ClaseAsiento, @Precio, @AsientosDisponibles)", conn);
                cmd.Parameters.AddWithValue("@VueloID", tarifa.VueloID);
                cmd.Parameters.AddWithValue("@ClaseAsiento", tarifa.ClaseAsiento);
                cmd.Parameters.AddWithValue("@Precio", tarifa.Precio);
                cmd.Parameters.AddWithValue("@AsientosDisponibles", tarifa.AsientosDisponibles);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Tarifa tarifa)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Tarifas SET VueloID=@VueloID, ClaseAsiento=@ClaseAsiento, Precio=@Precio, AsientosDisponibles=@AsientosDisponibles WHERE TarifaID=@TarifaID", conn);
                cmd.Parameters.AddWithValue("@TarifaID", tarifa.TarifaID);
                cmd.Parameters.AddWithValue("@VueloID", tarifa.VueloID);
                cmd.Parameters.AddWithValue("@ClaseAsiento", tarifa.ClaseAsiento);
                cmd.Parameters.AddWithValue("@Precio", tarifa.Precio);
                cmd.Parameters.AddWithValue("@AsientosDisponibles", tarifa.AsientosDisponibles);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tarifas WHERE TarifaID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Tarifa> ObtenerTodos()
        {
            List<Tarifa> lista = new List<Tarifa>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TarifaID, VueloID, ClaseAsiento, Precio, AsientosDisponibles FROM Tarifas", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tarifa t = new Tarifa
                    {
                        TarifaID = reader.GetInt32(0),
                        VueloID = reader.GetInt32(1),
                        ClaseAsiento = reader.GetString(2),
                        Precio = reader.GetDecimal(3),
                        AsientosDisponibles = reader.GetInt32(4)
                    };
                    lista.Add(t);
                }
            }
            return lista;
        }

        public static List<Tarifa> ObtenerTarifasPorVuelo(int vueloID)
        {
            List<Tarifa> lista = new List<Tarifa>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TarifaID, VueloID, ClaseAsiento, Precio, AsientosDisponibles FROM Tarifas WHERE VueloID = @vueloID", conn);
                cmd.Parameters.AddWithValue("@vueloID", vueloID);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tarifa t = new Tarifa
                    {
                        TarifaID = reader.GetInt32(0),
                        VueloID = reader.GetInt32(1),
                        ClaseAsiento = reader.GetString(2),
                        Precio = reader.GetDecimal(3),
                        AsientosDisponibles = reader.GetInt32(4)
                    };
                    lista.Add(t);
                }
            }

            return lista;
        }

        public static List<string> ObtenerAsientosDisponiblesPorVuelo(int vueloID)
        {
            List<string> asientos = new List<string>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string sql = @"
            SELECT t.NumeroAsiento
            FROM Tarifas t
            WHERE t.VueloID = @VueloID
            AND t.TarifaID NOT IN (
                SELECT r.TarifaID
                FROM CheckIn ci
                INNER JOIN Reservas r ON ci.ReservaID = r.ReservaID
            )";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@VueloID", vueloID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    asientos.Add(reader["NumeroAsiento"].ToString());
                }
            }

            return asientos;
        }


    }
}
