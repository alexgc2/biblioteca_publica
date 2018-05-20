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
    public partial class RegistroPrestamoSalas : Form
    {
        string respuesta;
        Conexion ObjQueries = new Conexion();
        BuscarSala BuscarSala;
        BuscarMiembros BuscarMiembros;
        public RegistroPrestamoSalas(Empleado EmpleadoActivo)
        {
            InitializeComponent();
            txtIDE.Text = EmpleadoActivo.Id;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbLibro_Click(object sender, EventArgs e)
        {
            ConsultaSalas CS = new ConsultaSalas();
            CS.TopLevel = false;
            CS.Parent = pContent;
            CS.Show();
        }

        internal void CapturarSala(string id_sala, string no_sala, string cap_maxima, string tipo_sala)
        {
            txtIDS.Text = id_sala;
            txtNoSala.Text = no_sala;
            txtCapacidadMaxima.Text = cap_maxima;
            txtTipoSala.Text = tipo_sala;
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            BuscarSala = new BuscarSala(this);
            BuscarSala.Show();
        }

        private void btnBuscarMiembro_Click(object sender, EventArgs e)
        {
            BuscarMiembros = new BuscarMiembros(this);
            BuscarMiembros.Show();
        }

        internal void CapturarMiembro(string ID, string Nombre_completo)
        {
            txtIDM.Text = ID;
            txtNombreM.Text = Nombre_completo;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (txtNombreE.Text.Length == 0 || txtNoAsis.Text.Length == 0 || txtDuracion.Text.Length == 0
                || txtIDE.Text.Length == 0 || txtIDM.Text.Length == 0 || txtIDS.Text.Length == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            respuesta = ObjQueries.RegistrarPrestamoSalas(
                txtIDS.Text, txtIDE.Text, txtIDM.Text, txtNombreE.Text, dtFecha.Value.ToString(), 
                txtDuracion.Text, txtNoAsis.Text
            );

            if (respuesta != "OK")
            {
                MessageBox.Show(respuesta, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Se realizó el prestamo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarInterfaz();
        }

        internal void LimpiarInterfaz()
        {
            txtIDM.Text = ""; txtNombreE.Text = "";
            txtNombreE.Text = ""; txtDuracion.Text = ""; txtNoAsis.Text = "";
            dtFecha.Value = DateTime.Now;
            txtIDS.Text = ""; txtTipoSala.Text = ""; txtNoSala.Text = "";
            txtCapacidadMaxima.Text = "";
        }
    }
}
