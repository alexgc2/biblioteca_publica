using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Biblioteca
{
    public partial class ConsultarTiposMembresias : Form
    {
        Conexion ObjQueries = new Conexion();
        public ConsultarTiposMembresias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarTiposMembresias_Load(object sender, EventArgs e)
        {
            dgvTipoMembresia.DataSource = ObjQueries.ConsultarTiposMembresias().Tables["tipo_membresia"];
        }
    }
}
