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
    public partial class Agregar_Autor : Form
    {
        Conexion conexion = new Conexion();
        public Agregar_Autor()
        {
            InitializeComponent();
        }

        private void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxArea_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxArea.SelectedIndex == 0)
            {
                cbxPerfil.Items.Clear();
                cbxPerfil.Items.Add("Matematicas");
                cbxPerfil.Items.Add("Ciencias");
                cbxPerfil.Items.Add("Computacion");
                cbxPerfil.Items.Add("Historia");
                cbxPerfil.Items.Add("Sociales");
            }
            else if (cbxArea.SelectedIndex == 1)
            {
                cbxPerfil.Items.Clear();
                cbxPerfil.Items.Add("Aventuras");
                cbxPerfil.Items.Add("Ciencia ficcion");
                cbxPerfil.Items.Add("Fantasia");
                cbxPerfil.Items.Add("Policiaco");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || cbxArea.Text.Length == 0 || cbxPerfil.Text.Length == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conexion.agregar_autor(txtNombre.Text,cbxArea.Text, cbxPerfil.Text);
                MessageBox.Show("Autor agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                cbxArea.Text = "";
                cbxPerfil.Text = "";
            }
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtColaboracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            cbxArea.Text = "";
            cbxPerfil.Text = "";
        }
    }
}
