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
    public partial class Modificar_Miembro : Form
    {
        Conexion conexion = new Conexion();
        string sexo = "";
        string sexo1="";
        public Modificar_Miembro()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
            if (sexo == "masculino")
            {
                rdFem.Checked = true;
            }
            else if (sexo == "femenino")
            {
                rdMas.Checked = true;
            }
        }

        private void Modificar_Miembro_Load(object sender, EventArgs e)
        {
         
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length == 0 || txtDireccion.Text.Length == 0 || txtEmail.Text.Length == 0 || txtNombre.Text.Length == 0 || txtOcupacion.Text.Length == 0 || txtPago.Text.Length == 0 || txtTelefono.Text.Length == 0 || cmbTipo.Text.Length == 0 || sexo1 == "")
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                MessageBox.Show("Miembro registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Clear();
                txtDireccion.Clear();
                txtEmail.Clear();
                txtNombre.Clear();
                txtOcupacion.Clear();
                txtPago.Clear();
                txtTelefono.Clear();
                cmbTipo.Text = "";
            }
        }
    }
}
