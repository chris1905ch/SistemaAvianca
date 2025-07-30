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
            public static List<Tarifa> ObtenerTarifasPorVuelo(int vueloID)
            {
                List<Tarifa> lista = new List<Tarifa>();

                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TarifaID, VueloID, ClaseAsiento, Precio, AsientosDisponibles FROM Tarifas WHERE VueloID = @VueloID", conn);
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
        }
}
