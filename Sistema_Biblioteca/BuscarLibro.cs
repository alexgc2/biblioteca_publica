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
    public partial class BuscarLibro : Form
    {
        RegistroPrestamosLibros Caller;
        Conexion ObjQueries = new Conexion();
        DataGridViewCellCollection Row;
        public BuscarLibro(RegistroPrestamosLibros Caller)
        {
            InitializeComponent();
            this.Caller = Caller;
        }

        private void BuscarLibro_Load(object sender, EventArgs e)
        {
            dgvEquipos.DataSource =
                ObjQueries.ConsultarLibros(txtFiltro.Text).Tables["LIBROS"];
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Row = dgvEquipos.CurrentRow.Cells;

            Caller.CapturarLibro(
                Row[1].Value.ToString(),
                Row[4].Value.ToString(),
                Row[7].Value.ToString(),
                Row[3].Value.ToString(),
                Row[8].Value.ToString(),
                Row[6].Value.ToString(),
                Row[0].Value.ToString());
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BuscarLibro_Load(this, e);
        }
    }
}
