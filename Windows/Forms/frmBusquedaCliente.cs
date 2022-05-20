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
    public partial class frmBusquedaCliente : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int Id { get; set; }

        ApplicationDBContext context = new ApplicationDBContext();
        public frmBusquedaCliente()
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

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvData.CurrentRow.Cells["id"].Value);
            btnOk.PerformClick();
        }

        private void Busqueda()
        {
            var listado = context.Clientes.Where(
                x => x.NombreCompleto.Contains(this.txtBusqueda.Text) ||                    
                    x.Documento.Contains(this.txtBusqueda.Text)
            ).ToList();
            this.dgvData.DataSource = listado;
            this.txtBusqueda.Select();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (this.dgvData.RowCount > 0)
            {
                var x = this.dgvData.SelectedRows[0].Cells["id"].Value.ToString();
                this.Id = Convert.ToInt32(x);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.dgvData.RowCount > 0)
            {
                int nRow = this.dgvData.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Down)
                {
                    if (nRow < this.dgvData.RowCount - 1)
                    {
                        this.dgvData.Rows[nRow].Selected = false;
                        this.dgvData.Rows[++nRow].Selected = true;
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (nRow > 0)
                    {
                        this.dgvData.Rows[nRow].Selected = false;
                        this.dgvData.Rows[--nRow].Selected = true;
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    this.btnOk.PerformClick();
                }
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txtBusqueda.Text.Length > 0 && this.dgvData.RowCount > 0)
            {
                this.txtBusqueda.Select();
                this.txtBusqueda.SelectionStart = this.txtBusqueda.Text.Length;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
