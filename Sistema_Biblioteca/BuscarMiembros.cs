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
    public partial class BuscarMiembros : Form
    {
        Conexion ObjQueries = new Conexion();
        RegistroPrestamos Caller;
        DataGridViewCellCollection Celda;
        public BuscarMiembros(RegistroPrestamos Caller)
        {
            InitializeComponent();
            this.Caller = Caller;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BuscarMiembros_Load(this, e);
        }

        private void dgvAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Celda = dgvMiembros.CurrentRow.Cells;
            Caller.CapturarMiembro(Celda[0].Value.ToString(), Celda[1].Value.ToString(), Celda[2].Value.ToString(), Celda[3].Value.ToString(), Celda[4].Value.ToString());
            this.Close();
        }

        private void BuscarMiembros_Load(object sender, EventArgs e)
        {
            dgvMiembros.DataSource = ObjQueries.ConsultarMiembros(txtFiltro.Text).Tables["membresia"];
        }
    }
}
