using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.DAL
{
    public static class CheckInDAL
    {
        public static void RegistrarCheckIn(CheckIn c)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"INSERT INTO CheckIn 
            (ReservaID, FechaCheckIn, NumeroAsientoAsignado)
            VALUES (@R, GETDATE(), @A)", conn);

            cmd.Parameters.AddWithValue("@R", c.ReservaID);
            cmd.Parameters.AddWithValue("@A", c.NumeroAsientoAsignado);
            cmd.ExecuteNonQuery();
            }
        }
    }
}



