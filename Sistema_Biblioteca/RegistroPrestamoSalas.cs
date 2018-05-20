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
        BuscarSala BuscarSala;
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
    }
}
