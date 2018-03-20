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
        List<string> Filtros;
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
            ModificarMembresia ModMm = new ModificarMembresia();
            ModMm.TopLevel = false;
            ModMm.Parent = pContent;
            ModMm.Show();
        }

        private void pContent_Paint(object sender, PaintEventArgs e)
        {
            dgvMiembros.AutoGenerateColumns = false;
            dgvMiembros.DataSource =
                ObjQueries.ConsultarMiembros(Filtros).Tables["membresia"];
        }

        private void dgvMiembros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarMembresia modMiembro = new ModificarMembresia();
            string aux = Convert.ToString(dgvMiembros.CurrentRow.Cells[0].Value);
            modMiembro.txtID.Text = aux;
            modMiembro.TopLevel = false;
            modMiembro.Parent = pContent;
            modMiembro.Show();
        }
    }
}
