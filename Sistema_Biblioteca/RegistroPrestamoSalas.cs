using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Biblioteca
{
    public partial class RegistroPrestamoSalas : Form
    {
        public RegistroPrestamoSalas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbLibro_Click(object sender, EventArgs e)
        {
            ConsultaSalas CS = new ConsultaSalas();
            CS.TopLevel = false;
            CS.Parent = pContent;
            CS.Show();
        }
    }
}
