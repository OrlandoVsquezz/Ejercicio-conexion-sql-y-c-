using Modelo.Conexión;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Doctor
    {

        private int idDoctor;
        private string nombre;
        private string apellido;
        private string especialidad;
        private string cargo;

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        // Metodo para mostrar la información

        public static DataTable CargarDoctores()
        {
            // Necesioto traer la conexion
            SqlConnection conexion = ConexionDB.Conectar();
            // Vamos a crear el query
            string consultaQuery = "select nombre, apellido, especialidad, cargo from Doctores";
            // Creamos un lugar donde podamos rellenar la data table por medio del metodo fill
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataVirtual = new DataTable();
            // Vamos a llenar el data adapter pasandole una data virtual
            add.Fill(dataVirtual);
            return dataVirtual;
        }

    }
}
