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
    public partial class ConsultaMembresia : Form
    {
        Conexion ObjQueries = new Conexion();
        public ConsultaMembresia()
        {
            InitializeComponent();
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            RegistroMembresia RegMem = new RegistroMembresia();
            RegMem.TopLevel = false;
            RegMem.Parent = pContent;
            RegMem.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarM_Click(object sender, EventArgs e)
        {
            ModificarMembresia ModMm = new ModificarMembresia("");
            ModMm.TopLevel = false;
            ModMm.Parent = pContent;
            ModMm.Show();
        }

        private void pContent_Paint(object sender, PaintEventArgs e)
        {
            dgvMiembros.AutoGenerateColumns = false;
            dgvMiembros.DataSource =
                ObjQueries.ConsultarMiembros(txtNombre.Text).Tables["membresia"];
        }

        private void dgvMiembros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string aux = Convert.ToString(dgvMiembros.CurrentRow.Cells[0].Value);
            ModificarMembresia modMiembro = new ModificarMembresia(aux);
            modMiembro.TopLevel = false;
            modMiembro.Parent = pContent;
            modMiembro.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dgvMiembros.DataSource = ObjQueries.ConsultarMiembros(txtNombre.Text).Tables["membresia"];
        }
    }
}
