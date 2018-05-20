namespace Sistema_Biblioteca
{
    partial class BuscarSala
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
            this.txtFiltro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.ID_SALAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAX_PERSONAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_EVENTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtFiltro.HintForeColor = System.Drawing.Color.Gray;
            this.txtFiltro.HintText = "Buscar Sala";
            this.txtFiltro.isPassword = false;
            this.txtFiltro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtFiltro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtFiltro.LineThickness = 3;
            this.txtFiltro.Location = new System.Drawing.Point(15, 34);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(335, 31);
            this.txtFiltro.TabIndex = 214;
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 213;
            this.label1.Text = "Buscar SALA por el ID o el Numero de sala";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(320, -3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 212;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvSalas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSalas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSalas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalas.ColumnHeadersHeight = 30;
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SALAS,
            this.NUM_SALA,
            this.MAX_PERSONAS,
            this.TIPO_EVENTOS});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalas.EnableHeadersVisualStyles = false;
            this.dgvSalas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.dgvSalas.Location = new System.Drawing.Point(12, 72);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.ReadOnly = true;
            this.dgvSalas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalas.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSalas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalas.Size = new System.Drawing.Size(338, 340);
            this.dgvSalas.TabIndex = 215;
            this.dgvSalas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalas_CellContentDoubleClick);
            // 
            // ID_SALAS
            // 
            this.ID_SALAS.DataPropertyName = "ID_SALAS";
            this.ID_SALAS.HeaderText = "ID Sala";
            this.ID_SALAS.Name = "ID_SALAS";
            this.ID_SALAS.ReadOnly = true;
            this.ID_SALAS.Width = 69;
            // 
            // NUM_SALA
            // 
            this.NUM_SALA.DataPropertyName = "NUM_SALA";
            this.NUM_SALA.HeaderText = "No. Sala";
            this.NUM_SALA.Name = "NUM_SALA";
            this.NUM_SALA.ReadOnly = true;
            this.NUM_SALA.Width = 76;
            // 
            // MAX_PERSONAS
            // 
            this.MAX_PERSONAS.DataPropertyName = "MAX_PERSONAS";
            this.MAX_PERSONAS.HeaderText = "Max. Personas";
            this.MAX_PERSONAS.Name = "MAX_PERSONAS";
            this.MAX_PERSONAS.ReadOnly = true;
            this.MAX_PERSONAS.Width = 109;
            // 
            // TIPO_EVENTOS
            // 
            this.TIPO_EVENTOS.DataPropertyName = "TIPO_EVENTOS";
            this.TIPO_EVENTOS.HeaderText = "Tipo Sala";
            this.TIPO_EVENTOS.Name = "TIPO_EVENTOS";
            this.TIPO_EVENTOS.ReadOnly = true;
            this.TIPO_EVENTOS.Width = 80;
            // 
            // BuscarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(356, 424);
            this.Controls.Add(this.dgvSalas);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarSala";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.BuscarSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltro;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SALAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAX_PERSONAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_EVENTOS;
    }
}