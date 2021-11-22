using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContratos alquileres = new frmContratos();
            alquileres.MdiParent = this;
            alquileres.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipos equipos = new frmEquipos();
            equipos.MdiParent = this;
            equipos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }
    }
}
