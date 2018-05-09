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
    public partial class MenuPrincipal : Form
    {
        int Fecha = 0;
        Empleado EmpleadoActual = new Empleado();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            switch (Fecha)
            {
                case 0: TiempoSesion();
                    break;
            }
        }

        private void TiempoSesion()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            RegistroPrestamos RP = new RegistroPrestamos(EmpleadoActual);
            RP.TopLevel = false;
            RP.Parent = pVentanas;
            RP.Show();

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            ConsultarLibros CL = new ConsultarLibros();
            CL.TopLevel = false;
            CL.Parent = pVentanas;
            CL.Show();
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            ConsultaMembresia CM = new ConsultaMembresia();
            CM.TopLevel = false;
            CM.Parent = pVentanas;
            CM.Show();
        }

        private void btnComputadoras_Click(object sender, EventArgs e)
        {

        }

        private void btnSalas_Click(object sender, EventArgs e)
        {

        }

        private void pPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {
            toolTipPrestamo.SetToolTip(btnPrestamos, "Prestamos");
            toolTipLibros.SetToolTip(btnLibros, "Libros");
            toolTipMembresias.SetToolTip(btnMembresias, "Membresias");
            toolTipComputadoras.SetToolTip(btnComputadoras, "Computadoras");
            toolTipSalas.SetToolTip(btnSalas, "Salas");
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            RegistroEmpleado RE = new RegistroEmpleado();
            RE.TopLevel = false;
            RE.Parent = pVentanas;
            RE.Show();
        }
    }
}
