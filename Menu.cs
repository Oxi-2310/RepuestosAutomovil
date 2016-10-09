using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repuestos_Automotriz
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void proveedorYClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorCliente pro = new ProveedorCliente();
            pro.Show();
        }

        private void repuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repuestos re = new Repuestos();
            re.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
