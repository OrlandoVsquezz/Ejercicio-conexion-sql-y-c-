using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexión
{
    public class ConexionDB
    {
        private static string servidor = "LAB03-DS-EQ06\\SQLEXPRESS";
        private static string basededatos = "dbHospital";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data Source = {servidor}; Initial Catalog = {basededatos}; Integrated Security = true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
