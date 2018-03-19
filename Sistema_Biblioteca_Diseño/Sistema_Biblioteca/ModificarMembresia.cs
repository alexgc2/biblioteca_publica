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
    public partial class ModificarMembresia : Form
    {
        Conexion conexion = new Conexion();
        public string sexo = "";
      
        public ModificarMembresia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarMiembro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdFem_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "FEMENINO";
        }

        private void rdMas_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "MASCULINO";
        }

        private void txtNombreM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtOcupacionM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefonoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pContent_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnModificarMem_Click(object sender, EventArgs e)
        {
            if (txtApellidoM.Text.Length == 0 || txtDireccionM.Text.Length == 0 || txtEmailM.Text.Length == 0 || txtNombreM.Text.Length == 0 || txtOcupacionM.Text.Length == 0 || txtPrecioM.Text.Length == 0 || txtTelefonoM.Text.Length == 0 || txtTipoMm.Text.Length == 0 || sexo == "" || cbxEstatus.Text.Length == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conexion.modificar_miembro(Convert.ToInt32(txtID.Text),txtNombreM.Text, txtApellidoM.Text, txtOcupacionM.Text, txtDireccionM.Text, txtTelefonoM.Text, sexo, txtEmailM.Text, Convert.ToInt32(txtPrecioM.Text), txtTipoMm.Text,cbxEstatus.Text);
                MessageBox.Show("Se modificaron los datos correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            conexion.llenarModificarMiembro(Convert.ToInt32(txtID.Text), sexo, txtNombreM, txtApellidoM, txtTipoMm, txtTelefonoM, txtDireccionM, txtEmailM, txtOcupacionM, txtPrecioM, cbxEstatus);
        }

        
    }
}
