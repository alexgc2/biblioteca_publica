namespace Sistema_Biblioteca
{
    partial class ModificarLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarLibros));
            this.pContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarLibro = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbModificarL = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoM = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cmbPerfilCodigoM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditorialM = new System.Windows.Forms.TextBox();
            this.btnModificarLibro = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbAutor = new System.Windows.Forms.GroupBox();
            this.btnAgregarAutor = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBuscarAutorM = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtPerfilM = new System.Windows.Forms.TextBox();
            this.txtAreaM = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTituloM = new System.Windows.Forms.TextBox();
            this.txtProveedorM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadM = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAñoM = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIsbnM = new System.Windows.Forms.TextBox();
            this.txtEdicionM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBusqueda = new System.Windows.Forms.ToolTip(this.components);
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            this.pContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarL)).BeginInit();
            this.gbAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarAutorM)).BeginInit();
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContent.Controls.Add(this.cbxEstatus);
            this.pContent.Controls.Add(this.txtFecha);
            this.pContent.Controls.Add(this.label1);
            this.pContent.Controls.Add(this.btnBuscarLibro);
            this.pContent.Controls.Add(this.pbModificarL);
            this.pContent.Controls.Add(this.lblFecha);
            this.pContent.Controls.Add(this.label10);
            this.pContent.Controls.Add(this.label9);
            this.pContent.Controls.Add(this.txtCodigoM);
            this.pContent.Controls.Add(this.lblPerfil);
            this.pContent.Controls.Add(this.cmbPerfilCodigoM);
            this.pContent.Controls.Add(this.label3);
            this.pContent.Controls.Add(this.txtEditorialM);
            this.pContent.Controls.Add(this.btnModificarLibro);
            this.pContent.Controls.Add(this.gbAutor);
            this.pContent.Controls.Add(this.label5);
            this.pContent.Controls.Add(this.label7);
            this.pContent.Controls.Add(this.txtTituloM);
            this.pContent.Controls.Add(this.txtProveedorM);
            this.pContent.Controls.Add(this.label8);
            this.pContent.Controls.Add(this.txtCantidadM);
            this.pContent.Controls.Add(this.label21);
            this.pContent.Controls.Add(this.txtAñoM);
            this.pContent.Controls.Add(this.label19);
            this.pContent.Controls.Add(this.txtIsbnM);
            this.pContent.Controls.Add(this.txtEdicionM);
            this.pContent.Controls.Add(this.label15);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 37);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(656, 355);
            this.pContent.TabIndex = 104;
            this.pContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pContent_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 126;
            this.label1.Text = "Estatus";
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarLibro.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarLibro.ImageActive = null;
            this.btnBuscarLibro.Location = new System.Drawing.Point(417, 22);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(56, 46);
            this.btnBuscarLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarLibro.TabIndex = 70;
            this.btnBuscarLibro.TabStop = false;
            this.btnBuscarLibro.Zoom = 10;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // pbModificarL
            // 
            this.pbModificarL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbModificarL.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.configura_book;
            this.pbModificarL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbModificarL.Location = new System.Drawing.Point(487, 8);
            this.pbModificarL.Name = "pbModificarL";
            this.pbModificarL.Size = new System.Drawing.Size(155, 166);
            this.pbModificarL.TabIndex = 124;
            this.pbModificarL.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(11, 148);
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
            this.label10.Location = new System.Drawing.Point(303, 22);
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
            this.label9.Location = new System.Drawing.Point(247, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 121;
            this.label9.Text = "Codigo";
            // 
            // txtCodigoM
            // 
            this.txtCodigoM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoM.Location = new System.Drawing.Point(348, 19);
            this.txtCodigoM.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoM.Name = "txtCodigoM";
            this.txtCodigoM.ReadOnly = true;
            this.txtCodigoM.Size = new System.Drawing.Size(49, 26);
            this.txtCodigoM.TabIndex = 0;
            this.txtCodigoM.TextChanged += new System.EventHandler(this.txtCodigoM_TextChanged);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(11, 22);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(38, 18);
            this.lblPerfil.TabIndex = 120;
            this.lblPerfil.Text = "Perfil";
            // 
            // cmbPerfilCodigoM
            // 
            this.cmbPerfilCodigoM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPerfilCodigoM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfilCodigoM.FormattingEnabled = true;
            this.cmbPerfilCodigoM.Location = new System.Drawing.Point(69, 19);
            this.cmbPerfilCodigoM.Name = "cmbPerfilCodigoM";
            this.cmbPerfilCodigoM.Size = new System.Drawing.Size(148, 26);
            this.cmbPerfilCodigoM.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 119;
            this.label3.Text = "Editorial";
            // 
            // txtEditorialM
            // 
            this.txtEditorialM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEditorialM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorialM.Location = new System.Drawing.Point(71, 99);
            this.txtEditorialM.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditorialM.Name = "txtEditorialM";
            this.txtEditorialM.Size = new System.Drawing.Size(186, 26);
            this.txtEditorialM.TabIndex = 3;
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.ActiveBorderThickness = 1;
            this.btnModificarLibro.ActiveCornerRadius = 20;
            this.btnModificarLibro.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnModificarLibro.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarLibro.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnModificarLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarLibro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarLibro.BackgroundImage")));
            this.btnModificarLibro.ButtonText = "Modificar";
            this.btnModificarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarLibro.IdleBorderThickness = 1;
            this.btnModificarLibro.IdleCornerRadius = 25;
            this.btnModificarLibro.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarLibro.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnModificarLibro.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnModificarLibro.Location = new System.Drawing.Point(553, 293);
            this.btnModificarLibro.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(87, 39);
            this.btnModificarLibro.TabIndex = 112;
            this.btnModificarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
            // 
            // gbAutor
            // 
            this.gbAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbAutor.Controls.Add(this.btnAgregarAutor);
            this.gbAutor.Controls.Add(this.btnBuscarAutorM);
            this.gbAutor.Controls.Add(this.txtPerfilM);
            this.gbAutor.Controls.Add(this.txtAreaM);
            this.gbAutor.Controls.Add(this.txtNombreM);
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
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarAutor.Image = global::Sistema_Biblioteca.Properties.Resources.add_insert_plus_1588;
            this.btnAgregarAutor.ImageActive = null;
            this.btnAgregarAutor.Location = new System.Drawing.Point(557, 14);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(35, 35);
            this.btnAgregarAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarAutor.TabIndex = 70;
            this.btnAgregarAutor.TabStop = false;
            this.btnAgregarAutor.Zoom = 10;
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click);
            // 
            // btnBuscarAutorM
            // 
            this.btnBuscarAutorM.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAutorM.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarAutorM.ImageActive = null;
            this.btnBuscarAutorM.Location = new System.Drawing.Point(500, 14);
            this.btnBuscarAutorM.Name = "btnBuscarAutorM";
            this.btnBuscarAutorM.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarAutorM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarAutorM.TabIndex = 69;
            this.btnBuscarAutorM.TabStop = false;
            this.btnBuscarAutorM.Zoom = 10;
            // 
            // txtPerfilM
            // 
            this.txtPerfilM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfilM.Location = new System.Drawing.Point(390, 66);
            this.txtPerfilM.Name = "txtPerfilM";
            this.txtPerfilM.Size = new System.Drawing.Size(155, 26);
            this.txtPerfilM.TabIndex = 3;
            this.txtPerfilM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerfilM_KeyPress);
            // 
            // txtAreaM
            // 
            this.txtAreaM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaM.Location = new System.Drawing.Point(96, 66);
            this.txtAreaM.Name = "txtAreaM";
            this.txtAreaM.Size = new System.Drawing.Size(155, 26);
            this.txtAreaM.TabIndex = 2;
            this.txtAreaM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaM_KeyPress);
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreM.Location = new System.Drawing.Point(96, 23);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(377, 26);
            this.txtNombreM.TabIndex = 1;
            this.txtNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreM_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 26);
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
            this.label14.Location = new System.Drawing.Point(21, 69);
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
            this.label6.Location = new System.Drawing.Point(328, 69);
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
            this.label5.Location = new System.Drawing.Point(11, 62);
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
            this.label7.Location = new System.Drawing.Point(11, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 117;
            this.label7.Text = "Proveedor";
            // 
            // txtTituloM
            // 
            this.txtTituloM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTituloM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloM.Location = new System.Drawing.Point(69, 59);
            this.txtTituloM.Margin = new System.Windows.Forms.Padding(2);
            this.txtTituloM.Name = "txtTituloM";
            this.txtTituloM.Size = new System.Drawing.Size(328, 26);
            this.txtTituloM.TabIndex = 2;
            // 
            // txtProveedorM
            // 
            this.txtProveedorM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProveedorM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedorM.Location = new System.Drawing.Point(90, 300);
            this.txtProveedorM.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedorM.Name = "txtProveedorM";
            this.txtProveedorM.Size = new System.Drawing.Size(156, 26);
            this.txtProveedorM.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(316, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 116;
            this.label8.Text = "Cantidad";
            // 
            // txtCantidadM
            // 
            this.txtCantidadM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidadM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadM.Location = new System.Drawing.Point(384, 145);
            this.txtCantidadM.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadM.Name = "txtCantidadM";
            this.txtCantidadM.Size = new System.Drawing.Size(64, 26);
            this.txtCantidadM.TabIndex = 7;
            this.txtCantidadM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadM_KeyPress);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(184, 148);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 18);
            this.label21.TabIndex = 115;
            this.label21.Text = "Año";
            // 
            // txtAñoM
            // 
            this.txtAñoM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAñoM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAñoM.Location = new System.Drawing.Point(221, 145);
            this.txtAñoM.Margin = new System.Windows.Forms.Padding(2);
            this.txtAñoM.MaxLength = 4;
            this.txtAñoM.Name = "txtAñoM";
            this.txtAñoM.Size = new System.Drawing.Size(75, 26);
            this.txtAñoM.TabIndex = 6;
            this.txtAñoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAñoM_KeyPress);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(262, 303);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 18);
            this.label19.TabIndex = 114;
            this.label19.Text = "ISBN";
            // 
            // txtIsbnM
            // 
            this.txtIsbnM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIsbnM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbnM.Location = new System.Drawing.Point(307, 300);
            this.txtIsbnM.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbnM.Name = "txtIsbnM";
            this.txtIsbnM.Size = new System.Drawing.Size(56, 26);
            this.txtIsbnM.TabIndex = 9;
            this.txtIsbnM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsbnM_KeyPress);
            // 
            // txtEdicionM
            // 
            this.txtEdicionM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdicionM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicionM.Location = new System.Drawing.Point(345, 99);
            this.txtEdicionM.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdicionM.Name = "txtEdicionM";
            this.txtEdicionM.Size = new System.Drawing.Size(103, 26);
            this.txtEdicionM.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(289, 102);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 18);
            this.label15.TabIndex = 113;
            this.label15.Text = "Edicion";
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
            this.pTitulo.TabIndex = 103;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblRegistro.Location = new System.Drawing.Point(244, 7);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(141, 23);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Modificar Libros";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(69, 145);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(111, 26);
            this.txtFecha.TabIndex = 127;
            // 
            // cbxEstatus
            // 
            this.cbxEstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEstatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstatus.FormattingEnabled = true;
            this.cbxEstatus.Items.AddRange(new object[] {
            "ALTA",
            "BAJA"});
            this.cbxEstatus.Location = new System.Drawing.Point(464, 300);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(81, 26);
            this.cbxEstatus.TabIndex = 128;
            // 
            // ModificarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 392);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarLibros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarL)).EndInit();
            this.gbAutor.ResumeLayout(false);
            this.gbAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarAutorM)).EndInit();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.PictureBox pbModificarL;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cmbPerfilCodigoM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditorialM;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificarLibro;
        private System.Windows.Forms.GroupBox gbAutor;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarAutorM;
        private System.Windows.Forms.TextBox txtPerfilM;
        private System.Windows.Forms.TextBox txtAreaM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTituloM;
        private System.Windows.Forms.TextBox txtProveedorM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadM;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAñoM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIsbnM;
        private System.Windows.Forms.TextBox txtEdicionM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label lblRegistro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarLibro;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarAutor;
        private System.Windows.Forms.ToolTip toolTipAgregar;
        private System.Windows.Forms.ToolTip toolTipBusqueda;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cbxEstatus;
        public System.Windows.Forms.TextBox txtCodigoM;
    }
}