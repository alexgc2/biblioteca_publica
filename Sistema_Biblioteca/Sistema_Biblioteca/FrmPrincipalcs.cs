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
    public partial class FrmPrincipalcs : Form
    {
        public FrmPrincipalcs()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void moidificarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Libro registroLibro = new Registro_Libro();
            registroLibro.Show();
        }

        private void modificarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_libro ModLibro = new Modificar_libro();
            ModLibro.Show();
        }

        private void agregarMiembroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AgregarMiembro = new Form1();
            AgregarMiembro.Show();
        }

        private void modificarMiembroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Miembro Modmiembro = new Modificar_Miembro();
            Modmiembro.Show();
        }

        private void agregarTipoDeMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Membresias tipo = new Tipo_Membresias();
            tipo.Show();
        }
    }
}
