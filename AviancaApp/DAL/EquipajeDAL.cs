using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.DAL
{
    public static class EquipajeDAL
    {
        public static void AgregarEquipaje(Equipaje e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Equipaje (ReservaID, TipoEquipaje, Peso) VALUES (@ReservaID, @TipoEquipaje, @Peso)", conn);
                cmd.Parameters.AddWithValue("@ReservaID", e.ReservaID);
                cmd.Parameters.AddWithValue("@TipoEquipaje", e.TipoEquipaje);
                cmd.Parameters.AddWithValue("@Peso", e.Peso);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Equipaje> ObtenerEquipajes()
        {
            List<Equipaje> lista = new List<Equipaje>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT EquipajeID, ReservaID, TipoEquipaje, Peso FROM Equipaje", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Equipaje e = new Equipaje
                    {
                        EquipajeID = reader.GetInt32(0),
                        ReservaID = reader.GetInt32(1),
                        TipoEquipaje = reader.GetString(2),
                        Peso = reader.GetDecimal(3)
                    };
                    lista.Add(e);
                }
            }
            return lista;
        }
    }
}
