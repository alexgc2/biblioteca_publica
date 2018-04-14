namespace Sistema_Biblioteca
{
    partial class ConsultarLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarLibros));
            this.pContent = new System.Windows.Forms.Panel();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbConsultaLibro = new System.Windows.Forms.PictureBox();
            this.btnAgregarLibro = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnModificarLibro = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBusquedaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBusquedaPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultaLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContent.Controls.Add(this.dgvLibros);
            this.pContent.Controls.Add(this.btnBuscar);
            this.pContent.Controls.Add(this.btnSalir);
            this.pContent.Controls.Add(this.pbConsultaLibro);
            this.pContent.Controls.Add(this.btnAgregarLibro);
            this.pContent.Controls.Add(this.btnModificarLibro);
            this.pContent.Controls.Add(this.txtBuscar);
            this.pContent.Controls.Add(this.label1);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(680, 405);
            this.pContent.TabIndex = 108;
            this.pContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pContent_Paint);
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
            this.dgvBusquedaPerfil});
            this.dgvLibros.Location = new System.Drawing.Point(10, 147);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(656, 251);
            this.dgvLibros.TabIndex = 118;
            this.dgvLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(403, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 35);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 117;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(648, -2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 116;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbConsultaLibro
            // 
            this.pbConsultaLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbConsultaLibro.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.search_book;
            this.pbConsultaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbConsultaLibro.Location = new System.Drawing.Point(10, 26);
            this.pbConsultaLibro.Name = "pbConsultaLibro";
            this.pbConsultaLibro.Size = new System.Drawing.Size(100, 108);
            this.pbConsultaLibro.TabIndex = 115;
            this.pbConsultaLibro.TabStop = false;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarLibro.Image = global::Sistema_Biblioteca.Properties.Resources.add_book1;
            this.btnAgregarLibro.ImageActive = null;
            this.btnAgregarLibro.Location = new System.Drawing.Point(453, 39);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(95, 95);
            this.btnAgregarLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarLibro.TabIndex = 112;
            this.btnAgregarLibro.TabStop = false;
            this.btnAgregarLibro.Zoom = 10;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarLibro.Image = global::Sistema_Biblioteca.Properties.Resources.configura_book;
            this.btnModificarLibro.ImageActive = null;
            this.btnModificarLibro.Location = new System.Drawing.Point(571, 39);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(95, 95);
            this.btnModificarLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificarLibro.TabIndex = 111;
            this.btnModificarLibro.TabStop = false;
            this.btnModificarLibro.Zoom = 10;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(128, 82);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(269, 27);
            this.txtBuscar.TabIndex = 110;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Buscar por Nombre:";
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
            // ConsultarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 405);
            this.Controls.Add(this.pContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarLibros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultaLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarLibro;
        private Bunifu.Framework.UI.BunifuImageButton btnModificarLibro;
        private System.Windows.Forms.PictureBox pbConsultaLibro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBusquedaPerfil;
    }
}