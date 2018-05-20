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
    public partial class RegistroPrestamosLibros : Form
    {
        BuscarMiembros BuscarMiembros;
        BuscarLibro BuscarLibro;
        string id_libro;
        string respuesta;
        Conexion ObjQueries = new Conexion();
        public RegistroPrestamosLibros(Empleado EmpleadoActivo)
        {
            InitializeComponent();
            txtIDE.Text = EmpleadoActivo.Id;
        }

        private void dtFecha_onValueChanged(object sender, EventArgs e)
        {
            //Aqui se deberá cambiar el tiempo correspondiente a la fecha de entrega
        }

        private void btnBuscarMiembro_Click(object sender, EventArgs e)
        {
            BuscarMiembros = new BuscarMiembros(this);
            BuscarMiembros.Show();
        }

        public void CapturarMiembro(string id_miembro, string ocupacion_miembro, string tipo_membresia, string nombre_miembro, string apellidos_miembro)
        {
            txtIDM.Text = id_miembro;
            txtOcupacion.Text = ocupacion_miembro;
            txtTipo.Text = tipo_membresia;
            txtNombre.Text = nombre_miembro;
            txtApellidos.Text = apellidos_miembro;
        }
        
        public void CapturarLibro(string codigo, string nombre, string area, string autor, string edicion, string cantidad, string id_libro)
        {
            this.id_libro = id_libro;
            txtCodigo.Text = codigo;
            txtNombreLibro.Text = nombre;
            txtArea.Text = area;
            txtAutor.Text = autor;
            txtEdicion.Text = edicion;
            txtCantidad.Text = cantidad;
        }

        public void LimpiarLibro() {
            this.id_libro = null;
            txtCodigo.Text = "";
            txtNombreLibro.Text = "";
            txtArea.Text = "";
            txtAutor.Text = "";
            txtEdicion.Text = "";
            txtCantidad.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            BuscarLibro = new BuscarLibro(this);
            BuscarLibro.Show();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (txtIDE.Text.Length == 0 || txtCodigo.Text.Length == 0 || txtIDM.Text.Length == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            respuesta = ObjQueries.RegistrarPrestamoLibro(
                txtIDM.Text, id_libro, txtIDE.Text, dtFechaPrestamo.Value.ToShortDateString(), dtFechaEntrega.Value.ToShortDateString()
                );

            if (respuesta != "OK")
            {
                MessageBox.Show(respuesta, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Se realizó el prestamo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarLibro();
        }
    }
}
