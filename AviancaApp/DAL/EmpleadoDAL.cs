using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AviancaApp.DAL
{
    public class EmpleadoDAL
    {
        private static string connectionString = "Data Source=HPDEJEF\\SQLEXPRESS;Initial Catalog=AviancaDB;Integrated Security=True";

        public static List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Empleados";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Empleado emp = new Empleado
                    {
                        EmpleadoID = (int)reader["EmpleadoID"],
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Rol = reader["Rol"].ToString()
                    };
                    lista.Add(emp);
                }
            }

            return lista;
        }

        public static void Insertar(Empleado e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Empleados (Nombres, Apellidos, Rol) VALUES (@Nombres, @Apellidos, @Rol)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nombres", e.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@Rol", e.Rol);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Empleado e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Empleados SET Nombres = @Nombres, Apellidos = @Apellidos, Rol = @Rol WHERE EmpleadoID = @EmpleadoID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nombres", e.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@Rol", e.Rol);
                cmd.Parameters.AddWithValue("@EmpleadoID", e.EmpleadoID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Empleados WHERE EmpleadoID = @EmpleadoID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@EmpleadoID", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

