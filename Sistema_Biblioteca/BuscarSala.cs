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
    public partial class BuscarSala : Form
    {
        Conexion ObjQueries = new Conexion();
        RegistroPrestamoSalas Caller;
        DataGridViewCellCollection Celda;
        public BuscarSala(RegistroPrestamoSalas Caller)
        {
            InitializeComponent();
            this.Caller = Caller;
        }

        private void BuscarSala_Load(object sender, EventArgs e)
        {
            dgvSalas.DataSource = ObjQueries.ConsultarSala(txtFiltro.Text).Tables["SALAS"];
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuscarSala_Load(this, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSalas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Celda = dgvSalas.CurrentRow.Cells;
            Caller.CapturarSala(
                Celda[0].Value.ToString(),
                Celda[1].Value.ToString(),
                Celda[2].Value.ToString(),
                Celda[3].Value.ToString()
            );
            Close();
            return;
        }
    }
}
