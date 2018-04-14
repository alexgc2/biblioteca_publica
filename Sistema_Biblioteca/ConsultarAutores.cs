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
        ModificarLibros Mod;
        RegistroLibros Reg;
        DataGridViewCellCollection Celda;
        public ConsultarAutores(ModificarLibros Caller)
        {
            InitializeComponent();
            this.Mod = Caller;
        }
        public ConsultarAutores(RegistroLibros Caller) {
            InitializeComponent();
            this.Reg = Caller;
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

        private void dgvAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Celda = dgvAutores.CurrentRow.Cells;
            if (Mod == null)
                Reg.RellenarAutor(Celda[0].Value.ToString(), Celda[1].Value.ToString(), Celda[2].Value.ToString(), Celda[3].Value.ToString());
            else
                Mod.RellenarAutor(Celda[0].Value.ToString(), Celda[1].Value.ToString(), Celda[2].Value.ToString(), Celda[3].Value.ToString());

            this.Close();
        }
    }
}
