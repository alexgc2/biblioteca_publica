namespace Sistema_Biblioteca
{
    partial class ConsultaSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSalas));
            this.dgSalas = new System.Windows.Forms.DataGridView();
            this.gbTipoS = new System.Windows.Forms.GroupBox();
            this.ddTipoSala = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblEditar = new System.Windows.Forms.Label();
            this.cbEditar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtmaxper = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbNSala = new System.Windows.Forms.GroupBox();
            this.ddNoSala = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblRyCS = new System.Windows.Forms.Label();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbConsultaEmpl = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ID_SALAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAX_PERSONAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_EVENTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).BeginInit();
            this.gbTipoS.SuspendLayout();
            this.gbNSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultaEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSalas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgSalas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSalas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSalas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSalas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgSalas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSalas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgSalas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSalas.ColumnHeadersHeight = 30;
            this.dgSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgSalas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSalas.EnableHeadersVisualStyles = false;
            this.dgSalas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.dgSalas.Location = new System.Drawing.Point(80, 286);
            this.dgSalas.Name = "dgSalas";
            this.dgSalas.ReadOnly = true;
            this.dgSalas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSalas.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgSalas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSalas.Size = new System.Drawing.Size(341, 216);
            this.dgSalas.TabIndex = 213;
            this.dgSalas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalas_CellContentDoubleClick);
            // 
            // gbTipoS
            // 
            this.gbTipoS.Controls.Add(this.ddTipoSala);
            this.gbTipoS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoS.Location = new System.Drawing.Point(254, 218);
            this.gbTipoS.Name = "gbTipoS";
            this.gbTipoS.Size = new System.Drawing.Size(173, 62);
            this.gbTipoS.TabIndex = 206;
            this.gbTipoS.TabStop = false;
            this.gbTipoS.Text = "Tipo Sala";
            // 
            // ddTipoSala
            // 
            this.ddTipoSala.BackColor = System.Drawing.Color.Transparent;
            this.ddTipoSala.BorderRadius = 3;
            this.ddTipoSala.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddTipoSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddTipoSala.Items = new string[] {
        "Estudios",
        "Club",
        "Conferencia",
        "Reunion"};
            this.ddTipoSala.Location = new System.Drawing.Point(6, 22);
            this.ddTipoSala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddTipoSala.Name = "ddTipoSala";
            this.ddTipoSala.NomalColor = System.Drawing.Color.White;
            this.ddTipoSala.onHoverColor = System.Drawing.SystemColors.ControlLight;
            this.ddTipoSala.selectedIndex = -1;
            this.ddTipoSala.Size = new System.Drawing.Size(161, 31);
            this.ddTipoSala.TabIndex = 168;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditar.Location = new System.Drawing.Point(364, 167);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(45, 17);
            this.lblEditar.TabIndex = 210;
            this.lblEditar.Text = "Editar";
            // 
            // cbEditar
            // 
            this.cbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbEditar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbEditar.Checked = false;
            this.cbEditar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.cbEditar.ForeColor = System.Drawing.Color.White;
            this.cbEditar.Location = new System.Drawing.Point(338, 165);
            this.cbEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEditar.Name = "cbEditar";
            this.cbEditar.Size = new System.Drawing.Size(20, 20);
            this.cbEditar.TabIndex = 209;
            this.cbEditar.OnChange += new System.EventHandler(this.cbEditar_OnChange);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HintForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.HintText = "Buscar por No. Sala o ID";
            this.txtBuscar.isPassword = false;
            this.txtBuscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtBuscar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtBuscar.LineThickness = 3;
            this.txtBuscar.Location = new System.Drawing.Point(68, 94);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(312, 31);
            this.txtBuscar.TabIndex = 208;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // txtmaxper
            // 
            this.txtmaxper.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaxper.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmaxper.ForeColor = System.Drawing.Color.Black;
            this.txtmaxper.HintForeColor = System.Drawing.Color.Gray;
            this.txtmaxper.HintText = "Max. Personas";
            this.txtmaxper.isPassword = false;
            this.txtmaxper.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtmaxper.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmaxper.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtmaxper.LineThickness = 3;
            this.txtmaxper.Location = new System.Drawing.Point(151, 154);
            this.txtmaxper.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaxper.Name = "txtmaxper";
            this.txtmaxper.Size = new System.Drawing.Size(112, 31);
            this.txtmaxper.TabIndex = 207;
            this.txtmaxper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbNSala
            // 
            this.gbNSala.Controls.Add(this.ddNoSala);
            this.gbNSala.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNSala.Location = new System.Drawing.Point(48, 218);
            this.gbNSala.Name = "gbNSala";
            this.gbNSala.Size = new System.Drawing.Size(173, 62);
            this.gbNSala.TabIndex = 205;
            this.gbNSala.TabStop = false;
            this.gbNSala.Text = "No. Sala";
            // 
            // ddNoSala
            // 
            this.ddNoSala.BackColor = System.Drawing.Color.Transparent;
            this.ddNoSala.BorderRadius = 3;
            this.ddNoSala.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddNoSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddNoSala.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9"};
            this.ddNoSala.Location = new System.Drawing.Point(6, 22);
            this.ddNoSala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddNoSala.Name = "ddNoSala";
            this.ddNoSala.NomalColor = System.Drawing.Color.White;
            this.ddNoSala.onHoverColor = System.Drawing.SystemColors.ControlLight;
            this.ddNoSala.selectedIndex = -1;
            this.ddNoSala.Size = new System.Drawing.Size(161, 31);
            this.ddNoSala.TabIndex = 168;
            // 
            // lblRyCS
            // 
            this.lblRyCS.AutoSize = true;
            this.lblRyCS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRyCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblRyCS.Location = new System.Drawing.Point(103, 55);
            this.lblRyCS.Name = "lblRyCS";
            this.lblRyCS.Size = new System.Drawing.Size(246, 23);
            this.lblRyCS.TabIndex = 201;
            this.lblRyCS.Text = "Registro y Consulta de Salas";
            this.lblRyCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtID.Location = new System.Drawing.Point(48, 154);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(72, 31);
            this.txtID.TabIndex = 202;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(611, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 204;
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
            this.btnAgregar.Location = new System.Drawing.Point(477, 256);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 39);
            this.btnAgregar.TabIndex = 203;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbConsultaEmpl
            // 
            this.pbConsultaEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbConsultaEmpl.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.events_rooms;
            this.pbConsultaEmpl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbConsultaEmpl.Location = new System.Drawing.Point(485, 55);
            this.pbConsultaEmpl.Name = "pbConsultaEmpl";
            this.pbConsultaEmpl.Size = new System.Drawing.Size(122, 127);
            this.pbConsultaEmpl.TabIndex = 200;
            this.pbConsultaEmpl.TabStop = false;
            this.pbConsultaEmpl.Click += new System.EventHandler(this.pbConsultaEmpl_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(477, 256);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 39);
            this.btnGuardar.TabIndex = 211;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // ConsultaSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(654, 514);
            this.Controls.Add(this.dgSalas);
            this.Controls.Add(this.gbTipoS);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.cbEditar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtmaxper);
            this.Controls.Add(this.gbNSala);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRyCS);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pbConsultaEmpl);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultaSalas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultaSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).EndInit();
            this.gbTipoS.ResumeLayout(false);
            this.gbNSala.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultaEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSalas;
        private System.Windows.Forms.GroupBox gbTipoS;
        private Bunifu.Framework.UI.BunifuDropdown ddTipoSala;
        private System.Windows.Forms.Label lblEditar;
        private Bunifu.Framework.UI.BunifuCheckbox cbEditar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtmaxper;
        private System.Windows.Forms.GroupBox gbNSala;
        private Bunifu.Framework.UI.BunifuDropdown ddNoSala;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.Label lblRyCS;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.PictureBox pbConsultaEmpl;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SALAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAX_PERSONAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_EVENTOS;
    }
}