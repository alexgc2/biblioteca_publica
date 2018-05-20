namespace Sistema_Biblioteca
{
    partial class RegistroPrestamoEquipos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPrestamoEquipos));
            this.pContent = new System.Windows.Forms.Panel();
            this.gbHoraE = new System.Windows.Forms.GroupBox();
            this.gbHoraP = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRegistrarPrestamo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbComputadora = new System.Windows.Forms.GroupBox();
            this.txtProveedorC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIDC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTipoC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBuscarCom = new Bunifu.Framework.UI.BunifuImageButton();
            this.gbMiembro = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOcupacionn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIDM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBuscarMiembro = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbEmp = new System.Windows.Forms.GroupBox();
            this.txtIDE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.dtpHoraEntrega = new System.Windows.Forms.DateTimePicker();
            this.pContent.SuspendLayout();
            this.gbHoraE.SuspendLayout();
            this.gbHoraP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.gbComputadora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCom)).BeginInit();
            this.gbMiembro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMiembro)).BeginInit();
            this.gbEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContent.Controls.Add(this.gbHoraE);
            this.pContent.Controls.Add(this.gbHoraP);
            this.pContent.Controls.Add(this.lblRegistro);
            this.pContent.Controls.Add(this.btnSalir);
            this.pContent.Controls.Add(this.btnRegistrarPrestamo);
            this.pContent.Controls.Add(this.gbComputadora);
            this.pContent.Controls.Add(this.gbMiembro);
            this.pContent.Controls.Add(this.gbEmp);
            this.pContent.Controls.Add(this.pbLibro);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(655, 515);
            this.pContent.TabIndex = 106;
            this.pContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pContent_Paint);
            // 
            // gbHoraE
            // 
            this.gbHoraE.Controls.Add(this.dtpHoraEntrega);
            this.gbHoraE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoraE.Location = new System.Drawing.Point(326, 143);
            this.gbHoraE.Name = "gbHoraE";
            this.gbHoraE.Size = new System.Drawing.Size(159, 62);
            this.gbHoraE.TabIndex = 163;
            this.gbHoraE.TabStop = false;
            this.gbHoraE.Text = "Hora Entrega";
            // 
            // gbHoraP
            // 
            this.gbHoraP.Controls.Add(this.lblHora);
            this.gbHoraP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoraP.Location = new System.Drawing.Point(189, 143);
            this.gbHoraP.Name = "gbHoraP";
            this.gbHoraP.Size = new System.Drawing.Size(110, 62);
            this.gbHoraP.TabIndex = 162;
            this.gbHoraP.TabStop = false;
            this.gbHoraP.Text = "Hora Prestamo";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(26, 25);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 20);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblRegistro.Location = new System.Drawing.Point(163, 75);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(170, 22);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Prestamo Equipos";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.ActiveBorderThickness = 1;
            this.btnRegistrarPrestamo.ActiveCornerRadius = 20;
            this.btnRegistrarPrestamo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnRegistrarPrestamo.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarPrestamo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnRegistrarPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarPrestamo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarPrestamo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPrestamo.BackgroundImage")));
            this.btnRegistrarPrestamo.ButtonText = "Agregar";
            this.btnRegistrarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPrestamo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPrestamo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarPrestamo.IdleBorderThickness = 1;
            this.btnRegistrarPrestamo.IdleCornerRadius = 25;
            this.btnRegistrarPrestamo.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarPrestamo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnRegistrarPrestamo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(522, 460);
            this.btnRegistrarPrestamo.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(100, 39);
            this.btnRegistrarPrestamo.TabIndex = 130;
            this.btnRegistrarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // gbComputadora
            // 
            this.gbComputadora.Controls.Add(this.txtProveedorC);
            this.gbComputadora.Controls.Add(this.txtIDC);
            this.gbComputadora.Controls.Add(this.txtTipoC);
            this.gbComputadora.Controls.Add(this.btnBuscarCom);
            this.gbComputadora.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComputadora.Location = new System.Drawing.Point(40, 361);
            this.gbComputadora.Name = "gbComputadora";
            this.gbComputadora.Size = new System.Drawing.Size(550, 91);
            this.gbComputadora.TabIndex = 129;
            this.gbComputadora.TabStop = false;
            this.gbComputadora.Text = "Computadora";
            // 
            // txtProveedorC
            // 
            this.txtProveedorC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedorC.Enabled = false;
            this.txtProveedorC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProveedorC.ForeColor = System.Drawing.Color.Black;
            this.txtProveedorC.HintForeColor = System.Drawing.Color.Gray;
            this.txtProveedorC.HintText = "Proovedor";
            this.txtProveedorC.isPassword = false;
            this.txtProveedorC.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtProveedorC.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedorC.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtProveedorC.LineThickness = 3;
            this.txtProveedorC.Location = new System.Drawing.Point(275, 37);
            this.txtProveedorC.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorC.Name = "txtProveedorC";
            this.txtProveedorC.Size = new System.Drawing.Size(199, 31);
            this.txtProveedorC.TabIndex = 179;
            this.txtProveedorC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDC
            // 
            this.txtIDC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDC.Enabled = false;
            this.txtIDC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDC.ForeColor = System.Drawing.Color.Black;
            this.txtIDC.HintForeColor = System.Drawing.Color.Gray;
            this.txtIDC.HintText = "ID";
            this.txtIDC.isPassword = false;
            this.txtIDC.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtIDC.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDC.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtIDC.LineThickness = 3;
            this.txtIDC.Location = new System.Drawing.Point(19, 36);
            this.txtIDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(72, 31);
            this.txtIDC.TabIndex = 177;
            this.txtIDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipoC
            // 
            this.txtTipoC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoC.Enabled = false;
            this.txtTipoC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTipoC.ForeColor = System.Drawing.Color.Black;
            this.txtTipoC.HintForeColor = System.Drawing.Color.Gray;
            this.txtTipoC.HintText = "Tipo";
            this.txtTipoC.isPassword = false;
            this.txtTipoC.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtTipoC.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoC.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtTipoC.LineThickness = 3;
            this.txtTipoC.Location = new System.Drawing.Point(107, 37);
            this.txtTipoC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoC.Name = "txtTipoC";
            this.txtTipoC.Size = new System.Drawing.Size(152, 31);
            this.txtTipoC.TabIndex = 176;
            this.txtTipoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscarCom
            // 
            this.btnBuscarCom.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCom.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarCom.ImageActive = null;
            this.btnBuscarCom.Location = new System.Drawing.Point(499, 33);
            this.btnBuscarCom.Name = "btnBuscarCom";
            this.btnBuscarCom.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarCom.TabIndex = 123;
            this.btnBuscarCom.TabStop = false;
            this.btnBuscarCom.Zoom = 10;
            this.btnBuscarCom.Click += new System.EventHandler(this.btnBuscarCom_Click);
            // 
            // gbMiembro
            // 
            this.gbMiembro.Controls.Add(this.txtApellidos);
            this.gbMiembro.Controls.Add(this.txtTipo);
            this.gbMiembro.Controls.Add(this.txtNombre);
            this.gbMiembro.Controls.Add(this.txtOcupacionn);
            this.gbMiembro.Controls.Add(this.txtIDM);
            this.gbMiembro.Controls.Add(this.btnBuscarMiembro);
            this.gbMiembro.Controls.Add(this.txtOcupacion);
            this.gbMiembro.Controls.Add(this.label15);
            this.gbMiembro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMiembro.Location = new System.Drawing.Point(29, 229);
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
            // txtOcupacionn
            // 
            this.txtOcupacionn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOcupacionn.Enabled = false;
            this.txtOcupacionn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOcupacionn.ForeColor = System.Drawing.Color.Black;
            this.txtOcupacionn.HintForeColor = System.Drawing.Color.Gray;
            this.txtOcupacionn.HintText = "Ocupacion";
            this.txtOcupacionn.isPassword = false;
            this.txtOcupacionn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtOcupacionn.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOcupacionn.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtOcupacionn.LineThickness = 3;
            this.txtOcupacionn.Location = new System.Drawing.Point(126, 18);
            this.txtOcupacionn.Margin = new System.Windows.Forms.Padding(4);
            this.txtOcupacionn.Name = "txtOcupacionn";
            this.txtOcupacionn.Size = new System.Drawing.Size(171, 31);
            this.txtOcupacionn.TabIndex = 163;
            this.txtOcupacionn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtOcupacion
            // 
            this.txtOcupacion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.Location = new System.Drawing.Point(108, 173);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(274, 26);
            this.txtOcupacion.TabIndex = 44;
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
            this.gbEmp.Location = new System.Drawing.Point(40, 143);
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
            this.pbLibro.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.add_pc;
            this.pbLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLibro.Location = new System.Drawing.Point(491, 51);
            this.pbLibro.Name = "pbLibro";
            this.pbLibro.Size = new System.Drawing.Size(131, 137);
            this.pbLibro.TabIndex = 124;
            this.pbLibro.TabStop = false;
            this.pbLibro.Click += new System.EventHandler(this.pbLibro_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // dtpHoraEntrega
            // 
            this.dtpHoraEntrega.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpHoraEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrega.Location = new System.Drawing.Point(20, 25);
            this.dtpHoraEntrega.Name = "dtpHoraEntrega";
            this.dtpHoraEntrega.ShowUpDown = true;
            this.dtpHoraEntrega.Size = new System.Drawing.Size(113, 22);
            this.dtpHoraEntrega.TabIndex = 164;
            // 
            // RegistroPrestamoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 515);
            this.Controls.Add(this.pContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroPrestamoEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReegistroPrestamoEquipos";
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.gbHoraE.ResumeLayout(false);
            this.gbHoraP.ResumeLayout(false);
            this.gbHoraP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.gbComputadora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCom)).EndInit();
            this.gbMiembro.ResumeLayout(false);
            this.gbMiembro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMiembro)).EndInit();
            this.gbEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.GroupBox gbHoraE;
        private System.Windows.Forms.GroupBox gbHoraP;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblRegistro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrarPrestamo;
        private System.Windows.Forms.GroupBox gbComputadora;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipoC;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarCom;
        private System.Windows.Forms.GroupBox gbMiembro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOcupacionn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDM;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarMiembro;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbEmp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDE;
        private System.Windows.Forms.PictureBox pbLibro;
        private System.Windows.Forms.Timer Tiempo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProveedorC;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrega;
    }
}