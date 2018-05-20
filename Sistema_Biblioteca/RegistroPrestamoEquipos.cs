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
    public partial class RegistroPrestamoEquipos : Form
    {
        BuscarEquipo BuscarEquipos;
        BuscarMiembros BuscarMiembros;
        Conexion ObjQueries = new Conexion();
        private string respuesta;

        public RegistroPrestamoEquipos(Empleado EmpleadoActivo)
        {
            InitializeComponent();
            txtIDE.Text = EmpleadoActivo.Id;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pContent_Paint(object sender, PaintEventArgs e)
        {
            Tiempo.Enabled = true;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
        }

        internal void CapturarEquipo(string id, string tipo, string proveedor)
        {
            txtIDC.Text = id;
            txtTipoC.Text = tipo;
            txtProveedorC.Text = proveedor;
        }

        private void btnBuscarCom_Click(object sender, EventArgs e)
        {
            BuscarEquipos = new BuscarEquipo(this);
            BuscarEquipos.Show();
        }

        private void pbLibro_Click(object sender, EventArgs e)
        {
            ConsultaEquipos C = new ConsultaEquipos();
            C.TopLevel = false;
            C.Parent = pContent;
            C.Show();
        }

        public void CapturarMiembro(string id_miembro, string ocupacion_miembro, string tipo_membresia, string nombre_miembro, string apellidos_miembro)
        {
            txtIDM.Text = id_miembro;
            txtOcupacion.Text = ocupacion_miembro;
            txtTipo.Text = tipo_membresia;
            txtNombre.Text = nombre_miembro;
            txtApellidos.Text = apellidos_miembro;
        }

        private void btnBuscarMiembro_Click(object sender, EventArgs e)
        {
            BuscarMiembros = new BuscarMiembros(this);
            BuscarMiembros.Show();
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            if (txtIDM.Text.Length == 0 || txtIDC.Text.Length == 0 || txtIDE.Text.Length == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            respuesta = ObjQueries.RegistrarPrestamoComputadora(
                txtIDM.Text, txtIDC.Text, txtIDE.Text, lblHora.Text, String.Format("{0:HH:mm}", dtpHoraEntrega.Value)
            );
            
            if (respuesta != "OK")
            {
                MessageBox.Show(respuesta, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Se realizó el prestamo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarInterfaz();
        }

        internal void LimpiarInterfaz() {
            txtIDM.Text = ""; txtIDC.Text = "";
            txtOcupacion.Text = ""; txtTipo.Text = ""; txtNombre.Text = ""; txtApellidos.Text = "";
            txtTipoC.Text = ""; txtProveedorC.Text = "";
            dtpHoraEntrega.Value = DateTime.Now;
        }
        
    }
}
