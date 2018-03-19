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
    public partial class ModificarLibros : Form
    {
        Conexion conexion = new Conexion();
        public ModificarLibros()
        {
            InitializeComponent();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            //ConsultarLibros ConsLib = new ConsultarLibros();
            //ConsLib.TopLevel = false;
            //ConsLib.Show();
            this.Close();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            if (txtNombreM.Text.Length > 0 && txtAreaM.Text.Length > 0 && txtPerfilM.Text.Length > 0)
            {
                if (conexion.autor_registrado(txtNombreM.Text) == 0)
                {
                    conexion.agregar_autor(txtNombreM.Text, txtAreaM.Text, txtPerfilM.Text);
                    MessageBox.Show(this, "Autor agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show(this, "Imposible de registrar, ya existe el autor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Favor de ingresar todos los datos para registrar el autor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pContent_Paint(object sender, PaintEventArgs e)
        {
            toolTipAgregar.SetToolTip(btnAgregarAutor, "Agregar Nuevo Autor");
            toolTipBusqueda.SetToolTip(btnBuscarAutorM, "Buscar Autor");
            
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            if (txtCodigoM.Text.Length == 0 || txtAreaM.Text.Length == 0 || txtPerfilM.Text.Length == 0 || txtNombreM.Text.Length == 0 || txtAñoM.Text.Length == 0 || txtCantidadM.Text.Length == 0 || txtEdicionM.Text.Length == 0 || txtEditorialM.Text.Length == 0 || txtIsbnM.Text.Length == 0 || txtProveedorM.Text.Length == 0 || txtTituloM.Text.Length == 0 || cbxEstatus.Text.Length ==0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conexion.modificar_libro(txtCodigoM.Text, txtTituloM.Text, txtNombreM.Text, txtEditorialM.Text, txtEdicionM.Text, txtAreaM.Text, txtPerfilM.Text, Convert.ToInt32(txtIsbnM.Text), Convert.ToInt32(txtCantidadM.Text), Convert.ToInt32(txtAñoM.Text), txtProveedorM.Text,cbxEstatus.Text);
                MessageBox.Show("Se modificaron los datos correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gbAutor_Enter(object sender, EventArgs e)
        {

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

        private void txtAreaM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPerfilM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAñoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIsbnM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigoM_TextChanged(object sender, EventArgs e)
        {
            conexion.llenarModificarLibro(txtCodigoM, txtTituloM, txtNombreM, txtEditorialM, txtEdicionM, txtAreaM, txtPerfilM, txtIsbnM, txtCantidadM, txtAñoM, txtProveedorM, cbxEstatus, txtFecha);
        }
    }
}
