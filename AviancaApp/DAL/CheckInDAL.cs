using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.DAL
{

    namespace AviancaApp.DAL
    {
        public static class CheckInDAL
        {
            public static bool RegistrarCheckIn(CheckIn c)
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO CheckIn 
                    (ReservaID, FechaCheckIn, NumeroAsientoAsignado)
                    VALUES (@R, GETDATE(), @A)", conn);

                    cmd.Parameters.AddWithValue("@R", c.ReservaID);
                    cmd.Parameters.AddWithValue("@A", c.NumeroAsientoAsignado);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }

            public static bool ExisteCheckIn(int reservaID)
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM CheckIn WHERE ReservaID = @R", conn);
                    cmd.Parameters.AddWithValue("@R", reservaID);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}



