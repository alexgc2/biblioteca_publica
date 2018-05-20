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
    public partial class ConsultaSalas : Form
    {
        Conexion c = new Conexion();
        public ConsultaSalas()
        {
            InitializeComponent();
        }

        private void cbEditar_OnChange(object sender, EventArgs e)
        {
            if (cbEditar.Checked == true)
            {
                gbstatus.Show();
                btnGuardar.Show();
            }
            else if (cbEditar.Checked == false)
            {
                gbstatus.Hide();
                btnGuardar.Hide();
            }
        }

        private void ConsultaSalas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtmaxper.Text.Length > 0 && ddTipoSala.selectedIndex >= 0 && ddNoSala.selectedIndex >= 0)
            {
                c.agergar_sala(Convert.ToInt32(ddNoSala.selectedValue), Convert.ToInt32(txtmaxper.Text), ddTipoSala.selectedValue);
                MessageBox.Show("Registrado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borrar();
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dgSalas.DataSource = c.ConsultarSala(txtBuscar.Text).Tables["SALAS"];
        }

        private void dgSalas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dgSalas.CurrentRow.Cells[0].Value);
            txtmaxper.Text = Convert.ToString(dgSalas.CurrentRow.Cells[2].Value);
            btnAgregar.Hide();
            btnGuardar.Show();
            gbstatus.Show();
            cbEditar.Checked = true;
            tipo();
            txtBuscar.Text = "";
        }

        public void tipo()
        {
            #region numero sala
            if (Convert.ToString(dgSalas.CurrentRow.Cells[1].Value) == "1")
            {
                ddNoSala.selectedIndex = 0;
            }
            else if (Convert.ToString(dgSalas.CurrentRow.Cells[1].Value) == "2")
            {
                ddNoSala.selectedIndex = 1;
            }
            else if (Convert.ToString(dgSalas.CurrentRow.Cells[1].Value) == "3")
            {
                ddNoSala.selectedIndex = 2;
            }
            #endregion

            #region Tipo Sala
            if (Convert.ToString(dgSalas.CurrentRow.Cells[3].Value) == "Estudios")
            {
                ddTipoSala.selectedIndex = 0;
            }
            else if (Convert.ToString(dgSalas.CurrentRow.Cells[3].Value) == "Club")
            {
                ddTipoSala.selectedIndex = 1;
            }
            else if (Convert.ToString(dgSalas.CurrentRow.Cells[3].Value) == "Conferencia")
            {
                ddTipoSala.selectedIndex = 2;
            }
            else if (Convert.ToString(dgSalas.CurrentRow.Cells[3].Value) == "Reunion")
            {
                ddTipoSala.selectedIndex = 3;
            }
            #endregion

            #region estatus
            if (Convert.ToString(dgSalas.CurrentRow.Cells[4].Value) == "Disponible")
            {
                ddstatus.selectedIndex = 0;
            }
            else if (Convert.ToString(dgSalas.CurrentRow.Cells[4].Value) == "Ocupada")
            {
                ddstatus.selectedIndex = 1;
            }
            #endregion
        }

        public void borrar()
        {
            txtID.Text = "";
            txtmaxper.Text = "";
            cbEditar.Checked = false;
            btnAgregar.Show();
            btnGuardar.Hide();
            dgSalas.DataSource = c.ConsultarSala(txtBuscar.Text).Tables["SALAS"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtmaxper.Text.Length > 0 && ddTipoSala.selectedIndex >= 0 && ddNoSala.selectedIndex >= 0 && ddstatus.selectedIndex >= 0)
            {
                c.modificar_sala(Convert.ToInt32(ddNoSala.selectedValue), Convert.ToInt32(txtmaxper.Text), ddTipoSala.selectedValue, ddstatus.selectedValue, Convert.ToInt32(txtID.Text));
                MessageBox.Show("Guardado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borrar();
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbConsultaEmpl_Click(object sender, EventArgs e)
        {

        }
    }
}
