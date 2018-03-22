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
    public partial class ConsultarTiposMembresias : Form
    {
        Conexion ObjQueries = new Conexion();
        RegistroMembresia reg;
        ModificarMembresia mod;
        DataGridViewCellCollection Celda;
        public ConsultarTiposMembresias(RegistroMembresia reg)
        {
            InitializeComponent();
            this.reg = reg;
        }
        public ConsultarTiposMembresias(ModificarMembresia mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarTiposMembresias_Load(object sender, EventArgs e)
        {
            dgvTipoMembresia.DataSource = ObjQueries.ConsultarTiposMembresias().Tables["tipo_membresia"];
        }

        private void dgvTipoMembresia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Celda = dgvTipoMembresia.CurrentRow.Cells;
            if (mod == null)
                reg.RellenarTipoMembresia(Celda[0].Value.ToString(), Celda[1].Value.ToString());
            else
                mod.RellenarTipoMembresia(Celda[0].Value.ToString(), Celda[1].Value.ToString(), "ACTIVO");

            this.Close();
        }
    }
}
