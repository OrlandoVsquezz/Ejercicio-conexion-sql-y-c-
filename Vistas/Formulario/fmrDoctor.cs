using System;
using Modelo.Entidades; // Esto por si no sale la clase, en este caso fue lo de Doctor
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formulario
{
    public partial class fmrDoctor : Form
    {
        public fmrDoctor()
        {
            InitializeComponent();
        }

        private void MostrarDoctores()
        {
            dgvDatosDoctores.DataSource = null;
            dgvDatosDoctores.DataSource = Doctor.CargarDoctores();
        }

        private void fmrDoctor_Load(object sender, EventArgs e)
        {
            MostrarDoctores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Una instancia es un objeto (crear un objeto)
            // Creamos el objeto doctor para mandar la informacion del formulario por el metodo set 
            Doctor Doc = new Doctor();
            Doc.Nombre = txtNombre.Text;
            Doc.Apellido = txtApellido.Text;
            Doc.Especialidad = txtEspecialidad.Text;
            Doc.Cargo = txtCargo.Text;
            Doc.InsertarDoctores();
            limpiarCampoRegistrado();
            MostrarDoctores();
        }

        private void limpiarCampoRegistrado()
        {
            MessageBox.Show("Registro exitoso");
            txtApellido.Clear();
            txtCargo.Clear();
            txtEspecialidad.Clear();
            txtNombre.Clear();
        }



    }
}
