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
    public partial class RegistroEmpleado : Form
    {
        string respuesta;
        Conexion ObjQueries = new Conexion();
        public RegistroEmpleado()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.isPassword = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(this, e);
        }
        
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(this, e);
        }

        private void ValidarLetras(object sender, KeyPressEventArgs e)
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

        private void btnAgregarMembresia_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtDireccion.Text.Length == 0 
                || txtContraseña.Text.Length == 0|| txtTelefono.Text.Length == 0 || dtFechaNaci.Value == null)
            {
                MessageBox.Show("Favor de completar el formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            respuesta = ObjQueries.agregar_empleado(txtNombre.Text, txtApellido.Text, txtDireccion.Text,
                txtContraseña.Text, dtFechaNaci.Value.ToShortDateString(), ddSexo.selectedValue, txtTelefono.Text);

            if (respuesta != "OK")
            {
                MessageBox.Show(respuesta, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("Se registró el empleado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
