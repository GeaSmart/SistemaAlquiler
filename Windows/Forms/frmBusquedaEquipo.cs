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
    public partial class frmBusquedaEquipo : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int Id { get; set; }

        ApplicationDBContext context = new ApplicationDBContext();
        public frmBusquedaEquipo()
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
                var x = this.dgvData.SelectedRows[0].Cells["id"].Value.ToString();
                this.Id = Convert.ToInt32(x);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
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
            var listado = context.Equipos.Where(
                x => x.Codigo.Contains(this.txtBusqueda.Text) ||
                    x.Descripcion.Contains(this.txtBusqueda.Text)
            ).ToList();
            this.dgvData.DataSource = listado;
            this.txtBusqueda.Select();
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
    }
}
