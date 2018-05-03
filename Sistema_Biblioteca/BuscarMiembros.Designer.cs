namespace Sistema_Biblioteca
{
    partial class BuscarMiembros
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
            this.dgvMiembros = new System.Windows.Forms.DataGridView();
            this.tbcidmiembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTipoMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcnmobre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbctelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(6, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(301, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvMiembros
            // 
            this.dgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiembros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcidmiembro,
            this.tbcOcupacion,
            this.tbcTipoMembresia,
            this.tbcnmobre,
            this.tbcApellido,
            this.tbctelefono,
            this.tbcstatus});
            this.dgvMiembros.Location = new System.Drawing.Point(6, 38);
            this.dgvMiembros.Name = "dgvMiembros";
            this.dgvMiembros.ReadOnly = true;
            this.dgvMiembros.RowHeadersVisible = false;
            this.dgvMiembros.Size = new System.Drawing.Size(344, 260);
            this.dgvMiembros.TabIndex = 2;
            this.dgvMiembros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellDoubleClick);
            // 
            // tbcidmiembro
            // 
            this.tbcidmiembro.DataPropertyName = "id_miembro";
            this.tbcidmiembro.HeaderText = "ID";
            this.tbcidmiembro.Name = "tbcidmiembro";
            this.tbcidmiembro.ReadOnly = true;
            this.tbcidmiembro.Visible = false;
            this.tbcidmiembro.Width = 40;
            // 
            // tbcOcupacion
            // 
            this.tbcOcupacion.DataPropertyName = "ocupacion";
            this.tbcOcupacion.HeaderText = "Ocupacion";
            this.tbcOcupacion.Name = "tbcOcupacion";
            this.tbcOcupacion.ReadOnly = true;
            this.tbcOcupacion.Visible = false;
            // 
            // tbcTipoMembresia
            // 
            this.tbcTipoMembresia.DataPropertyName = "tipo";
            this.tbcTipoMembresia.HeaderText = "Tipo";
            this.tbcTipoMembresia.Name = "tbcTipoMembresia";
            this.tbcTipoMembresia.ReadOnly = true;
            // 
            // tbcnmobre
            // 
            this.tbcnmobre.DataPropertyName = "nombre";
            this.tbcnmobre.HeaderText = "Nombre";
            this.tbcnmobre.Name = "tbcnmobre";
            this.tbcnmobre.ReadOnly = true;
            this.tbcnmobre.Width = 120;
            // 
            // tbcApellido
            // 
            this.tbcApellido.DataPropertyName = "apellido";
            this.tbcApellido.HeaderText = "Apellidos";
            this.tbcApellido.Name = "tbcApellido";
            this.tbcApellido.ReadOnly = true;
            this.tbcApellido.Width = 120;
            // 
            // tbctelefono
            // 
            this.tbctelefono.DataPropertyName = "telefono";
            this.tbctelefono.HeaderText = "telefono";
            this.tbctelefono.Name = "tbctelefono";
            this.tbctelefono.ReadOnly = true;
            this.tbctelefono.Visible = false;
            // 
            // tbcstatus
            // 
            this.tbcstatus.DataPropertyName = "status";
            this.tbcstatus.HeaderText = "status";
            this.tbcstatus.Name = "tbcstatus";
            this.tbcstatus.ReadOnly = true;
            this.tbcstatus.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(320, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 122;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BuscarMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(357, 306);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvMiembros);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(373, 345);
            this.Name = "BuscarMiembros";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.BuscarMiembros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvMiembros;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcidmiembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcTipoMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcnmobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbctelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcstatus;
    }
}