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
    public partial class ConsultaEquipos : Form
    {
        Conexion c = new Conexion();
        public ConsultaEquipos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void ConsultaEquipos_Load(object sender, EventArgs e)
        {
            dgEquipos.AutoGenerateColumns = false;
            dgEquipos.DataSource =
                c.ConsultarEquipo(txtBuscar.Text).Tables["COMPUTADORAS"];
        }

        private void cbEditar_OnChange(object sender, EventArgs e)
        {
            if (cbEditar.Checked == true)
            {
                btnGuardar.Show();
                btnAgregar.Hide();
            }
            else if (cbEditar.Checked == false)
            {
                btnAgregar.Show();
                btnGuardar.Hide();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtProveedor.Text.Length > 0 && ddTipo.selectedIndex >= 0)
            {
                c.agergar_equipo(ddTipo.selectedValue, txtProveedor.Text);
                MessageBox.Show("Registrado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borrar();
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        private void dgEquipos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dgEquipos.CurrentRow.Cells[0].Value);
            txtProveedor.Text = Convert.ToString(dgEquipos.CurrentRow.Cells[2].Value);
            btnAgregar.Hide();
            btnGuardar.Show();
            cbEditar.Checked = true;
            tipo();
            txtBuscar.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtProveedor.Text.Length == 0 || ddTipo.selectedIndex == 0 || txtID.Text.Length == 0)
            {
                c.modificar_equipo(ddTipo.selectedValue, txtProveedor.Text, Convert.ToInt32(txtID.Text));
                MessageBox.Show("Registro Guardado Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borrar();
                return;
            }

            if (cbEditar.Checked)
            {
                MessageBox.Show("Favor de seleccinar el registro que se desea modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Favor de llenar los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public void borrar()
        {
            txtID.Text = "";
            txtProveedor.Text = "";
            cbEditar.Checked = false;
            btnAgregar.Show();
            btnGuardar.Hide();
            dgEquipos.DataSource = c.ConsultarEquipo(txtBuscar.Text).Tables["COMPUTADORAS"];
        }

        public void tipo()
        {
            if (Convert.ToString(dgEquipos.CurrentRow.Cells[1].Value) == "PC")
            {
                ddTipo.selectedIndex = 0;
            }
            else if (Convert.ToString(dgEquipos.CurrentRow.Cells[1].Value) == "LAPTOP")
            {
                ddTipo.selectedIndex = 1;
            }
            else if (Convert.ToString(dgEquipos.CurrentRow.Cells[1].Value) == "2 EN 1")
            {
                ddTipo.selectedIndex = 2;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dgEquipos.DataSource = c.ConsultarEquipo(txtBuscar.Text).Tables["COMPUTADORAS"];
        }


    }
}
