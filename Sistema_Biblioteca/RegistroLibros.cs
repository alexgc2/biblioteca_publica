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
    public partial class RegistroLibros : Form
    {
        string id_autor;
        Conexion conexion = new Conexion();
        public RegistroLibros()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 && txtArea.Text.Length > 0 && txtPerfil.Text.Length > 0)
            {
                if (conexion.autor_registrado(txtNombre.Text) == 0)
                {
                    conexion.agregar_autor(txtNombre.Text, txtArea.Text, txtPerfil.Text);
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

        private void gbAutor_Enter(object sender, EventArgs e)
        {
           
        }

        private void pContent_Paint(object sender, PaintEventArgs e)
        {
            toolTipAgregar.SetToolTip(btnAgregarAutor, "Agregar Nuevo Autor");
            toolTipBusqueda.SetToolTip(btnBuscarAutor, "Buscar Autor");
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0 || txtArea.Text.Length == 0 || txtPerfilCodigo.Text.Length == 0 || txtNombre.Text.Length == 0 || txtAño.Text.Length == 0 || txtCantidad.Text.Length == 0 || txtEdicion.Text.Length == 0 || txtEditorial.Text.Length == 0 || txtIsbn.Text.Length == 0 || txtProveedor.Text.Length == 0 || txtTitulo.Text.Length == 0 || txtPerfilCodigo.Text.Length == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conexion.agregar_libro(txtCodigo.Text, txtTitulo.Text, txtNombre.Text, txtEditorial.Text, txtEdicion.Text, txtArea.Text,txtPerfilCodigo.Text, txtPerfil.Text, Convert.ToInt32(txtIsbn.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtAño.Text), txtProveedor.Text, dtpFecha, id_autor);
                MessageBox.Show("Libro registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            ConsultarAutores ConsultarAutores = new ConsultarAutores(this);
            ConsultarAutores.Show();
        }

        public void RellenarAutor(string id_autor, string autor, string area, string perfil)
        {
            this.id_autor = id_autor;
            txtArea.Text = area;
            txtPerfil.Text = perfil;
            txtNombre.Text = autor;
        }
    }
}
