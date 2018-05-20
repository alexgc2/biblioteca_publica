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
    public partial class BuscarEquipo : Form
    {
        RegistroPrestamoEquipos Caller;
        Conexion ObjQueries = new Conexion();
        DataGridViewCellCollection Row;
        public BuscarEquipo(RegistroPrestamoEquipos Caller)
        {
            InitializeComponent();
            this.Caller = Caller;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BuscarEquipo_Load(this,e);
        }


        private void BuscarEquipo_Load(object sender, EventArgs e)
        {
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquipos.DataSource =
                ObjQueries.ConsultarEquipo(txtFiltro.Text).Tables["COMPUTADORAS"];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Row = dgvEquipos.CurrentRow.Cells;
            Caller.CapturarEquipo(
                Row[0].Value.ToString(),
                Row[1].Value.ToString(),
                Row[2].Value.ToString()
            );
            Close();
        }
    }
}
