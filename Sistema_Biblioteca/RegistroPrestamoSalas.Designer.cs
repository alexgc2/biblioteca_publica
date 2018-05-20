namespace Sistema_Biblioteca
{
    partial class RegistroPrestamoSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPrestamoSalas));
            this.pContent = new System.Windows.Forms.Panel();
            this.gbPrestamista = new System.Windows.Forms.GroupBox();
            this.txtNoAsis = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombreE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDuracion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.gbSala = new System.Windows.Forms.GroupBox();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.ddstatus = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtNoSala = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbEmp = new System.Windows.Forms.GroupBox();
            this.txtIDE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarLibro = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBuscarLibro = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.pContent.SuspendLayout();
            this.gbPrestamista.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.gbSala.SuspendLayout();
            this.gbstatus.SuspendLayout();
            this.gbEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContent.Controls.Add(this.gbPrestamista);
            this.pContent.Controls.Add(this.gbFecha);
            this.pContent.Controls.Add(this.lblRegistro);
            this.pContent.Controls.Add(this.btnSalir);
            this.pContent.Controls.Add(this.btnAgregarLibro);
            this.pContent.Controls.Add(this.gbSala);
            this.pContent.Controls.Add(this.gbEmp);
            this.pContent.Controls.Add(this.pbLibro);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(655, 515);
            this.pContent.TabIndex = 106;
            // 
            // gbPrestamista
            // 
            this.gbPrestamista.Controls.Add(this.txtNoAsis);
            this.gbPrestamista.Controls.Add(this.txtNombreE);
            this.gbPrestamista.Controls.Add(this.txtDuracion);
            this.gbPrestamista.Controls.Add(this.bunifuMaterialTextbox3);
            this.gbPrestamista.Controls.Add(this.txtNombre);
            this.gbPrestamista.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestamista.Location = new System.Drawing.Point(42, 210);
            this.gbPrestamista.Name = "gbPrestamista";
            this.gbPrestamista.Size = new System.Drawing.Size(580, 130);
            this.gbPrestamista.TabIndex = 196;
            this.gbPrestamista.TabStop = false;
            this.gbPrestamista.Text = "Prestamista";
            // 
            // txtNoAsis
            // 
            this.txtNoAsis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoAsis.Enabled = false;
            this.txtNoAsis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoAsis.ForeColor = System.Drawing.Color.Black;
            this.txtNoAsis.HintForeColor = System.Drawing.Color.Gray;
            this.txtNoAsis.HintText = "No. Asistentes";
            this.txtNoAsis.isPassword = false;
            this.txtNoAsis.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNoAsis.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoAsis.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNoAsis.LineThickness = 3;
            this.txtNoAsis.Location = new System.Drawing.Point(449, 82);
            this.txtNoAsis.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoAsis.Name = "txtNoAsis";
            this.txtNoAsis.Size = new System.Drawing.Size(104, 31);
            this.txtNoAsis.TabIndex = 197;
            this.txtNoAsis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreE.Enabled = false;
            this.txtNombreE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreE.ForeColor = System.Drawing.Color.Black;
            this.txtNombreE.HintForeColor = System.Drawing.Color.Gray;
            this.txtNombreE.HintText = "Nombre Evento";
            this.txtNombreE.isPassword = false;
            this.txtNombreE.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombreE.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreE.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombreE.LineThickness = 3;
            this.txtNombreE.Location = new System.Drawing.Point(16, 82);
            this.txtNombreE.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(276, 31);
            this.txtNombreE.TabIndex = 196;
            this.txtNombreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDuracion.ForeColor = System.Drawing.Color.Black;
            this.txtDuracion.HintForeColor = System.Drawing.Color.Gray;
            this.txtDuracion.HintText = "Duracion";
            this.txtDuracion.isPassword = false;
            this.txtDuracion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtDuracion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDuracion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtDuracion.LineThickness = 3;
            this.txtDuracion.Location = new System.Drawing.Point(306, 82);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(102, 31);
            this.txtDuracion.TabIndex = 195;
            this.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.HintText = "ID";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(26, 28);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(81, 31);
            this.bunifuMaterialTextbox3.TabIndex = 194;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintForeColor = System.Drawing.Color.Gray;
            this.txtNombre.HintText = "Nombre Encargado";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(162, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(391, 31);
            this.txtNombre.TabIndex = 193;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.dtFecha);
            this.gbFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(222, 120);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(219, 62);
            this.gbFecha.TabIndex = 162;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha Evento";
            // 
            // dtFecha
            // 
            this.dtFecha.BackColor = System.Drawing.Color.White;
            this.dtFecha.BorderRadius = 0;
            this.dtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFecha.FormatCustom = null;
            this.dtFecha.Location = new System.Drawing.Point(6, 20);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(207, 31);
            this.dtFecha.TabIndex = 0;
            this.dtFecha.Value = new System.DateTime(2018, 4, 22, 4, 34, 16, 910);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblRegistro.Location = new System.Drawing.Point(218, 51);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(145, 22);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Prestamo Salas";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSala
            // 
            this.gbSala.Controls.Add(this.gbstatus);
            this.gbSala.Controls.Add(this.txtNoSala);
            this.gbSala.Controls.Add(this.txtID);
            this.gbSala.Controls.Add(this.bunifuMaterialTextbox1);
            this.gbSala.Controls.Add(this.btnBuscarLibro);
            this.gbSala.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSala.Location = new System.Drawing.Point(42, 346);
            this.gbSala.Name = "gbSala";
            this.gbSala.Size = new System.Drawing.Size(580, 106);
            this.gbSala.TabIndex = 129;
            this.gbSala.TabStop = false;
            this.gbSala.Text = "Sala";
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.ddstatus);
            this.gbstatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbstatus.Location = new System.Drawing.Point(300, 28);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Size = new System.Drawing.Size(173, 62);
            this.gbstatus.TabIndex = 198;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Estatus";
            // 
            // ddstatus
            // 
            this.ddstatus.BackColor = System.Drawing.Color.Transparent;
            this.ddstatus.BorderRadius = 3;
            this.ddstatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddstatus.Items = new string[] {
        "Disponible",
        "Ocupada"};
            this.ddstatus.Location = new System.Drawing.Point(6, 22);
            this.ddstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddstatus.Name = "ddstatus";
            this.ddstatus.NomalColor = System.Drawing.Color.White;
            this.ddstatus.onHoverColor = System.Drawing.SystemColors.ControlLight;
            this.ddstatus.selectedIndex = -1;
            this.ddstatus.Size = new System.Drawing.Size(161, 31);
            this.ddstatus.TabIndex = 168;
            // 
            // txtNoSala
            // 
            this.txtNoSala.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoSala.Enabled = false;
            this.txtNoSala.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoSala.ForeColor = System.Drawing.Color.Black;
            this.txtNoSala.HintForeColor = System.Drawing.Color.Gray;
            this.txtNoSala.HintText = "No. Sala";
            this.txtNoSala.isPassword = false;
            this.txtNoSala.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNoSala.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoSala.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNoSala.LineThickness = 3;
            this.txtNoSala.Location = new System.Drawing.Point(162, 22);
            this.txtNoSala.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoSala.Name = "txtNoSala";
            this.txtNoSala.Size = new System.Drawing.Size(112, 31);
            this.txtNoSala.TabIndex = 195;
            this.txtNoSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HintForeColor = System.Drawing.Color.Gray;
            this.txtID.HintText = "ID";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtID.LineThickness = 3;
            this.txtID.Location = new System.Drawing.Point(26, 22);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(81, 31);
            this.txtID.TabIndex = 194;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Enabled = false;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.HintText = "Tipo Sala";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(78, 68);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(140, 31);
            this.bunifuMaterialTextbox1.TabIndex = 193;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbEmp
            // 
            this.gbEmp.Controls.Add(this.txtIDE);
            this.gbEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmp.Location = new System.Drawing.Point(77, 120);
            this.gbEmp.Name = "gbEmp";
            this.gbEmp.Size = new System.Drawing.Size(104, 62);
            this.gbEmp.TabIndex = 125;
            this.gbEmp.TabStop = false;
            this.gbEmp.Text = "ID Empleado";
            // 
            // txtIDE
            // 
            this.txtIDE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDE.Enabled = false;
            this.txtIDE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDE.ForeColor = System.Drawing.Color.Black;
            this.txtIDE.HintForeColor = System.Drawing.Color.Gray;
            this.txtIDE.HintText = "ID";
            this.txtIDE.isPassword = false;
            this.txtIDE.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtIDE.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDE.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtIDE.LineThickness = 3;
            this.txtIDE.Location = new System.Drawing.Point(10, 20);
            this.txtIDE.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDE.Name = "txtIDE";
            this.txtIDE.Size = new System.Drawing.Size(81, 31);
            this.txtIDE.TabIndex = 161;
            this.txtIDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(618, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.ActiveBorderThickness = 1;
            this.btnAgregarLibro.ActiveCornerRadius = 20;
            this.btnAgregarLibro.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarLibro.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarLibro.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarLibro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarLibro.BackgroundImage")));
            this.btnAgregarLibro.ButtonText = "Agregar";
            this.btnAgregarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarLibro.IdleBorderThickness = 1;
            this.btnAgregarLibro.IdleCornerRadius = 25;
            this.btnAgregarLibro.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarLibro.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarLibro.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarLibro.Location = new System.Drawing.Point(522, 460);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(100, 39);
            this.btnAgregarLibro.TabIndex = 130;
            this.btnAgregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarLibro.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarLibro.ImageActive = null;
            this.btnBuscarLibro.Location = new System.Drawing.Point(518, 40);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarLibro.TabIndex = 192;
            this.btnBuscarLibro.TabStop = false;
            this.btnBuscarLibro.Zoom = 10;
            // 
            // pbLibro
            // 
            this.pbLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLibro.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.add_sala;
            this.pbLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLibro.Location = new System.Drawing.Point(491, 51);
            this.pbLibro.Name = "pbLibro";
            this.pbLibro.Size = new System.Drawing.Size(131, 137);
            this.pbLibro.TabIndex = 124;
            this.pbLibro.TabStop = false;
            this.pbLibro.Click += new System.EventHandler(this.pbLibro_Click);
            // 
            // RegistroPrestamoSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 515);
            this.Controls.Add(this.pContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroPrestamoSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistroPrestamoSalas";
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.gbPrestamista.ResumeLayout(false);
            this.gbFecha.ResumeLayout(false);
            this.gbSala.ResumeLayout(false);
            this.gbstatus.ResumeLayout(false);
            this.gbEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.GroupBox gbPrestamista;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNoAsis;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreE;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDuracion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.GroupBox gbFecha;
        private Bunifu.Framework.UI.BunifuDatepicker dtFecha;
        private System.Windows.Forms.Label lblRegistro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarLibro;
        private System.Windows.Forms.GroupBox gbSala;
        private System.Windows.Forms.GroupBox gbstatus;
        private Bunifu.Framework.UI.BunifuDropdown ddstatus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNoSala;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarLibro;
        private System.Windows.Forms.GroupBox gbEmp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDE;
        private System.Windows.Forms.PictureBox pbLibro;
    }
}