namespace Sistema_Biblioteca
{
    partial class RegistroPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPrestamos));
            this.pContent = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaEntrega = new Bunifu.Framework.UI.BunifuDatepicker();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtFechaPrestamo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarLibro = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbLibro = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEdicion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAutor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtArea = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombreLibro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBuscarLibro = new Bunifu.Framework.UI.BunifuImageButton();
            this.gbMiembro = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOcupacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIDM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBuscarMiembro = new Bunifu.Framework.UI.BunifuImageButton();
            this.label15 = new System.Windows.Forms.Label();
            this.gbEmp = new System.Windows.Forms.GroupBox();
            this.txtIDE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.pContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.gbLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLibro)).BeginInit();
            this.gbMiembro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMiembro)).BeginInit();
            this.gbEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContent.Controls.Add(this.groupBox1);
            this.pContent.Controls.Add(this.gbFecha);
            this.pContent.Controls.Add(this.lblRegistro);
            this.pContent.Controls.Add(this.btnSalir);
            this.pContent.Controls.Add(this.btnAgregarLibro);
            this.pContent.Controls.Add(this.gbLibro);
            this.pContent.Controls.Add(this.gbMiembro);
            this.pContent.Controls.Add(this.gbEmp);
            this.pContent.Controls.Add(this.pbLibro);
            this.pContent.Location = new System.Drawing.Point(1, 1);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(642, 515);
            this.pContent.TabIndex = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaEntrega);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(257, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 62);
            this.groupBox1.TabIndex = 163;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de Entrega";
            // 
            // dtFechaEntrega
            // 
            this.dtFechaEntrega.BackColor = System.Drawing.Color.White;
            this.dtFechaEntrega.BorderRadius = 0;
            this.dtFechaEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFechaEntrega.FormatCustom = null;
            this.dtFechaEntrega.Location = new System.Drawing.Point(6, 20);
            this.dtFechaEntrega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaEntrega.Name = "dtFechaEntrega";
            this.dtFechaEntrega.Size = new System.Drawing.Size(207, 31);
            this.dtFechaEntrega.TabIndex = 1;
            this.dtFechaEntrega.Value = new System.DateTime(2018, 5, 8, 0, 0, 0, 0);
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.dtFechaPrestamo);
            this.gbFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(29, 119);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(219, 62);
            this.gbFecha.TabIndex = 162;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha de Registro de Prestamo";
            // 
            // dtFechaPrestamo
            // 
            this.dtFechaPrestamo.BackColor = System.Drawing.Color.White;
            this.dtFechaPrestamo.BorderRadius = 0;
            this.dtFechaPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFechaPrestamo.FormatCustom = null;
            this.dtFechaPrestamo.Location = new System.Drawing.Point(6, 20);
            this.dtFechaPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaPrestamo.Name = "dtFechaPrestamo";
            this.dtFechaPrestamo.Size = new System.Drawing.Size(207, 31);
            this.dtFechaPrestamo.TabIndex = 0;
            this.dtFechaPrestamo.Tag = "";
            this.dtFechaPrestamo.Value = new System.DateTime(2018, 5, 8, 17, 2, 7, 0);
            this.dtFechaPrestamo.onValueChanged += new System.EventHandler(this.dtFecha_onValueChanged);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblRegistro.Location = new System.Drawing.Point(218, 51);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(172, 22);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Registro Prestamo";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(607, 3);
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
            this.btnAgregarLibro.Location = new System.Drawing.Point(517, 461);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(100, 39);
            this.btnAgregarLibro.TabIndex = 130;
            this.btnAgregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // gbLibro
            // 
            this.gbLibro.Controls.Add(this.txtCodigo);
            this.gbLibro.Controls.Add(this.txtCantidad);
            this.gbLibro.Controls.Add(this.txtEdicion);
            this.gbLibro.Controls.Add(this.txtAutor);
            this.gbLibro.Controls.Add(this.txtArea);
            this.gbLibro.Controls.Add(this.txtNombreLibro);
            this.gbLibro.Controls.Add(this.btnBuscarLibro);
            this.gbLibro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLibro.Location = new System.Drawing.Point(29, 320);
            this.gbLibro.Name = "gbLibro";
            this.gbLibro.Size = new System.Drawing.Size(580, 138);
            this.gbLibro.TabIndex = 129;
            this.gbLibro.TabStop = false;
            this.gbLibro.Text = "Libro";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.HintForeColor = System.Drawing.Color.Gray;
            this.txtCodigo.HintText = "Codigo";
            this.txtCodigo.isPassword = false;
            this.txtCodigo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtCodigo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtCodigo.LineThickness = 3;
            this.txtCodigo.Location = new System.Drawing.Point(15, 18);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(137, 31);
            this.txtCodigo.TabIndex = 172;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.HintForeColor = System.Drawing.Color.Gray;
            this.txtCantidad.HintText = "Cantidad";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtCantidad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtCantidad.LineThickness = 3;
            this.txtCantidad.Location = new System.Drawing.Point(343, 98);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(109, 31);
            this.txtCantidad.TabIndex = 176;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdicion.Enabled = false;
            this.txtEdicion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEdicion.ForeColor = System.Drawing.Color.Black;
            this.txtEdicion.HintForeColor = System.Drawing.Color.Gray;
            this.txtEdicion.HintText = "Edicion";
            this.txtEdicion.isPassword = false;
            this.txtEdicion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtEdicion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEdicion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtEdicion.LineThickness = 3;
            this.txtEdicion.Location = new System.Drawing.Point(42, 98);
            this.txtEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(260, 31);
            this.txtEdicion.TabIndex = 175;
            this.txtEdicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAutor
            // 
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.Enabled = false;
            this.txtAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAutor.ForeColor = System.Drawing.Color.Black;
            this.txtAutor.HintForeColor = System.Drawing.Color.Gray;
            this.txtAutor.HintText = "Autor";
            this.txtAutor.isPassword = false;
            this.txtAutor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtAutor.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAutor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtAutor.LineThickness = 3;
            this.txtAutor.Location = new System.Drawing.Point(275, 58);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(223, 31);
            this.txtAutor.TabIndex = 174;
            this.txtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArea
            // 
            this.txtArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtArea.ForeColor = System.Drawing.Color.Black;
            this.txtArea.HintForeColor = System.Drawing.Color.Gray;
            this.txtArea.HintText = "Area";
            this.txtArea.isPassword = false;
            this.txtArea.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtArea.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtArea.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtArea.LineThickness = 3;
            this.txtArea.Location = new System.Drawing.Point(37, 58);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(209, 31);
            this.txtArea.TabIndex = 173;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreLibro.Enabled = false;
            this.txtNombreLibro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreLibro.ForeColor = System.Drawing.Color.Black;
            this.txtNombreLibro.HintForeColor = System.Drawing.Color.Gray;
            this.txtNombreLibro.HintText = "Nombre";
            this.txtNombreLibro.isPassword = false;
            this.txtNombreLibro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombreLibro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreLibro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombreLibro.LineThickness = 3;
            this.txtNombreLibro.Location = new System.Drawing.Point(176, 18);
            this.txtNombreLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(390, 31);
            this.txtNombreLibro.TabIndex = 172;
            this.txtNombreLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarLibro.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarLibro.ImageActive = null;
            this.btnBuscarLibro.Location = new System.Drawing.Point(514, 98);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarLibro.TabIndex = 123;
            this.btnBuscarLibro.TabStop = false;
            this.btnBuscarLibro.Zoom = 10;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // gbMiembro
            // 
            this.gbMiembro.Controls.Add(this.txtApellidos);
            this.gbMiembro.Controls.Add(this.txtTipo);
            this.gbMiembro.Controls.Add(this.txtNombre);
            this.gbMiembro.Controls.Add(this.txtOcupacion);
            this.gbMiembro.Controls.Add(this.txtIDM);
            this.gbMiembro.Controls.Add(this.btnBuscarMiembro);
            this.gbMiembro.Controls.Add(this.label15);
            this.gbMiembro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMiembro.Location = new System.Drawing.Point(29, 188);
            this.gbMiembro.Name = "gbMiembro";
            this.gbMiembro.Size = new System.Drawing.Size(580, 126);
            this.gbMiembro.TabIndex = 128;
            this.gbMiembro.TabStop = false;
            this.gbMiembro.Text = "Miembro";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellidos.ForeColor = System.Drawing.Color.Black;
            this.txtApellidos.HintForeColor = System.Drawing.Color.Gray;
            this.txtApellidos.HintText = "Apellidos";
            this.txtApellidos.isPassword = false;
            this.txtApellidos.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtApellidos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtApellidos.LineThickness = 3;
            this.txtApellidos.Location = new System.Drawing.Point(297, 60);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(264, 31);
            this.txtApellidos.TabIndex = 171;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTipo.ForeColor = System.Drawing.Color.Black;
            this.txtTipo.HintForeColor = System.Drawing.Color.Gray;
            this.txtTipo.HintText = "Tipo";
            this.txtTipo.isPassword = false;
            this.txtTipo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtTipo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtTipo.LineThickness = 3;
            this.txtTipo.Location = new System.Drawing.Point(329, 18);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(176, 31);
            this.txtTipo.TabIndex = 169;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintForeColor = System.Drawing.Color.Gray;
            this.txtNombre.HintText = "Nombre";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(10, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 31);
            this.txtNombre.TabIndex = 170;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOcupacion.Enabled = false;
            this.txtOcupacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOcupacion.ForeColor = System.Drawing.Color.Black;
            this.txtOcupacion.HintForeColor = System.Drawing.Color.Gray;
            this.txtOcupacion.HintText = "Ocupacion";
            this.txtOcupacion.isPassword = false;
            this.txtOcupacion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtOcupacion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOcupacion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtOcupacion.LineThickness = 3;
            this.txtOcupacion.Location = new System.Drawing.Point(126, 18);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(171, 31);
            this.txtOcupacion.TabIndex = 163;
            this.txtOcupacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDM
            // 
            this.txtIDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDM.Enabled = false;
            this.txtIDM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDM.ForeColor = System.Drawing.Color.Black;
            this.txtIDM.HintForeColor = System.Drawing.Color.Gray;
            this.txtIDM.HintText = "ID";
            this.txtIDM.isPassword = false;
            this.txtIDM.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtIDM.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDM.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtIDM.LineThickness = 3;
            this.txtIDM.Location = new System.Drawing.Point(10, 18);
            this.txtIDM.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDM.Name = "txtIDM";
            this.txtIDM.Size = new System.Drawing.Size(81, 31);
            this.txtIDM.TabIndex = 162;
            this.txtIDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscarMiembro
            // 
            this.btnBuscarMiembro.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMiembro.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarMiembro.ImageActive = null;
            this.btnBuscarMiembro.Location = new System.Drawing.Point(526, 18);
            this.btnBuscarMiembro.Name = "btnBuscarMiembro";
            this.btnBuscarMiembro.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarMiembro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarMiembro.TabIndex = 128;
            this.btnBuscarMiembro.TabStop = false;
            this.btnBuscarMiembro.Zoom = 10;
            this.btnBuscarMiembro.Click += new System.EventHandler(this.btnBuscarMiembro_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 176);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 18);
            this.label15.TabIndex = 45;
            this.label15.Text = "Ocupacion";
            // 
            // gbEmp
            // 
            this.gbEmp.Controls.Add(this.txtIDE);
            this.gbEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmp.Location = new System.Drawing.Point(29, 51);
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
            // pbLibro
            // 
            this.pbLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLibro.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.new_page_document_16676;
            this.pbLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLibro.Location = new System.Drawing.Point(486, 52);
            this.pbLibro.Name = "pbLibro";
            this.pbLibro.Size = new System.Drawing.Size(131, 137);
            this.pbLibro.TabIndex = 124;
            this.pbLibro.TabStop = false;
            // 
            // RegistroPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(661, 552);
            this.ControlBox = false;
            this.Controls.Add(this.pContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 552);
            this.Name = "RegistroPrestamos";
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbFecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.gbLibro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLibro)).EndInit();
            this.gbMiembro.ResumeLayout(false);
            this.gbMiembro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMiembro)).EndInit();
            this.gbEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaEntrega;
        private System.Windows.Forms.GroupBox gbFecha;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaPrestamo;
        private System.Windows.Forms.Label lblRegistro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarLibro;
        private System.Windows.Forms.GroupBox gbLibro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEdicion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAutor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtArea;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreLibro;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarLibro;
        private System.Windows.Forms.GroupBox gbMiembro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOcupacion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDM;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarMiembro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbEmp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDE;
        private System.Windows.Forms.PictureBox pbLibro;
    }
}