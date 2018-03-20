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
    public partial class ConsultarAutores : Form
    {
        Conexion ObjQueries = new Conexion();
        public ConsultarAutores()
        {
            InitializeComponent();
        }

        private void dgvAutores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ConsultarAutores_Load(this, e);   
        }

        private void ConsultarAutores_Load(object sender, EventArgs e)
        {
            dgvAutores.DataSource = ObjQueries.ConsultarAutores(txtFiltro.Text).Tables["autores"];
        }
    }
}
