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
    public partial class FrmMembresia : Form
    {
        Conexion conexion = new Conexion();
        public int id;
        string Sexo = "";
        public FrmMembresia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtOcupacion.Clear();
            txtPago.Clear();
            txtTelefono.Clear();
            cmbTipo.Text = "";
            Sexo = "";
            rdFem.Checked = false;
            rdMas.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length == 0 || txtDireccion.Text.Length == 0 || txtEmail.Text.Length == 0 || txtNombre.Text.Length == 0 || txtOcupacion.Text.Length == 0 || txtPago.Text.Length ==0 || txtTelefono.Text.Length == 0 || cmbTipo.Text.Length == 0 || Sexo=="")
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conexion.agregar_miembro(txtNombre.Text, txtApellido.Text, txtOcupacion.Text, txtDireccion.Text, txtTelefono.Text, Sexo, txtEmail.Text, Convert.ToInt32(txtPago.Text), cmbTipo.Text);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdFem_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "Femenino";
        }

        private void rdMas_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "Masculino";
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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
