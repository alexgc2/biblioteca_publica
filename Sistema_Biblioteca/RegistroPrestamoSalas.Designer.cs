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
            this.gbxInfoEvento = new System.Windows.Forms.GroupBox();
            this.txtNombreE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNoAsis = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDuracion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbPrestamista = new System.Windows.Forms.GroupBox();
            this.btnBuscarMiembro = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtNombreM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIDM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarLibro = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbSala = new System.Windows.Forms.GroupBox();
            this.txtCapacidadMaxima = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNoSala = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIDS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTipoSala = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBuscarLibro = new Bunifu.Framework.UI.BunifuImageButton();
            this.gbEmp = new System.Windows.Forms.GroupBox();
            this.txtIDE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.pContent.SuspendLayout();
            this.gbxInfoEvento.SuspendLayout();
            this.gbPrestamista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMiembro)).BeginInit();
            this.gbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.gbSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLibro)).BeginInit();
            this.gbEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContent.Controls.Add(this.gbxInfoEvento);
            this.pContent.Controls.Add(this.gbPrestamista);
            this.pContent.Controls.Add(this.lblRegistro);
            this.pContent.Controls.Add(this.btnSalir);
            this.pContent.Controls.Add(this.btnAgregarLibro);
            this.pContent.Controls.Add(this.gbSala);
            this.pContent.Controls.Add(this.gbEmp);
            this.pContent.Controls.Add(this.pbLibro);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(633, 458);
            this.pContent.TabIndex = 106;
            // 
            // gbxInfoEvento
            // 
            this.gbxInfoEvento.Controls.Add(this.txtNombreE);
            this.gbxInfoEvento.Controls.Add(this.txtNoAsis);
            this.gbxInfoEvento.Controls.Add(this.gbFecha);
            this.gbxInfoEvento.Controls.Add(this.txtDuracion);
            this.gbxInfoEvento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfoEvento.Location = new System.Drawing.Point(33, 203);
            this.gbxInfoEvento.Name = "gbxInfoEvento";
            this.gbxInfoEvento.Size = new System.Drawing.Size(580, 123);
            this.gbxInfoEvento.TabIndex = 198;
            this.gbxInfoEvento.TabStop = false;
            this.gbxInfoEvento.Text = "Información del Evento";
            // 
            // txtNombreE
            // 
            this.txtNombreE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreE.ForeColor = System.Drawing.Color.Black;
            this.txtNombreE.HintForeColor = System.Drawing.Color.Gray;
            this.txtNombreE.HintText = "Nombre Evento";
            this.txtNombreE.isPassword = false;
            this.txtNombreE.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombreE.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreE.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombreE.LineThickness = 3;
            this.txtNombreE.Location = new System.Drawing.Point(17, 22);
            this.txtNombreE.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(276, 31);
            this.txtNombreE.TabIndex = 196;
            this.txtNombreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoAsis
            // 
            this.txtNoAsis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoAsis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoAsis.ForeColor = System.Drawing.Color.Black;
            this.txtNoAsis.HintForeColor = System.Drawing.Color.Gray;
            this.txtNoAsis.HintText = "No. Asistentes";
            this.txtNoAsis.isPassword = false;
            this.txtNoAsis.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNoAsis.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoAsis.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNoAsis.LineThickness = 3;
            this.txtNoAsis.Location = new System.Drawing.Point(36, 75);
            this.txtNoAsis.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoAsis.Name = "txtNoAsis";
            this.txtNoAsis.Size = new System.Drawing.Size(104, 31);
            this.txtNoAsis.TabIndex = 197;
            this.txtNoAsis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuracion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDuracion.ForeColor = System.Drawing.Color.Black;
            this.txtDuracion.HintForeColor = System.Drawing.Color.Gray;
            this.txtDuracion.HintText = "Duracion";
            this.txtDuracion.isPassword = false;
            this.txtDuracion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtDuracion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDuracion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtDuracion.LineThickness = 3;
            this.txtDuracion.Location = new System.Drawing.Point(164, 75);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(102, 31);
            this.txtDuracion.TabIndex = 195;
            this.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPrestamista
            // 
            this.gbPrestamista.Controls.Add(this.btnBuscarMiembro);
            this.gbPrestamista.Controls.Add(this.txtNombreM);
            this.gbPrestamista.Controls.Add(this.txtIDM);
            this.gbPrestamista.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestamista.Location = new System.Drawing.Point(33, 128);
            this.gbPrestamista.Name = "gbPrestamista";
            this.gbPrestamista.Size = new System.Drawing.Size(413, 69);
            this.gbPrestamista.TabIndex = 196;
            this.gbPrestamista.TabStop = false;
            this.gbPrestamista.Text = "Miembro Responsable";
            // 
            // btnBuscarMiembro
            // 
            this.btnBuscarMiembro.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMiembro.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarMiembro.ImageActive = null;
            this.btnBuscarMiembro.Location = new System.Drawing.Point(362, 22);
            this.btnBuscarMiembro.Name = "btnBuscarMiembro";
            this.btnBuscarMiembro.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarMiembro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarMiembro.TabIndex = 195;
            this.btnBuscarMiembro.TabStop = false;
            this.btnBuscarMiembro.Zoom = 10;
            this.btnBuscarMiembro.Click += new System.EventHandler(this.btnBuscarMiembro_Click);
            // 
            // txtNombreM
            // 
            this.txtNombreM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreM.Enabled = false;
            this.txtNombreM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreM.ForeColor = System.Drawing.Color.Black;
            this.txtNombreM.HintForeColor = System.Drawing.Color.Gray;
            this.txtNombreM.HintText = "Nombre Encargado";
            this.txtNombreM.isPassword = false;
            this.txtNombreM.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombreM.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreM.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombreM.LineThickness = 3;
            this.txtNombreM.Location = new System.Drawing.Point(74, 22);
            this.txtNombreM.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(281, 31);
            this.txtNombreM.TabIndex = 193;
            this.txtNombreM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtIDM.Location = new System.Drawing.Point(17, 22);
            this.txtIDM.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDM.Name = "txtIDM";
            this.txtIDM.Size = new System.Drawing.Size(49, 31);
            this.txtIDM.TabIndex = 194;
            this.txtIDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.dtFecha);
            this.gbFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(323, 33);
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
            this.dtFecha.Size = new System.Drawing.Size(206, 31);
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
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(596, 3);
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
            this.btnAgregarLibro.Location = new System.Drawing.Point(455, 365);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(100, 39);
            this.btnAgregarLibro.TabIndex = 130;
            this.btnAgregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // gbSala
            // 
            this.gbSala.Controls.Add(this.txtCapacidadMaxima);
            this.gbSala.Controls.Add(this.txtNoSala);
            this.gbSala.Controls.Add(this.txtIDS);
            this.gbSala.Controls.Add(this.txtTipoSala);
            this.gbSala.Controls.Add(this.btnBuscarLibro);
            this.gbSala.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSala.Location = new System.Drawing.Point(33, 332);
            this.gbSala.Name = "gbSala";
            this.gbSala.Size = new System.Drawing.Size(355, 106);
            this.gbSala.TabIndex = 129;
            this.gbSala.TabStop = false;
            this.gbSala.Text = "Sala";
            // 
            // txtCapacidadMaxima
            // 
            this.txtCapacidadMaxima.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacidadMaxima.Enabled = false;
            this.txtCapacidadMaxima.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCapacidadMaxima.ForeColor = System.Drawing.Color.Black;
            this.txtCapacidadMaxima.HintForeColor = System.Drawing.Color.Gray;
            this.txtCapacidadMaxima.HintText = "Capacidad maxima";
            this.txtCapacidadMaxima.isPassword = false;
            this.txtCapacidadMaxima.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtCapacidadMaxima.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCapacidadMaxima.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtCapacidadMaxima.LineThickness = 3;
            this.txtCapacidadMaxima.Location = new System.Drawing.Point(164, 68);
            this.txtCapacidadMaxima.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacidadMaxima.Name = "txtCapacidadMaxima";
            this.txtCapacidadMaxima.Size = new System.Drawing.Size(177, 31);
            this.txtCapacidadMaxima.TabIndex = 196;
            this.txtCapacidadMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtNoSala.Location = new System.Drawing.Point(115, 22);
            this.txtNoSala.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoSala.Name = "txtNoSala";
            this.txtNoSala.Size = new System.Drawing.Size(112, 31);
            this.txtNoSala.TabIndex = 195;
            this.txtNoSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDS
            // 
            this.txtIDS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDS.Enabled = false;
            this.txtIDS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDS.ForeColor = System.Drawing.Color.Black;
            this.txtIDS.HintForeColor = System.Drawing.Color.Gray;
            this.txtIDS.HintText = "ID";
            this.txtIDS.isPassword = false;
            this.txtIDS.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtIDS.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDS.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtIDS.LineThickness = 3;
            this.txtIDS.Location = new System.Drawing.Point(16, 22);
            this.txtIDS.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDS.Name = "txtIDS";
            this.txtIDS.Size = new System.Drawing.Size(81, 31);
            this.txtIDS.TabIndex = 194;
            this.txtIDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipoSala
            // 
            this.txtTipoSala.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoSala.Enabled = false;
            this.txtTipoSala.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTipoSala.ForeColor = System.Drawing.Color.Black;
            this.txtTipoSala.HintForeColor = System.Drawing.Color.Gray;
            this.txtTipoSala.HintText = "Tipo Sala";
            this.txtTipoSala.isPassword = false;
            this.txtTipoSala.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtTipoSala.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoSala.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtTipoSala.LineThickness = 3;
            this.txtTipoSala.Location = new System.Drawing.Point(16, 68);
            this.txtTipoSala.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoSala.Name = "txtTipoSala";
            this.txtTipoSala.Size = new System.Drawing.Size(140, 31);
            this.txtTipoSala.TabIndex = 193;
            this.txtTipoSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarLibro.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarLibro.ImageActive = null;
            this.btnBuscarLibro.Location = new System.Drawing.Point(286, 18);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarLibro.TabIndex = 192;
            this.btnBuscarLibro.TabStop = false;
            this.btnBuscarLibro.Zoom = 10;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // gbEmp
            // 
            this.gbEmp.Controls.Add(this.txtIDE);
            this.gbEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmp.Location = new System.Drawing.Point(33, 61);
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
            this.pbLibro.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.add_sala;
            this.pbLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLibro.Location = new System.Drawing.Point(473, 50);
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
            this.ClientSize = new System.Drawing.Size(633, 458);
            this.Controls.Add(this.pContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroPrestamoSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistroPrestamoSalas";
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.gbxInfoEvento.ResumeLayout(false);
            this.gbPrestamista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMiembro)).EndInit();
            this.gbFecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.gbSala.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLibro)).EndInit();
            this.gbEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.GroupBox gbFecha;
        private Bunifu.Framework.UI.BunifuDatepicker dtFecha;
        private System.Windows.Forms.Label lblRegistro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarLibro;
        private System.Windows.Forms.GroupBox gbSala;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNoSala;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDS;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipoSala;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarLibro;
        private System.Windows.Forms.GroupBox gbEmp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDE;
        private System.Windows.Forms.PictureBox pbLibro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCapacidadMaxima;
        private System.Windows.Forms.GroupBox gbPrestamista;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNoAsis;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreE;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDuracion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDM;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreM;
        private System.Windows.Forms.GroupBox gbxInfoEvento;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarMiembro;
    }
}