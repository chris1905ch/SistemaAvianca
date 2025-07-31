using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.DAL
{
    public static class ReservaDAL
    {
        private static string cadenaConexion = "Server=HPDEJEF\\SQLEXPRESS;Database=AviancaDB;Trusted_Connection=True;";


        public static void AgregarReserva(Reserva r)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string sql = "INSERT INTO Reservas (ClienteID, VueloID, TarifaID, EstadoReserva, FechaReserva) " +
                             "VALUES (@ClienteID, @VueloID, @TarifaID, @EstadoReserva, @FechaReserva)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ClienteID", r.ClienteID);
                cmd.Parameters.AddWithValue("@VueloID", r.VueloID);
                cmd.Parameters.AddWithValue("@TarifaID", r.TarifaID);
                cmd.Parameters.AddWithValue("@EstadoReserva", r.EstadoReserva);
                cmd.Parameters.AddWithValue("@FechaReserva", r.FechaReserva);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public static List<Reserva> ObtenerReservasPendientesCheckIn()
        {
            List<Reserva> lista = new List<Reserva>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                    SELECT r.ReservaID, c.Nombres + ' ' + c.Apellidos AS NombrePasajero
                    FROM Reservas r
                    INNER JOIN Clientes c ON r.ClienteID = c.ClienteID
                    WHERE r.EstadoReserva = 'Confirmada'
                    AND NOT EXISTS (SELECT 1 FROM CheckIn ci WHERE ci.ReservaID = r.ReservaID)
                ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Reserva
                    {
                        ReservaID = (int)reader["ReservaID"],
                        NombrePasajero = reader["NombrePasajero"].ToString()
                    });
                }
            }

            return lista;
        }

        // Nuevo método para obtener todas las reservas
        public static List<Reserva> ObtenerReservas()
        {
            List<Reserva> lista = new List<Reserva>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT ReservaID, ClienteID, VueloID, TarifaID, FechaReserva, EstadoReserva 
                    FROM Reservas", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Reserva
                    {
                        ReservaID = (int)reader["ReservaID"],
                        ClienteID = (int)reader["ClienteID"],
                        VueloID = (int)reader["VueloID"],
                        TarifaID = (int)reader["TarifaID"],
                        FechaReserva = (DateTime)reader["FechaReserva"],
                        EstadoReserva = reader["EstadoReserva"].ToString()
                    });
                }
            }

            return lista;
        }
    }
}