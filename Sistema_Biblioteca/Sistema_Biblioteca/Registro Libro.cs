﻿using System;
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
    public partial class Registro_Libro : Form
    {
        Conexion conexion = new Conexion();
        public Registro_Libro()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Registro_Libro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bIBLIOTECA_PUBLICADataSet1.AUTORES' Puede moverla o quitarla según sea necesario.
            this.aUTORESTableAdapter1.Fill(this.bIBLIOTECA_PUBLICADataSet1.AUTORES);
            // TODO: esta línea de código carga datos en la tabla 'bIBLIOTECA_PUBLICADataSet.AUTORES' Puede moverla o quitarla según sea necesario.
            this.aUTORESTableAdapter.Fill(this.bIBLIOTECA_PUBLICADataSet.AUTORES);

            conexion.llenar_ComboBox(cbxAutores);
        }

        private void pbxPlus_Click(object sender, EventArgs e)
        {
            
        }

        private void pbxPlus_Click_1(object sender, EventArgs e)
        {
            Agregar_Autor AA = new Agregar_Autor();
            AA.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Length == 0 || cbxArea.Text.Length == 0 || cbxPerfil.Text.Length == 0 || cbxAutores.Text.Length == 0 || txtAño.Text.Length == 0 || txtCantidad.Text.Length ==0 || txtEdicion.Text.Length == 0 ||txtEditorial.Text.Length ==0 ||txtIsbn.Text.Length == 0 || txtProveedor.Text.Length == 0 ||txtTitulo.Text.Length ==0)
            {
                MessageBox.Show("Favor de llenar todos los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conexion.agregar_libro(txtCodigo.Text, txtTitulo.Text, cbxAutores.Text, txtEditorial.Text, txtEdicion.Text, cbxArea.Text, cbxPerfil.Text, Convert.ToInt32(txtIsbn.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtAño.Text), txtProveedor.Text, txtDetalles.Text);
                MessageBox.Show("Libro registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxArea.SelectedIndex == 0)
            {
                cbxPerfil.Items.Clear();
                cbxPerfil.Text = "";
                cbxPerfil.Items.Add("Matematicas");
                cbxPerfil.Items.Add("Ciencias");
                cbxPerfil.Items.Add("Computacion");
                cbxPerfil.Items.Add("Historia");
                cbxPerfil.Items.Add("Sociales");
            }
            else if (cbxArea.SelectedIndex == 1)
            {
                cbxPerfil.Items.Clear();
                cbxPerfil.Text = "";
                cbxPerfil.Items.Add("Aventuras");
                cbxPerfil.Items.Add("Ciencia ficcion");
                cbxPerfil.Items.Add("Fantasia");
                cbxPerfil.Items.Add("Policiaco");
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aUTORESTableAdapter1.FillBy(this.bIBLIOTECA_PUBLICADataSet1.AUTORES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            conexion.llenar_ComboBox(cbxAutores);
        }
    }
}
