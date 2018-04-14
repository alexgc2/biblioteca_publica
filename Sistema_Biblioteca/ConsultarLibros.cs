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
    public partial class ConsultarLibros : Form
    {
        Conexion ObjQueries = new Conexion();
        public ConsultarLibros()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            RegistroLibros RegLib = new RegistroLibros();
            RegLib.TopLevel = false;
            RegLib.Parent = pContent;
            RegLib.Show();
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            ModificarLibros ModLib = new ModificarLibros();
            ModLib.TopLevel = false;
            ModLib.Parent = pContent;
            ModLib.Show();
        }

        private void pContent_Paint(object sender, PaintEventArgs e)
        {
            dgvLibros.AutoGenerateColumns = false;
            dgvLibros.DataSource =
                ObjQueries.ConsultarLibros(txtBuscar.Text).Tables["LIBROS"];

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dgvLibros.DataSource = ObjQueries.ConsultarLibros(txtBuscar.Text).Tables["Libros"];
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarLibros modLibro = new ModificarLibros();
            string aux = Convert.ToString(dgvLibros.CurrentRow.Cells[0].Value);
            modLibro.txtCodigoM.Text = aux;
            modLibro.TopLevel = false;
            modLibro.Parent = pContent;
            modLibro.Show();
        }
    }
}
