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
    }
}
