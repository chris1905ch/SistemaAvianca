using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.DAL
{
    public class ClienteDAL
    {
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conn = Conexion.ObtenerConexion();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Cliente c = new Cliente
                {
                    ClienteID = (int)reader["ClienteID"],
                    Nombres = reader["Nombres"].ToString(),
                    Apellidos = reader["Apellidos"].ToString(),
                    Email = reader["Email"].ToString(),
                    NumeroDocumento = reader["NumeroDocumento"].ToString()
                };
                lista.Add(c);
            }

            conn.Close();
            return lista;
        }

        public static void AgregarCliente(Cliente c)
        {
            SqlConnection conn = Conexion.ObtenerConexion();
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (Nombres, Apellidos, Email, NumeroDocumento) VALUES (@N, @A, @E, @D)", conn);
            cmd.Parameters.AddWithValue("@N", c.Nombres);
            cmd.Parameters.AddWithValue("@A", c.Apellidos);
            cmd.Parameters.AddWithValue("@E", c.Email);
            cmd.Parameters.AddWithValue("@D", c.NumeroDocumento);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void ActualizarCliente(Cliente c)
        {
            SqlConnection conn = Conexion.ObtenerConexion();
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Clientes SET Nombres=@N, Apellidos=@A, Email=@E, NumeroDocumento=@D WHERE ClienteID=@ID", conn);
            cmd.Parameters.AddWithValue("@N", c.Nombres);
            cmd.Parameters.AddWithValue("@A", c.Apellidos);
            cmd.Parameters.AddWithValue("@E", c.Email);
            cmd.Parameters.AddWithValue("@D", c.NumeroDocumento);
            cmd.Parameters.AddWithValue("@ID", c.ClienteID);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void EliminarCliente(int id)
        {
            SqlConnection conn = Conexion.ObtenerConexion();
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Clientes WHERE ClienteID=@ID", conn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
