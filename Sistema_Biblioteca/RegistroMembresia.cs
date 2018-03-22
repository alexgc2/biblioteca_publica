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
    public partial class RegistroMembresia : Form
    {
        Conexion conexion = new Conexion();
        string sexo = "";
        public RegistroMembresia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdFem_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "FEMENINO";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text.Length > 0 && txtPrecio.Text.Length > 0)
            {
                if (conexion.membresia_registrada(txtTipo.Text) == 0)
                {
                    conexion.agregar_TipoMembresia(txtTipo.Text, Convert.ToInt32(txtPrecio.Text));
                    MessageBox.Show(this, "Registro Exitoso", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show(this, "Imposible de registrar, ya existe una membresia con los mismos datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Favor de ingresar todos los datos para registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pContente_Paint(object sender, PaintEventArgs e)
        {
            toolTip1.SetToolTip(btnAgregar, "Agregar Nuevo Tipo de Membresia");
            toolTip2.SetToolTip(btnBuscar, "Buscar Membresias");
        }

        private void btnAgregarMembresia_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length == 0 || txtDireccion.Text.Length == 0 || txtEmail.Text.Length == 0 || txtNombre.Text.Length == 0 || txtOcupacion.Text.Length == 0 || txtPrecio.Text.Length == 0 || txtTelefono.Text.Length == 0 || txtTipo.Text.Length == 0 || sexo == "")
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conexion.agregar_miembro(txtNombre.Text, txtApellido.Text, txtOcupacion.Text, txtDireccion.Text, txtTelefono.Text, sexo, txtEmail.Text, Convert.ToInt32(txtPrecio.Text), txtTipo.Text);
                MessageBox.Show("Miembro registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Clear();
                txtDireccion.Clear();
                txtEmail.Clear();
                txtNombre.Clear();
                txtOcupacion.Clear();
                txtPrecio.Clear();
                txtTelefono.Clear();
                txtTipo.Clear();
                sexo = "";
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

        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void rdMas_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "MASCULINO";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarTiposMembresias ConsultarTiposMembresias = new ConsultarTiposMembresias(this);
            ConsultarTiposMembresias.Show();
        }

        public void RellenarTipoMembresia(string tipo, string precio)
        {
            txtTipo.Text = tipo;
            txtPrecio.Text = precio;
        }
    }
}
