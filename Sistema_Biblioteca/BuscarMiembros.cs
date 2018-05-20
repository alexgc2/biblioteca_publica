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
    public partial class BuscarMiembros : Form
    {
        Conexion ObjQueries = new Conexion();
        RegistroPrestamosLibros LibrosCaller;
        RegistroPrestamoEquipos EquiposCaller;
        RegistroPrestamoSalas SalasCaller;
        DataGridViewCellCollection Celda;
        public BuscarMiembros(RegistroPrestamosLibros Caller)
        {
            InitializeComponent();
            LibrosCaller = Caller;
        }
        public BuscarMiembros(RegistroPrestamoEquipos Caller)
        {
            InitializeComponent();
            EquiposCaller = Caller;
        }
        public BuscarMiembros(RegistroPrestamoSalas Caller)
        {
            InitializeComponent();
            SalasCaller = Caller;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BuscarMiembros_Load(this, e);
        }

        private void dgvAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Celda = dgvMiembros.CurrentRow.Cells;
            if (LibrosCaller != null)
            {
                LibrosCaller.CapturarMiembro(
                    Celda[0].Value.ToString(),
                    Celda[3].Value.ToString(),
                    Celda[5].Value.ToString(),
                    Celda[1].Value.ToString(),
                    Celda[2].Value.ToString()
                );
            }
            else if (EquiposCaller != null)
            {
                EquiposCaller.CapturarMiembro(
                        Celda[0].Value.ToString(),
                        Celda[3].Value.ToString(),
                        Celda[5].Value.ToString(),
                        Celda[1].Value.ToString(),
                        Celda[2].Value.ToString()
                    );
            }
            else if (SalasCaller != null)
            {
                SalasCaller.CapturarMiembro(
                    Celda[0].Value.ToString(),
                    Celda[1].Value.ToString() + " "+ Celda[2].Value.ToString()
                );

            }
            Close();
        }

        private void BuscarMiembros_Load(object sender, EventArgs e)
        {
            dgvMiembros.DataSource = ObjQueries.ConsultarMiembros(txtFiltro.Text).Tables["membresia"];
        }
    }
}
