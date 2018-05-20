namespace Sistema_Biblioteca
{
    partial class ConsultaEquipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEquipos));
            this.dgEquipos = new System.Windows.Forms.DataGridView();
            this.ID_Computadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEditar = new System.Windows.Forms.Label();
            this.cbEditar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.ddTipo = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtProveedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbConsultaEmpl = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).BeginInit();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultaEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEquipos
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgEquipos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEquipos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEquipos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEquipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEquipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgEquipos.ColumnHeadersHeight = 30;
            this.dgEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Computadora,
            this.Tipo,
            this.Proveedor});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEquipos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgEquipos.EnableHeadersVisualStyles = false;
            this.dgEquipos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.dgEquipos.Location = new System.Drawing.Point(169, 293);
            this.dgEquipos.Name = "dgEquipos";
            this.dgEquipos.ReadOnly = true;
            this.dgEquipos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEquipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgEquipos.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgEquipos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEquipos.Size = new System.Drawing.Size(252, 210);
            this.dgEquipos.TabIndex = 192;
            this.dgEquipos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEquipos_CellContentDoubleClick);
            // 
            // ID_Computadora
            // 
            this.ID_Computadora.DataPropertyName = "ID_Computadora";
            this.ID_Computadora.HeaderText = "ID Equipo";
            this.ID_Computadora.Name = "ID_Computadora";
            this.ID_Computadora.ReadOnly = true;
            this.ID_Computadora.Width = 86;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TIPO";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 55;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "PROVEEDOR";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 94;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditar.Location = new System.Drawing.Point(326, 234);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(45, 17);
            this.lblEditar.TabIndex = 190;
            this.lblEditar.Text = "Editar";
            // 
            // cbEditar
            // 
            this.cbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.cbEditar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbEditar.Checked = false;
            this.cbEditar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.cbEditar.ForeColor = System.Drawing.Color.White;
            this.cbEditar.Location = new System.Drawing.Point(300, 233);
            this.cbEditar.Name = "cbEditar";
            this.cbEditar.Size = new System.Drawing.Size(20, 20);
            this.cbEditar.TabIndex = 189;
            this.cbEditar.OnChange += new System.EventHandler(this.cbEditar_OnChange);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HintForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.HintText = "Buscar por Tipo o ID";
            this.txtBuscar.isPassword = false;
            this.txtBuscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtBuscar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtBuscar.LineThickness = 3;
            this.txtBuscar.Location = new System.Drawing.Point(69, 108);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(312, 31);
            this.txtBuscar.TabIndex = 188;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.ddTipo);
            this.gbTipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.Location = new System.Drawing.Point(69, 210);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(173, 62);
            this.gbTipo.TabIndex = 187;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // ddTipo
            // 
            this.ddTipo.BackColor = System.Drawing.Color.Transparent;
            this.ddTipo.BorderRadius = 3;
            this.ddTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddTipo.Items = new string[] {
        "PC",
        "LAPTOP",
        "2 EN 1"};
            this.ddTipo.Location = new System.Drawing.Point(6, 22);
            this.ddTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddTipo.Name = "ddTipo";
            this.ddTipo.NomalColor = System.Drawing.Color.White;
            this.ddTipo.onHoverColor = System.Drawing.SystemColors.ControlLight;
            this.ddTipo.selectedIndex = -1;
            this.ddTipo.Size = new System.Drawing.Size(161, 31);
            this.ddTipo.TabIndex = 168;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtProveedor.HintForeColor = System.Drawing.Color.Gray;
            this.txtProveedor.HintText = "Proveedor";
            this.txtProveedor.isPassword = false;
            this.txtProveedor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtProveedor.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtProveedor.LineThickness = 3;
            this.txtProveedor.Location = new System.Drawing.Point(135, 159);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(298, 31);
            this.txtProveedor.TabIndex = 186;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblModificar.Location = new System.Drawing.Point(86, 69);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(269, 23);
            this.lblModificar.TabIndex = 182;
            this.lblModificar.Text = "Registro y Consulta de Equipos";
            this.lblModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HintForeColor = System.Drawing.Color.Gray;
            this.txtID.HintText = "ID";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtID.LineThickness = 3;
            this.txtID.Location = new System.Drawing.Point(28, 159);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(72, 31);
            this.txtID.TabIndex = 183;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(611, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 185;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregar.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 25;
            this.btnAgregar.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(468, 265);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 39);
            this.btnAgregar.TabIndex = 184;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbConsultaEmpl
            // 
            this.pbConsultaEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbConsultaEmpl.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.computer_pc_108941;
            this.pbConsultaEmpl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbConsultaEmpl.Location = new System.Drawing.Point(485, 45);
            this.pbConsultaEmpl.Name = "pbConsultaEmpl";
            this.pbConsultaEmpl.Size = new System.Drawing.Size(122, 127);
            this.pbConsultaEmpl.TabIndex = 181;
            this.pbConsultaEmpl.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnGuardar.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 25;
            this.btnGuardar.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnGuardar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnGuardar.Location = new System.Drawing.Point(468, 265);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 39);
            this.btnGuardar.TabIndex = 191;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ConsultaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(655, 515);
            this.Controls.Add(this.dgEquipos);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.cbEditar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pbConsultaEmpl);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultaEquipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultaEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipos)).EndInit();
            this.gbTipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultaEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Computadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.Label lblEditar;
        private Bunifu.Framework.UI.BunifuCheckbox cbEditar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscar;
        private System.Windows.Forms.GroupBox gbTipo;
        private Bunifu.Framework.UI.BunifuDropdown ddTipo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProveedor;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.Label lblModificar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.PictureBox pbConsultaEmpl;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
    }
}