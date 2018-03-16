namespace Sistema_Biblioteca
{
    partial class Consultar_libro
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
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.dgvBusquedaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBusquedaCodigo,
            this.dgvBusquedaISBN,
            this.dgvBusquedaAutor,
            this.dgvBusquedaNombre,
            this.dgvBusquedaArea,
            this.dgvBusquedaPerfil});
            this.dgvLibros.Location = new System.Drawing.Point(12, 230);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(635, 295);
            this.dgvLibros.TabIndex = 27;
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
            this.dgvBusquedaAutor.Width = 140;
            // 
            // dgvBusquedaNombre
            // 
            this.dgvBusquedaNombre.DataPropertyName = "nombre";
            this.dgvBusquedaNombre.HeaderText = "Libro";
            this.dgvBusquedaNombre.Name = "dgvBusquedaNombre";
            this.dgvBusquedaNombre.Width = 160;
            // 
            // dgvBusquedaArea
            // 
            this.dgvBusquedaArea.DataPropertyName = "area";
            this.dgvBusquedaArea.HeaderText = "Area";
            this.dgvBusquedaArea.Name = "dgvBusquedaArea";
            // 
            // dgvBusquedaPerfil
            // 
            this.dgvBusquedaPerfil.DataPropertyName = "perfil";
            this.dgvBusquedaPerfil.HeaderText = "Perfil";
            this.dgvBusquedaPerfil.Name = "dgvBusquedaPerfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // cboEditorial
            // 
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(153, 168);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(211, 21);
            this.cboEditorial.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha de publicación";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(206, 196);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(66, 20);
            this.dtpFecha.TabIndex = 22;
            this.dtpFecha.Value = new System.DateTime(2018, 4, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Editorial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Autor";
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(153, 139);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(210, 21);
            this.cboAutor.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(383, 168);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 46);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Location = new System.Drawing.Point(382, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 46);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 88);
            this.panel1.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(174, 33);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Consulta de libros";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.lupa;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(83, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 53);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Consultar_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 538);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboEditorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Name = "Consultar_libro";
            this.Text = "Consultar_libro";
            this.Load += new System.EventHandler(this.Consultar_libro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaPerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboEditorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
    }
}