namespace Sistema_Biblioteca
{
    partial class ConsultarAutores
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
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.ID_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_autor,
            this.Nombre,
            this.Area,
            this.Perfil});
            this.dgvAutores.Location = new System.Drawing.Point(4, 41);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowHeadersVisible = false;
            this.dgvAutores.Size = new System.Drawing.Size(395, 260);
            this.dgvAutores.TabIndex = 0;
            this.dgvAutores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellDoubleClick);
            // 
            // ID_autor
            // 
            this.ID_autor.DataPropertyName = "id_autors";
            this.ID_autor.HeaderText = "ID";
            this.ID_autor.Name = "ID_autor";
            this.ID_autor.ReadOnly = true;
            this.ID_autor.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "area";
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "perfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 15);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(351, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(369, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 121;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(393, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvAutores);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarAutores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ConsultarAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.TextBox txtFiltro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
    }
}