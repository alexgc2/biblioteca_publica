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
    public partial class Tipo_Membresias : Form
    {
        Conexion conexion = new Conexion();
        public Tipo_Membresias()
        {
            InitializeComponent();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || txtDescripcion.Text.Length == 0 || txtPrecio.Text.Length == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conexion.agregar_TipoMembresia(txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(txtPrecio.Text));
                MessageBox.Show("Autor agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtDescripcion.Text = "";
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPrecio.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }
    }
}
