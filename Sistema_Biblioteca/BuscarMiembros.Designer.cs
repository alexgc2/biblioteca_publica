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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvMiembros = new System.Windows.Forms.DataGridView();
            this.tbcidmiembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTipoMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcnmobre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbctelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(326, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 122;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvMiembros
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMiembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMiembros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMiembros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMiembros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMiembros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMiembros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiembros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcidmiembro,
            this.tbcOcupacion,
            this.tbcTipoMembresia,
            this.tbcnmobre,
            this.tbcApellido,
            this.tbctelefono,
            this.tbcstatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMiembros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMiembros.EnableHeadersVisualStyles = false;
            this.dgvMiembros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.dgvMiembros.Location = new System.Drawing.Point(12, 68);
            this.dgvMiembros.Name = "dgvMiembros";
            this.dgvMiembros.ReadOnly = true;
            this.dgvMiembros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMiembros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMiembros.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMiembros.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMiembros.Size = new System.Drawing.Size(344, 226);
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
            this.tbcidmiembro.Width = 43;
            // 
            // tbcOcupacion
            // 
            this.tbcOcupacion.DataPropertyName = "ocupacion";
            this.tbcOcupacion.HeaderText = "Ocupacion";
            this.tbcOcupacion.Name = "tbcOcupacion";
            this.tbcOcupacion.ReadOnly = true;
            this.tbcOcupacion.Visible = false;
            this.tbcOcupacion.Width = 98;
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
            this.tbctelefono.Width = 82;
            // 
            // tbcstatus
            // 
            this.tbcstatus.DataPropertyName = "status";
            this.tbcstatus.HeaderText = "status";
            this.tbcstatus.Name = "tbcstatus";
            this.tbcstatus.ReadOnly = true;
            this.tbcstatus.Visible = false;
            this.tbcstatus.Width = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 209;
            this.label1.Text = "Buscar MIEMBRO por el nombre";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtFiltro.HintForeColor = System.Drawing.Color.Gray;
            this.txtFiltro.HintText = "Buscar Membresía";
            this.txtFiltro.isPassword = false;
            this.txtFiltro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtFiltro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtFiltro.LineThickness = 3;
            this.txtFiltro.Location = new System.Drawing.Point(15, 30);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(304, 31);
            this.txtFiltro.TabIndex = 210;
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuscarMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(357, 306);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvMiembros);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(373, 345);
            this.Name = "BuscarMiembros";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.BuscarMiembros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.DataGridView dgvMiembros;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcidmiembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcTipoMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcnmobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbctelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcstatus;
    }
}