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

        private void contratosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteContrato frm = new frmReporteContrato(0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmEquipos equipos = new frmEquipos();
            equipos.MdiParent = this;
            equipos.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmContratos alquileres = new frmContratos();
            alquileres.MdiParent = this;
            alquileres.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmReporteContrato frm = new frmReporteContrato(0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
