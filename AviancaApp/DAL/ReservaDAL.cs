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
        public static void AgregarReserva(Reserva r)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Reservas 
                    (ClienteID, VueloID, TarifaID, FechaReserva, EstadoReserva)
                    VALUES (@C, @V, @T, GETDATE(), @E)", conn);

                cmd.Parameters.AddWithValue("@C", r.ClienteID);
                cmd.Parameters.AddWithValue("@V", r.VueloID);
                cmd.Parameters.AddWithValue("@T", r.TarifaID);
                cmd.Parameters.AddWithValue("@E", r.EstadoReserva);

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