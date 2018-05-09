namespace Sistema_Biblioteca
{
    partial class RegistroEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEmpleado));
            this.pContente = new System.Windows.Forms.Panel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.ddSexo = new Bunifu.Framework.UI.BunifuDropdown();
            this.gbFN = new System.Windows.Forms.GroupBox();
            this.dtFechaNaci = new Bunifu.Framework.UI.BunifuDatepicker();
            this.pbMembresia = new System.Windows.Forms.PictureBox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAgregarMembresia = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pContente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbFN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMembresia)).BeginInit();
            this.SuspendLayout();
            // 
            // pContente
            // 
            this.pContente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pContente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContente.Controls.Add(this.btnSalir);
            this.pContente.Controls.Add(this.lblRegistro);
            this.pContente.Controls.Add(this.txtContraseña);
            this.pContente.Controls.Add(this.txtTelefono);
            this.pContente.Controls.Add(this.txtDireccion);
            this.pContente.Controls.Add(this.txtApellido);
            this.pContente.Controls.Add(this.gbSexo);
            this.pContente.Controls.Add(this.gbFN);
            this.pContente.Controls.Add(this.pbMembresia);
            this.pContente.Controls.Add(this.txtNombre);
            this.pContente.Controls.Add(this.btnAgregarMembresia);
            this.pContente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContente.Location = new System.Drawing.Point(0, 0);
            this.pContente.Name = "pContente";
            this.pContente.Size = new System.Drawing.Size(655, 515);
            this.pContente.TabIndex = 109;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::Sistema_Biblioteca.Properties.Resources.undoarrow_undo_1534;
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(620, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 159;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lblRegistro.Location = new System.Drawing.Point(171, 33);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(171, 23);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Registro Empeados";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.HintForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.HintText = "Contraseña";
            this.txtContraseña.isPassword = false;
            this.txtContraseña.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtContraseña.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtContraseña.LineThickness = 3;
            this.txtContraseña.Location = new System.Drawing.Point(27, 269);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(315, 31);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.HintForeColor = System.Drawing.Color.Gray;
            this.txtTelefono.HintText = "Telefono";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtTelefono.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtTelefono.LineThickness = 3;
            this.txtTelefono.Location = new System.Drawing.Point(33, 329);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(191, 31);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.HintForeColor = System.Drawing.Color.Gray;
            this.txtDireccion.HintText = "Direccion";
            this.txtDireccion.isPassword = false;
            this.txtDireccion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtDireccion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtDireccion.LineThickness = 3;
            this.txtDireccion.Location = new System.Drawing.Point(27, 202);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(431, 31);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.HintForeColor = System.Drawing.Color.Gray;
            this.txtApellido.HintText = "Apellidos";
            this.txtApellido.isPassword = false;
            this.txtApellido.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtApellido.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtApellido.LineThickness = 3;
            this.txtApellido.Location = new System.Drawing.Point(27, 140);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(431, 31);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.ddSexo);
            this.gbSexo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(287, 326);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(171, 62);
            this.gbSexo.TabIndex = 152;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // ddSexo
            // 
            this.ddSexo.BackColor = System.Drawing.Color.Transparent;
            this.ddSexo.BorderRadius = 3;
            this.ddSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddSexo.Items = new string[] {
        "Femenino",
        "Masculino"};
            this.ddSexo.Location = new System.Drawing.Point(6, 22);
            this.ddSexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddSexo.Name = "ddSexo";
            this.ddSexo.NomalColor = System.Drawing.Color.White;
            this.ddSexo.onHoverColor = System.Drawing.SystemColors.ControlLight;
            this.ddSexo.selectedIndex = 1;
            this.ddSexo.Size = new System.Drawing.Size(157, 31);
            this.ddSexo.TabIndex = 7;
            // 
            // gbFN
            // 
            this.gbFN.Controls.Add(this.dtFechaNaci);
            this.gbFN.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFN.Location = new System.Drawing.Point(27, 394);
            this.gbFN.Name = "gbFN";
            this.gbFN.Size = new System.Drawing.Size(219, 62);
            this.gbFN.TabIndex = 151;
            this.gbFN.TabStop = false;
            this.gbFN.Text = "Fecha de Nacimiento";
            // 
            // dtFechaNaci
            // 
            this.dtFechaNaci.BackColor = System.Drawing.Color.White;
            this.dtFechaNaci.BorderRadius = 0;
            this.dtFechaNaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtFechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFechaNaci.FormatCustom = null;
            this.dtFechaNaci.Location = new System.Drawing.Point(6, 20);
            this.dtFechaNaci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaNaci.Name = "dtFechaNaci";
            this.dtFechaNaci.Size = new System.Drawing.Size(207, 31);
            this.dtFechaNaci.TabIndex = 6;
            this.dtFechaNaci.Value = new System.DateTime(2018, 4, 22, 4, 34, 16, 910);
            // 
            // pbMembresia
            // 
            this.pbMembresia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbMembresia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMembresia.Image = global::Sistema_Biblioteca.Properties.Resources.new_add_user_16734;
            this.pbMembresia.Location = new System.Drawing.Point(485, 63);
            this.pbMembresia.Name = "pbMembresia";
            this.pbMembresia.Size = new System.Drawing.Size(140, 145);
            this.pbMembresia.TabIndex = 149;
            this.pbMembresia.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintForeColor = System.Drawing.Color.Gray;
            this.txtNombre.HintText = "Nombre";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(27, 86);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(431, 31);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnAgregarMembresia
            // 
            this.btnAgregarMembresia.ActiveBorderThickness = 1;
            this.btnAgregarMembresia.ActiveCornerRadius = 20;
            this.btnAgregarMembresia.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarMembresia.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMembresia.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarMembresia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarMembresia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMembresia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMembresia.BackgroundImage")));
            this.btnAgregarMembresia.ButtonText = "Agregar";
            this.btnAgregarMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMembresia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMembresia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarMembresia.IdleBorderThickness = 1;
            this.btnAgregarMembresia.IdleCornerRadius = 25;
            this.btnAgregarMembresia.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarMembresia.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarMembresia.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnAgregarMembresia.Location = new System.Drawing.Point(354, 417);
            this.btnAgregarMembresia.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarMembresia.Name = "btnAgregarMembresia";
            this.btnAgregarMembresia.Size = new System.Drawing.Size(104, 39);
            this.btnAgregarMembresia.TabIndex = 9;
            this.btnAgregarMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarMembresia.Click += new System.EventHandler(this.btnAgregarMembresia_Click);
            // 
            // RegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(655, 515);
            this.ControlBox = false;
            this.Controls.Add(this.pContente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroEmpleado";
            this.pContente.ResumeLayout(false);
            this.pContente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbFN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMembresia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContente;
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.Label lblRegistro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellido;
        private System.Windows.Forms.GroupBox gbSexo;
        private Bunifu.Framework.UI.BunifuDropdown ddSexo;
        private System.Windows.Forms.GroupBox gbFN;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaNaci;
        private System.Windows.Forms.PictureBox pbMembresia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarMembresia;
    }
}