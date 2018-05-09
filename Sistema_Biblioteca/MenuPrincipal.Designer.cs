namespace Sistema_Biblioteca
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pTitulo = new System.Windows.Forms.Panel();
            this.pLogin = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pSesion = new System.Windows.Forms.Panel();
            this.lblUserActivo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.toolTipPrestamo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLibros = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMembresias = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipComputadoras = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSalas = new System.Windows.Forms.ToolTip(this.components);
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.pVentanas = new System.Windows.Forms.Panel();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrestamos = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSalas = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnComputadoras = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMembresias = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLibros = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnface = new Bunifu.Framework.UI.BunifuImageButton();
            this.btntt = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnIn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuImageButton();
            this.pTitulo.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.pSesion.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComputadoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMembresias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.pTitulo.Controls.Add(this.panel2);
            this.pTitulo.Controls.Add(this.btnSalir);
            this.pTitulo.Controls.Add(this.pLogin);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(1034, 37);
            this.pTitulo.TabIndex = 0;
            // 
            // pLogin
            // 
            this.pLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLogin.Controls.Add(this.txtUser);
            this.pLogin.Controls.Add(this.txtClave);
            this.pLogin.Controls.Add(this.lblClave);
            this.pLogin.Controls.Add(this.lblUser);
            this.pLogin.Controls.Add(this.btnLogout);
            this.pLogin.Enabled = false;
            this.pLogin.Location = new System.Drawing.Point(527, 3);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(464, 30);
            this.pLogin.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(61)))));
            this.txtUser.Location = new System.Drawing.Point(62, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(131, 22);
            this.txtUser.TabIndex = 1;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(61)))));
            this.txtClave.Location = new System.Drawing.Point(279, 2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(150, 22);
            this.txtClave.TabIndex = 2;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(61)))));
            this.lblClave.Location = new System.Drawing.Point(234, 5);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(39, 16);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(61)))));
            this.lblUser.Location = new System.Drawing.Point(5, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 16);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuario";
            // 
            // pSesion
            // 
            this.pSesion.Controls.Add(this.btnface);
            this.pSesion.Controls.Add(this.lblUserActivo);
            this.pSesion.Controls.Add(this.btntt);
            this.pSesion.Controls.Add(this.lblFecha);
            this.pSesion.Controls.Add(this.btnIn);
            this.pSesion.Controls.Add(this.lblF);
            this.pSesion.Controls.Add(this.lblUs);
            this.pSesion.Controls.Add(this.lblHora);
            this.pSesion.Controls.Add(this.lblH);
            this.pSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSesion.Location = new System.Drawing.Point(0, 503);
            this.pSesion.Name = "pSesion";
            this.pSesion.Size = new System.Drawing.Size(1034, 32);
            this.pSesion.TabIndex = 1;
            // 
            // lblUserActivo
            // 
            this.lblUserActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserActivo.AutoSize = true;
            this.lblUserActivo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.lblUserActivo.Location = new System.Drawing.Point(106, 9);
            this.lblUserActivo.Name = "lblUserActivo";
            this.lblUserActivo.Size = new System.Drawing.Size(11, 14);
            this.lblUserActivo.TabIndex = 5;
            this.lblUserActivo.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.lblFecha.Location = new System.Drawing.Point(357, 8);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(11, 14);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "-";
            // 
            // lblF
            // 
            this.lblF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.lblF.Location = new System.Drawing.Point(308, 8);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(43, 14);
            this.lblF.TabIndex = 3;
            this.lblF.Text = "Fecha:";
            // 
            // lblUs
            // 
            this.lblUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.lblUs.Location = new System.Drawing.Point(12, 9);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(88, 14);
            this.lblUs.TabIndex = 2;
            this.lblUs.Text = "Usuario Activo:";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.lblHora.Location = new System.Drawing.Point(497, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(11, 14);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "-";
            // 
            // lblH
            // 
            this.lblH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.lblH.Location = new System.Drawing.Point(458, 9);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(36, 14);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "Hora:";
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btnEmpleados);
            this.pMenu.Controls.Add(this.btnPrestamos);
            this.pMenu.Controls.Add(this.btnSalas);
            this.pMenu.Controls.Add(this.btnComputadoras);
            this.pMenu.Controls.Add(this.btnMembresias);
            this.pMenu.Controls.Add(this.btnLibros);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenu.Location = new System.Drawing.Point(0, 403);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1034, 100);
            this.pMenu.TabIndex = 2;
            this.pMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pMenu_Paint);
            // 
            // Tiempo
            // 
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pPrincipal.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.Bienvenido;
            this.pPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pPrincipal.Controls.Add(this.pVentanas);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 37);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1034, 366);
            this.pPrincipal.TabIndex = 3;
            this.pPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pPrincipal_Paint);
            // 
            // pVentanas
            // 
            this.pVentanas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pVentanas.Location = new System.Drawing.Point(341, 22);
            this.pVentanas.Name = "pVentanas";
            this.pVentanas.Size = new System.Drawing.Size(340, 300);
            this.pVentanas.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Image = global::Sistema_Biblioteca.Properties.Resources.users_clients_group_16774;
            this.btnEmpleados.ImageActive = null;
            this.btnEmpleados.Location = new System.Drawing.Point(32, 6);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(85, 85);
            this.btnEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.TabStop = false;
            this.btnEmpleados.Zoom = 10;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.btnPrestamos.Image = global::Sistema_Biblioteca.Properties.Resources.page_document_empty_16752;
            this.btnPrestamos.ImageActive = null;
            this.btnPrestamos.Location = new System.Drawing.Point(187, 6);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(85, 85);
            this.btnPrestamos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrestamos.TabIndex = 4;
            this.btnPrestamos.TabStop = false;
            this.btnPrestamos.Zoom = 10;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalas.BackColor = System.Drawing.Color.Transparent;
            this.btnSalas.Image = global::Sistema_Biblioteca.Properties.Resources.events_rooms;
            this.btnSalas.ImageActive = null;
            this.btnSalas.Location = new System.Drawing.Point(906, 6);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(85, 85);
            this.btnSalas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalas.TabIndex = 3;
            this.btnSalas.TabStop = false;
            this.btnSalas.Zoom = 10;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnComputadoras
            // 
            this.btnComputadoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComputadoras.BackColor = System.Drawing.Color.Transparent;
            this.btnComputadoras.Image = global::Sistema_Biblioteca.Properties.Resources.computer_pc_10894;
            this.btnComputadoras.ImageActive = null;
            this.btnComputadoras.Location = new System.Drawing.Point(736, 6);
            this.btnComputadoras.Name = "btnComputadoras";
            this.btnComputadoras.Size = new System.Drawing.Size(85, 85);
            this.btnComputadoras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnComputadoras.TabIndex = 2;
            this.btnComputadoras.TabStop = false;
            this.btnComputadoras.Zoom = 10;
            this.btnComputadoras.Click += new System.EventHandler(this.btnComputadoras_Click);
            // 
            // btnMembresias
            // 
            this.btnMembresias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMembresias.BackColor = System.Drawing.Color.Transparent;
            this.btnMembresias.Image = global::Sistema_Biblioteca.Properties.Resources.tag_user_card_16777;
            this.btnMembresias.ImageActive = null;
            this.btnMembresias.Location = new System.Drawing.Point(558, 6);
            this.btnMembresias.Name = "btnMembresias";
            this.btnMembresias.Size = new System.Drawing.Size(85, 85);
            this.btnMembresias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMembresias.TabIndex = 1;
            this.btnMembresias.TabStop = false;
            this.btnMembresias.Zoom = 10;
            this.btnMembresias.Click += new System.EventHandler(this.btnMembresias_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLibros.BackColor = System.Drawing.Color.Transparent;
            this.btnLibros.Image = global::Sistema_Biblioteca.Properties.Resources.mimetypes_addressbookoffice_384;
            this.btnLibros.ImageActive = null;
            this.btnLibros.Location = new System.Drawing.Point(371, 6);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(85, 85);
            this.btnLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLibros.TabIndex = 0;
            this.btnLibros.TabStop = false;
            this.btnLibros.Zoom = 10;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnface
            // 
            this.btnface.BackColor = System.Drawing.Color.Transparent;
            this.btnface.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnface.Image = global::Sistema_Biblioteca.Properties.Resources.Facebook_Icono;
            this.btnface.ImageActive = null;
            this.btnface.Location = new System.Drawing.Point(944, 0);
            this.btnface.Name = "btnface";
            this.btnface.Size = new System.Drawing.Size(30, 32);
            this.btnface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnface.TabIndex = 3;
            this.btnface.TabStop = false;
            this.btnface.Zoom = 10;
            // 
            // btntt
            // 
            this.btntt.BackColor = System.Drawing.Color.Transparent;
            this.btntt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btntt.Image = global::Sistema_Biblioteca.Properties.Resources.twitter;
            this.btntt.ImageActive = null;
            this.btntt.Location = new System.Drawing.Point(974, 0);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(30, 32);
            this.btntt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btntt.TabIndex = 2;
            this.btntt.TabStop = false;
            this.btntt.Zoom = 10;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Transparent;
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIn.Image = global::Sistema_Biblioteca.Properties.Resources.Instagram_grey;
            this.btnIn.ImageActive = null;
            this.btnIn.Location = new System.Drawing.Point(1004, 0);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(30, 32);
            this.btnIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIn.TabIndex = 1;
            this.btnIn.TabStop = false;
            this.btnIn.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.BibliotecaManagerTitlw;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 29);
            this.panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.shutdown_off_close_exit_15253;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(999, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 37);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Image = global::Sistema_Biblioteca.Properties.Resources.off_downnearexit_apagado_abajo_6017;
            this.btnLogout.ImageActive = null;
            this.btnLogout.Location = new System.Drawing.Point(438, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(22, 26);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 1;
            this.btnLogout.TabStop = false;
            this.btnLogout.Zoom = 10;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1034, 535);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pSesion);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pTitulo.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pSesion.ResumeLayout(false);
            this.pSesion.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComputadoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMembresias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Panel pSesion;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pPrincipal;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private Bunifu.Framework.UI.BunifuImageButton btnComputadoras;
        private Bunifu.Framework.UI.BunifuImageButton btnMembresias;
        private Bunifu.Framework.UI.BunifuImageButton btnLibros;
        private Bunifu.Framework.UI.BunifuImageButton btnPrestamos;
        private Bunifu.Framework.UI.BunifuImageButton btnSalas;
        private Bunifu.Framework.UI.BunifuImageButton btnLogout;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblUserActivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblH;
        private Bunifu.Framework.UI.BunifuImageButton btnface;
        private Bunifu.Framework.UI.BunifuImageButton btntt;
        private Bunifu.Framework.UI.BunifuImageButton btnIn;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pVentanas;
        private System.Windows.Forms.ToolTip toolTipPrestamo;
        private System.Windows.Forms.ToolTip toolTipLibros;
        private System.Windows.Forms.ToolTip toolTipMembresias;
        private System.Windows.Forms.ToolTip toolTipComputadoras;
        private System.Windows.Forms.ToolTip toolTipSalas;
        private Bunifu.Framework.UI.BunifuImageButton btnEmpleados;
    }
}