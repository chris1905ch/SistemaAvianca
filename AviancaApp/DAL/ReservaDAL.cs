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

                SqlCommand cmd = new SqlCommand(@"INSERT INTO Reservas 
                    (ClienteID, VueloID, TarifaID, FechaReserva, EstadoReserva)
                    VALUES (@C, @V, @T, GETDATE(), @E)", conn);

                cmd.Parameters.AddWithValue("@C", r.ClienteID);
                cmd.Parameters.AddWithValue("@V", r.VueloID);
                cmd.Parameters.AddWithValue("@T", r.TarifaID);
                cmd.Parameters.AddWithValue("@E", r.EstadoReserva);

                cmd.ExecuteNonQuery();
            }
        }
    }
}