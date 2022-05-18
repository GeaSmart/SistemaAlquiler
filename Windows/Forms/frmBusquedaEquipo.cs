﻿using System;
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
            var listado = context.Equipos.Where(
                x => x.Codigo.Contains(this.txtBusqueda.Text) ||
                    x.Descripcion.Contains(this.txtBusqueda.Text)
            ).ToList();
            this.dgvData.DataSource = listado;
        }
    }
}
