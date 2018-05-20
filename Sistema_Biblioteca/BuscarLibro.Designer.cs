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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
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
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtFiltro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEquipos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEquipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBusquedaCodigo,
            this.dgvBusquedaISBN,
            this.dgvBusquedaAutor,
            this.dgvBusquedaNombre,
            this.dgvBusquedaPerfil,
            this.tbcCantidad,
            this.tbcArea,
            this.tbcEdicion,
            this.tbcId_libro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipos.EnableHeadersVisualStyles = false;
            this.dgvEquipos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.dgvEquipos.Location = new System.Drawing.Point(12, 76);
            this.dgvEquipos.MultiSelect = false;
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEquipos.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEquipos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEquipos.Size = new System.Drawing.Size(614, 314);
            this.dgvEquipos.TabIndex = 124;
            this.dgvEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellDoubleClick);
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 125;
            this.label1.Text = "Busqueda de Libros";
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
            // txtFiltro
            // 
            this.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtFiltro.HintForeColor = System.Drawing.Color.Gray;
            this.txtFiltro.HintText = "Buscar Libro";
            this.txtFiltro.isPassword = false;
            this.txtFiltro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtFiltro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtFiltro.LineThickness = 3;
            this.txtFiltro.Location = new System.Drawing.Point(165, 38);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(370, 31);
            this.txtFiltro.TabIndex = 201;
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 202;
            this.label2.Text = "Buscar por nombre:";
            // 
            // BuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(634, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.btnSalir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarLibro";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.BuscarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.DataGridView dgvEquipos;
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltro;
        private System.Windows.Forms.Label label2;
    }
}