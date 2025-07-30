using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

public class Conexion
{
    public static SqlConnection ObtenerConexion()
    {
        string cadena = "Server=HPDEJEF\\SQLEXPRESS;Database=AviancaDB;Trusted_Connection=True;";
        return new SqlConnection(cadena);
    }
}
