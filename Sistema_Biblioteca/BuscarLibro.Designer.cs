namespace Sistema_Biblioteca
{
    partial class BuscarLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.dgvBusquedaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcId_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(123, 9);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(343, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(596, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 123;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            // 
            // dgvLibros
            // 
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBusquedaCodigo,
            this.dgvBusquedaISBN,
            this.dgvBusquedaAutor,
            this.dgvBusquedaNombre,
            this.dgvBusquedaPerfil,
            this.tbcCantidad,
            this.tbcArea,
            this.tbcEdicion,
            this.tbcId_libro});
            this.dgvLibros.Location = new System.Drawing.Point(12, 38);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.Size = new System.Drawing.Size(614, 321);
            this.dgvLibros.TabIndex = 124;
            this.dgvLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellDoubleClick);
            // 
            // dgvBusquedaCodigo
            // 
            this.dgvBusquedaCodigo.DataPropertyName = "codigo";
            this.dgvBusquedaCodigo.HeaderText = "Codigo";
            this.dgvBusquedaCodigo.Name = "dgvBusquedaCodigo";
            this.dgvBusquedaCodigo.Width = 50;
            // 
            // dgvBusquedaISBN
            // 
            this.dgvBusquedaISBN.DataPropertyName = "isbn";
            this.dgvBusquedaISBN.HeaderText = "ISBN";
            this.dgvBusquedaISBN.Name = "dgvBusquedaISBN";
            this.dgvBusquedaISBN.Width = 40;
            // 
            // dgvBusquedaAutor
            // 
            this.dgvBusquedaAutor.DataPropertyName = "autor";
            this.dgvBusquedaAutor.HeaderText = "Autor";
            this.dgvBusquedaAutor.Name = "dgvBusquedaAutor";
            this.dgvBusquedaAutor.Width = 220;
            // 
            // dgvBusquedaNombre
            // 
            this.dgvBusquedaNombre.DataPropertyName = "nombre";
            this.dgvBusquedaNombre.HeaderText = "Libro";
            this.dgvBusquedaNombre.Name = "dgvBusquedaNombre";
            this.dgvBusquedaNombre.Width = 200;
            // 
            // dgvBusquedaPerfil
            // 
            this.dgvBusquedaPerfil.DataPropertyName = "perfil";
            this.dgvBusquedaPerfil.HeaderText = "Perfil";
            this.dgvBusquedaPerfil.Name = "dgvBusquedaPerfil";
            // 
            // tbcCantidad
            // 
            this.tbcCantidad.DataPropertyName = "cantidad";
            this.tbcCantidad.HeaderText = "Cantidad";
            this.tbcCantidad.Name = "tbcCantidad";
            this.tbcCantidad.Visible = false;
            // 
            // tbcArea
            // 
            this.tbcArea.DataPropertyName = "area";
            this.tbcArea.HeaderText = "Area";
            this.tbcArea.Name = "tbcArea";
            this.tbcArea.Visible = false;
            // 
            // tbcEdicion
            // 
            this.tbcEdicion.DataPropertyName = "edicion";
            this.tbcEdicion.HeaderText = "Edicion";
            this.tbcEdicion.Name = "tbcEdicion";
            this.tbcEdicion.Visible = false;
            // 
            // tbcId_libro
            // 
            this.tbcId_libro.DataPropertyName = "id_libro";
            this.tbcId_libro.HeaderText = "ID Libro";
            this.tbcId_libro.Name = "tbcId_libro";
            this.tbcId_libro.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Buscar por nombre";
            // 
            // BuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(634, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtFiltro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarLibro";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.BuscarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcId_libro;
    }
}