namespace Sistema_Biblioteca
{
    partial class FrmPrincipalcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalcs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moidificarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMiembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMiembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoDeMembresiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.consultaDeLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 73);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biblioteca Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Biblioteca.Properties.Resources.book_3725;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.membresiasToolStripMenuItem,
            this.salasToolStripMenuItem,
            this.computadorasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarLibroToolStripMenuItem,
            this.moidificarLibroToolStripMenuItem,
            this.modificarLibroToolStripMenuItem,
            this.consultaDeLibroToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // registrarLibroToolStripMenuItem
            // 
            this.registrarLibroToolStripMenuItem.Name = "registrarLibroToolStripMenuItem";
            this.registrarLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.registrarLibroToolStripMenuItem.Text = "Prestamo";
            // 
            // moidificarLibroToolStripMenuItem
            // 
            this.moidificarLibroToolStripMenuItem.Name = "moidificarLibroToolStripMenuItem";
            this.moidificarLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.moidificarLibroToolStripMenuItem.Text = "Registro Libro";
            this.moidificarLibroToolStripMenuItem.Click += new System.EventHandler(this.moidificarLibroToolStripMenuItem_Click);
            // 
            // modificarLibroToolStripMenuItem
            // 
            this.modificarLibroToolStripMenuItem.Name = "modificarLibroToolStripMenuItem";
            this.modificarLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modificarLibroToolStripMenuItem.Text = "Modificar Libro";
            this.modificarLibroToolStripMenuItem.Click += new System.EventHandler(this.modificarLibroToolStripMenuItem_Click);
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMiembroToolStripMenuItem,
            this.modificarMiembroToolStripMenuItem,
            this.agregarTipoDeMembresiaToolStripMenuItem});
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.membresiasToolStripMenuItem.Text = "Membresias";
            // 
            // agregarMiembroToolStripMenuItem
            // 
            this.agregarMiembroToolStripMenuItem.Name = "agregarMiembroToolStripMenuItem";
            this.agregarMiembroToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.agregarMiembroToolStripMenuItem.Text = "Agregar Miembro";
            this.agregarMiembroToolStripMenuItem.Click += new System.EventHandler(this.agregarMiembroToolStripMenuItem_Click);
            // 
            // modificarMiembroToolStripMenuItem
            // 
            this.modificarMiembroToolStripMenuItem.Name = "modificarMiembroToolStripMenuItem";
            this.modificarMiembroToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.modificarMiembroToolStripMenuItem.Text = "Modificar Miembro";
            this.modificarMiembroToolStripMenuItem.Click += new System.EventHandler(this.modificarMiembroToolStripMenuItem_Click);
            // 
            // agregarTipoDeMembresiaToolStripMenuItem
            // 
            this.agregarTipoDeMembresiaToolStripMenuItem.Name = "agregarTipoDeMembresiaToolStripMenuItem";
            this.agregarTipoDeMembresiaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.agregarTipoDeMembresiaToolStripMenuItem.Text = "Agregar Tipo de Membresia";
            this.agregarTipoDeMembresiaToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoDeMembresiaToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salasToolStripMenuItem.Text = "Salas";
            // 
            // computadorasToolStripMenuItem
            // 
            this.computadorasToolStripMenuItem.Name = "computadorasToolStripMenuItem";
            this.computadorasToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.computadorasToolStripMenuItem.Text = "Computadoras";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_Biblioteca.Properties.Resources.Google_Play_Books_icon_icons_com_75718__1_;
            this.pictureBox2.Location = new System.Drawing.Point(409, 183);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // consultaDeLibroToolStripMenuItem
            // 
            this.consultaDeLibroToolStripMenuItem.Name = "consultaDeLibroToolStripMenuItem";
            this.consultaDeLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.consultaDeLibroToolStripMenuItem.Text = "Consulta de Libro";
            this.consultaDeLibroToolStripMenuItem.Click += new System.EventHandler(this.consultaDeLibroToolStripMenuItem_Click);
            // 
            // FrmPrincipalcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 555);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipalcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bblioteca Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moidificarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMiembroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMiembroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computadorasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoDeMembresiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeLibroToolStripMenuItem;
    }
}