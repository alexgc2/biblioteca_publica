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
    public partial class Consultar_libro : Form
    {
        Conexion ObjQueries = new Conexion();
        List<string> Filtros;
        public Consultar_libro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Filtros = new List<string>();

            Filtros.Add(txtNombre.Text);
            Filtros.Add(cboAutor.Text);
            Filtros.Add(cboEditorial.Text);
            Filtros.Add(dtpFecha.Text);

            Consultar_libro_Load(this, e);
        }

        private void Consultar_libro_Load(object sender, EventArgs e)
        {
            dgvLibros.AutoGenerateColumns = false;
            dgvLibros.DataSource =
                ObjQueries.ConsultarLibros(Filtros).Tables["LIBROS"];
        }
    }
}
