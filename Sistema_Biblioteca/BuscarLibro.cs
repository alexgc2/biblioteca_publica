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
        RegistroPrestamos Caller;
        Conexion ObjQueries = new Conexion();
        DataGridViewCellCollection Celda;
        public BuscarLibro(RegistroPrestamos Caller)
        {
            InitializeComponent();
            this.Caller = Caller;
        }

        private void BuscarLibro_Load(object sender, EventArgs e)
        {
            dgvLibros.DataSource =
                ObjQueries.ConsultarLibros(txtFiltro.Text).Tables["LIBROS"];
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Celda = dgvLibros.CurrentRow.Cells;
            Caller.CapturarLibro(
                Celda[0].Value.ToString(),
                Celda[3].Value.ToString(),
                Celda[6].Value.ToString(),
                Celda[2].Value.ToString(),
                Celda[7].Value.ToString(),
                Celda[5].Value.ToString(),
                Celda[8].Value.ToString());
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BuscarLibro_Load(this, e);
        }
    }
}
