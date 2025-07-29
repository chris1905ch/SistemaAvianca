using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.DAL
{
    public class VueloDAL
    {
        public static List<Vuelo> ObtenerVuelos()
        {
            List<Vuelo> lista = new List<Vuelo>();
            SqlConnection conn = Conexion.ObtenerConexion();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Vuelos", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Vuelo v = new Vuelo
                {
                    VueloID = (int)reader["VueloID"],
                    NumeroVuelo = reader["NumeroVuelo"].ToString(),
                    RutaID = (int)reader["RutaID"],
                    AvionID = (int)reader["AvionID"],
                    FechaSalida = Convert.ToDateTime(reader["FechaSalida"]),
                    FechaLlegada = Convert.ToDateTime(reader["FechaLlegada"]),
                    EstadoVuelo = reader["EstadoVuelo"].ToString()
                };
                lista.Add(v);
            }

            conn.Close();
            return lista;
        }

        public static void AgregarVuelo(Vuelo v)
        {
            SqlConnection conn = Conexion.ObtenerConexion();
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"INSERT INTO Vuelos 
                (NumeroVuelo, RutaID, AvionID, FechaSalida, FechaLlegada, EstadoVuelo)
                VALUES (@Numero, @RutaID, @AvionID, @Salida, @Llegada, @Estado)", conn);

            cmd.Parameters.AddWithValue("@Numero", v.NumeroVuelo);
            cmd.Parameters.AddWithValue("@RutaID", v.RutaID);
            cmd.Parameters.AddWithValue("@AvionID", v.AvionID);
            cmd.Parameters.AddWithValue("@Salida", v.FechaSalida);
            cmd.Parameters.AddWithValue("@Llegada", v.FechaLlegada);
            cmd.Parameters.AddWithValue("@Estado", v.EstadoVuelo);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void EliminarVuelo(int id)
        {
            SqlConnection conn = Conexion.ObtenerConexion();
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Vuelos WHERE VueloID=@ID", conn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
