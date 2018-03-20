namespace Sistema_Biblioteca
{
    partial class ModificarMembresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarMembresia));
            this.pContent = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificarMem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioM = new System.Windows.Forms.TextBox();
            this.pbPago = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTipoMm = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarMiembro = new Bunifu.Framework.UI.BunifuImageButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOcupacionM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pbModificarM = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdMas = new System.Windows.Forms.RadioButton();
            this.rdFem = new System.Windows.Forms.RadioButton();
            this.txtEmailM = new System.Windows.Forms.TextBox();
            this.txtDireccionM = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPago)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMiembro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarM)).BeginInit();
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContent.Controls.Add(this.txtID);
            this.pContent.Controls.Add(this.lblID);
            this.pContent.Controls.Add(this.label8);
            this.pContent.Controls.Add(this.btnModificarMem);
            this.pContent.Controls.Add(this.groupBox1);
            this.pContent.Controls.Add(this.groupBox2);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 37);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(656, 355);
            this.pContent.TabIndex = 105;
            this.pContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pContent_Paint);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(145, 304);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(78, 26);
            this.txtID.TabIndex = 75;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(145, 307);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 18);
            this.lblID.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 307);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 115;
            this.label8.Text = "ID Miembro: ";
            // 
            // btnModificarMem
            // 
            this.btnModificarMem.ActiveBorderThickness = 1;
            this.btnModificarMem.ActiveCornerRadius = 20;
            this.btnModificarMem.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnModificarMem.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarMem.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnModificarMem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarMem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarMem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarMem.BackgroundImage")));
            this.btnModificarMem.ButtonText = "Modificar";
            this.btnModificarMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarMem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarMem.IdleBorderThickness = 1;
            this.btnModificarMem.IdleCornerRadius = 25;
            this.btnModificarMem.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarMem.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnModificarMem.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnModificarMem.Location = new System.Drawing.Point(536, 307);
            this.btnModificarMem.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarMem.Name = "btnModificarMem";
            this.btnModificarMem.Size = new System.Drawing.Size(104, 39);
            this.btnModificarMem.TabIndex = 113;
            this.btnModificarMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarMem.Click += new System.EventHandler(this.btnModificarMem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEstatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPrecioM);
            this.groupBox1.Controls.Add(this.pbPago);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtTipoMm);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 235);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(634, 65);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Membresia";
            // 
            // cbxEstatus
            // 
            this.cbxEstatus.FormattingEnabled = true;
            this.cbxEstatus.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbxEstatus.Location = new System.Drawing.Point(478, 28);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(92, 26);
            this.cbxEstatus.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 73;
            this.label6.Text = "Estatus";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(590, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 35);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(263, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = "Precio";
            // 
            // txtPrecioM
            // 
            this.txtPrecioM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioM.Location = new System.Drawing.Point(313, 28);
            this.txtPrecioM.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioM.Name = "txtPrecioM";
            this.txtPrecioM.Size = new System.Drawing.Size(88, 26);
            this.txtPrecioM.TabIndex = 38;
            this.txtPrecioM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioM_KeyPress);
            // 
            // pbPago
            // 
            this.pbPago.Image = global::Sistema_Biblioteca.Properties.Resources.dollar_money_17872;
            this.pbPago.Location = new System.Drawing.Point(4, 21);
            this.pbPago.Margin = new System.Windows.Forms.Padding(2);
            this.pbPago.Name = "pbPago";
            this.pbPago.Size = new System.Drawing.Size(40, 40);
            this.pbPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPago.TabIndex = 33;
            this.pbPago.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 18);
            this.label17.TabIndex = 28;
            this.label17.Text = "Tipo";
            // 
            // txtTipoMm
            // 
            this.txtTipoMm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoMm.Location = new System.Drawing.Point(88, 28);
            this.txtTipoMm.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoMm.Name = "txtTipoMm";
            this.txtTipoMm.Size = new System.Drawing.Size(159, 26);
            this.txtTipoMm.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarMiembro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtOcupacionM);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.pbModificarM);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTelefonoM);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtApellidoM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdMas);
            this.groupBox2.Controls.Add(this.rdFem);
            this.groupBox2.Controls.Add(this.txtEmailM);
            this.groupBox2.Controls.Add(this.txtDireccionM);
            this.groupBox2.Controls.Add(this.txtNombreM);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(634, 218);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del nuevo miembro";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnBuscarMiembro
            // 
            this.btnBuscarMiembro.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMiembro.Image = global::Sistema_Biblioteca.Properties.Resources.Search_find_locate_15421;
            this.btnBuscarMiembro.ImageActive = null;
            this.btnBuscarMiembro.Location = new System.Drawing.Point(422, 37);
            this.btnBuscarMiembro.Name = "btnBuscarMiembro";
            this.btnBuscarMiembro.Size = new System.Drawing.Size(59, 52);
            this.btnBuscarMiembro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarMiembro.TabIndex = 72;
            this.btnBuscarMiembro.TabStop = false;
            this.btnBuscarMiembro.Zoom = 10;
            this.btnBuscarMiembro.Click += new System.EventHandler(this.btnBuscarMiembro_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(445, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 18);
            this.label10.TabIndex = 128;
            this.label10.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(83, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 126;
            this.label1.Text = "*";
            // 
            // txtOcupacionM
            // 
            this.txtOcupacionM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacionM.Location = new System.Drawing.Point(99, 179);
            this.txtOcupacionM.Margin = new System.Windows.Forms.Padding(2);
            this.txtOcupacionM.Name = "txtOcupacionM";
            this.txtOcupacionM.Size = new System.Drawing.Size(274, 26);
            this.txtOcupacionM.TabIndex = 4;
            this.txtOcupacionM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOcupacionM_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 182);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 18);
            this.label15.TabIndex = 39;
            this.label15.Text = "Ocupacion";
            // 
            // pbModificarM
            // 
            this.pbModificarM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbModificarM.BackgroundImage = global::Sistema_Biblioteca.Properties.Resources.configura_info_user_16714;
            this.pbModificarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbModificarM.Location = new System.Drawing.Point(492, 4);
            this.pbModificarM.Name = "pbModificarM";
            this.pbModificarM.Size = new System.Drawing.Size(137, 139);
            this.pbModificarM.TabIndex = 125;
            this.pbModificarM.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Teléfono";
            // 
            // txtTelefonoM
            // 
            this.txtTelefonoM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoM.Location = new System.Drawing.Point(465, 179);
            this.txtTelefonoM.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoM.MaxLength = 10;
            this.txtTelefonoM.Name = "txtTelefonoM";
            this.txtTelefonoM.Size = new System.Drawing.Size(144, 26);
            this.txtTelefonoM.TabIndex = 5;
            this.txtTelefonoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoM_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(70, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 18);
            this.label13.TabIndex = 37;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 36;
            this.label14.Text = "Apellidos";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoM.Location = new System.Drawing.Point(99, 68);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(314, 26);
            this.txtApellidoM.TabIndex = 1;
            this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoM_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(66, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            // 
            // rdMas
            // 
            this.rdMas.AutoSize = true;
            this.rdMas.BackColor = System.Drawing.Color.Transparent;
            this.rdMas.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMas.Location = new System.Drawing.Point(511, 148);
            this.rdMas.Margin = new System.Windows.Forms.Padding(2);
            this.rdMas.Name = "rdMas";
            this.rdMas.Size = new System.Drawing.Size(38, 22);
            this.rdMas.TabIndex = 6;
            this.rdMas.Text = "M";
            this.rdMas.UseVisualStyleBackColor = false;
            this.rdMas.CheckedChanged += new System.EventHandler(this.rdMas_CheckedChanged);
            // 
            // rdFem
            // 
            this.rdFem.AutoSize = true;
            this.rdFem.BackColor = System.Drawing.Color.Transparent;
            this.rdFem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdFem.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rdFem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFem.Location = new System.Drawing.Point(464, 148);
            this.rdFem.Margin = new System.Windows.Forms.Padding(2);
            this.rdFem.Name = "rdFem";
            this.rdFem.Size = new System.Drawing.Size(34, 22);
            this.rdFem.TabIndex = 5;
            this.rdFem.Text = "F";
            this.rdFem.UseVisualStyleBackColor = false;
            this.rdFem.CheckedChanged += new System.EventHandler(this.rdFem_CheckedChanged);
            // 
            // txtEmailM
            // 
            this.txtEmailM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailM.Location = new System.Drawing.Point(99, 142);
            this.txtEmailM.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailM.Name = "txtEmailM";
            this.txtEmailM.Size = new System.Drawing.Size(299, 26);
            this.txtEmailM.TabIndex = 3;
            // 
            // txtDireccionM
            // 
            this.txtDireccionM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionM.Location = new System.Drawing.Point(99, 105);
            this.txtDireccionM.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionM.Name = "txtDireccionM";
            this.txtDireccionM.Size = new System.Drawing.Size(369, 26);
            this.txtDireccionM.TabIndex = 2;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreM.Location = new System.Drawing.Point(99, 31);
            this.txtNombreM.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(314, 26);
            this.txtNombreM.TabIndex = 0;
            this.txtNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreM_KeyPress);
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
            this.pTitulo.TabIndex = 104;
            this.pTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pTitulo_Paint);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblRegistro.Location = new System.Drawing.Point(244, 7);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(191, 23);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Modificar Membresias";
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
            // ModificarMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(656, 392);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarMembresia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPago)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMiembro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarM)).EndInit();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificarMem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioM;
        private System.Windows.Forms.PictureBox pbPago;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTipoMm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOcupacionM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbModificarM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdMas;
        private System.Windows.Forms.RadioButton rdFem;
        private System.Windows.Forms.TextBox txtEmailM;
        private System.Windows.Forms.TextBox txtDireccionM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label lblRegistro;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarMiembro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEstatus;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtID;
    }
}