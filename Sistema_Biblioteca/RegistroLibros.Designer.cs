namespace Sistema_Biblioteca
{
    partial class RegistroLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroLibros));
            this.pTitulo = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pContent = new System.Windows.Forms.Panel();
            this.txtPerfilCodigo = new System.Windows.Forms.TextBox();
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnAgregarLibro = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbAutor = new System.Windows.Forms.GroupBox();
            this.btnBuscarAutor = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarAutor = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.toolTipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBusqueda = new System.Windows.Forms.ToolTip(this.components);
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.pContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            this.gbAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTitulo.Controls.Add(this.lblRegistro);
            this.pTitulo.Controls.Add(this.btnSalir);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(656, 37);
            this.pTitulo.TabIndex = 101;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblRegistro.Location = new System.Drawing.Point(244, 7);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(133, 23);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Registro Libros";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(622, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pContent
            // 
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContent.Controls.Add(this.txtPerfilCodigo);
            this.pContent.Controls.Add(this.pbLibro);
            this.pContent.Controls.Add(this.dtpFecha);
            this.pContent.Controls.Add(this.lblFecha);
            this.pContent.Controls.Add(this.label10);
            this.pContent.Controls.Add(this.label9);
            this.pContent.Controls.Add(this.txtCodigo);
            this.pContent.Controls.Add(this.lblPerfil);
            this.pContent.Controls.Add(this.btnAgregarLibro);
            this.pContent.Controls.Add(this.label3);
            this.pContent.Controls.Add(this.txtEditorial);
            this.pContent.Controls.Add(this.gbAutor);
            this.pContent.Controls.Add(this.label5);
            this.pContent.Controls.Add(this.label7);
            this.pContent.Controls.Add(this.txtTitulo);
            this.pContent.Controls.Add(this.txtProveedor);
            this.pContent.Controls.Add(this.label8);
            this.pContent.Controls.Add(this.txtCantidad);
            this.pContent.Controls.Add(this.label21);
            this.pContent.Controls.Add(this.txtAño);
            this.pContent.Controls.Add(this.label19);
            this.pContent.Controls.Add(this.txtIsbn);
            this.pContent.Controls.Add(this.txtEdicion);
            this.pContent.Controls.Add(this.label15);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 37);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(656, 355);
            this.pContent.TabIndex = 102;
            this.pContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pContent_Paint);
            // 
            // txtPerfilCodigo
            // 
            this.txtPerfilCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPerfilCodigo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfilCodigo.Location = new System.Drawing.Point(86, 19);
            this.txtPerfilCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerfilCodigo.Name = "txtPerfilCodigo";
            this.txtPerfilCodigo.Size = new System.Drawing.Size(159, 26);
            this.txtPerfilCodigo.TabIndex = 125;
            // 
            // pbLibro
            // 
            this.pbLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLibro.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.add_book;
            this.pbLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLibro.Location = new System.Drawing.Point(487, 10);
            this.pbLibro.Name = "pbLibro";
            this.pbLibro.Size = new System.Drawing.Size(155, 168);
            this.pbLibro.TabIndex = 124;
            this.pbLibro.TabStop = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(93, 145);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(86, 26);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(28, 148);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 18);
            this.lblFecha.TabIndex = 123;
            this.lblFecha.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 18);
            this.label10.TabIndex = 122;
            this.label10.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 121;
            this.label9.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(365, 19);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(49, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(28, 22);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(38, 18);
            this.lblPerfil.TabIndex = 120;
            this.lblPerfil.Text = "Perfil";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 119;
            this.label3.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEditorial.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(88, 99);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(186, 26);
            this.txtEditorial.TabIndex = 3;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.ActiveBorderThickness = 1;
            this.btnAgregarLibro.ActiveCornerRadius = 20;
            this.btnAgregarLibro.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarLibro.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarLibro.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarLibro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarLibro.BackgroundImage")));
            this.btnAgregarLibro.ButtonText = "Agregar";
            this.btnAgregarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarLibro.IdleBorderThickness = 1;
            this.btnAgregarLibro.IdleCornerRadius = 25;
            this.btnAgregarLibro.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarLibro.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarLibro.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarLibro.Location = new System.Drawing.Point(525, 314);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(100, 39);
            this.btnAgregarLibro.TabIndex = 112;
            this.btnAgregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // gbAutor
            // 
            this.gbAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbAutor.Controls.Add(this.btnBuscarAutor);
            this.gbAutor.Controls.Add(this.btnAgregarAutor);
            this.gbAutor.Controls.Add(this.txtPerfil);
            this.gbAutor.Controls.Add(this.txtArea);
            this.gbAutor.Controls.Add(this.txtNombre);
            this.gbAutor.Controls.Add(this.label4);
            this.gbAutor.Controls.Add(this.label14);
            this.gbAutor.Controls.Add(this.label6);
            this.gbAutor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAutor.Location = new System.Drawing.Point(27, 177);
            this.gbAutor.Name = "gbAutor";
            this.gbAutor.Size = new System.Drawing.Size(598, 108);
            this.gbAutor.TabIndex = 109;
            this.gbAutor.TabStop = false;
            this.gbAutor.Text = "Autor";
            this.gbAutor.Enter += new System.EventHandler(this.gbAutor_Enter);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAutor.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarAutor.ImageActive = null;
            this.btnBuscarAutor.Location = new System.Drawing.Point(479, 16);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarAutor.TabIndex = 69;
            this.btnBuscarAutor.TabStop = false;
            this.btnBuscarAutor.Zoom = 10;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAutor.Image = global::Sistema_Biblioteca.Properties.Resources.add_insert_plus_1588;
            this.btnAgregarAutor.ImageActive = null;
            this.btnAgregarAutor.Location = new System.Drawing.Point(543, 16);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(35, 35);
            this.btnAgregarAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarAutor.TabIndex = 68;
            this.btnAgregarAutor.TabStop = false;
            this.btnAgregarAutor.Zoom = 10;
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click);
            // 
            // txtPerfil
            // 
            this.txtPerfil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.Location = new System.Drawing.Point(307, 69);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(155, 26);
            this.txtPerfil.TabIndex = 3;
            this.txtPerfil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerfil_KeyPress);
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(85, 66);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(155, 26);
            this.txtArea.TabIndex = 2;
            this.txtArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(85, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(377, 26);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 18);
            this.label14.TabIndex = 36;
            this.label14.Text = "Área";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Perfil";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 118;
            this.label5.Text = "Titulo";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 117;
            this.label7.Text = "Proveedor";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(86, 59);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(396, 26);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(102, 302);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(209, 26);
            this.txtProveedor.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 116;
            this.label8.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(401, 145);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(64, 26);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(201, 148);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 18);
            this.label21.TabIndex = 115;
            this.label21.Text = "Año";
            // 
            // txtAño
            // 
            this.txtAño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAño.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(238, 145);
            this.txtAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(75, 26);
            this.txtAño.TabIndex = 6;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(330, 305);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 18);
            this.label19.TabIndex = 114;
            this.label19.Text = "ISBN";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIsbn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(375, 302);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(103, 26);
            this.txtIsbn.TabIndex = 9;
            this.txtIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsbn_KeyPress);
            // 
            // txtEdicion
            // 
            this.txtEdicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdicion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicion.Location = new System.Drawing.Point(362, 99);
            this.txtEdicion.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(120, 26);
            this.txtEdicion.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(306, 102);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 18);
            this.label15.TabIndex = 113;
            this.label15.Text = "Edicion";
            // 
            // RegistroLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(656, 392);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroLibros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            this.gbAutor.ResumeLayout(false);
            this.gbAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label lblRegistro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.PictureBox pbLibro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditorial;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarLibro;
        private System.Windows.Forms.GroupBox gbAutor;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarAutor;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarAutor;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolTip toolTipAgregar;
        private System.Windows.Forms.ToolTip toolTipBusqueda;
        private System.Windows.Forms.TextBox txtPerfilCodigo;
    }
}