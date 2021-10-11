using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Model;

namespace Windows.Forms
{
    public partial class frmBusqueda : Form
    {
        public int Id { get; set; }

        ApplicationDBContext context = new ApplicationDBContext();
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.dgvData.RowCount > 0)
            {
                var x = this.dgvData.CurrentRow.Cells["id"].Value.ToString();
                this.Id = Convert.ToInt32(x);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvData.CurrentRow.Cells["id"].Value);
            btnOk.PerformClick();
        }

        private void Busqueda()
        {
            var listado = context.Clientes.Where(
                x => x.Apellidos.Contains(this.txtBusqueda.Text) ||
                    x.Nombres.Contains(this.txtBusqueda.Text) ||
                    x.Documento.Contains(this.txtBusqueda.Text) ||
                    x.RazonSocial.Contains(this.txtBusqueda.Text)
            ).ToList();
            this.dgvData.DataSource = listado;
        }
    }
}
