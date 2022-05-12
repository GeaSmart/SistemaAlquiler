using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Entities;
using Windows.Model;

namespace Windows.Forms
{
    public partial class frmReporteContrato : Form
    {
        int _Id;
        public frmReporteContrato(int Id)
        {
            InitializeComponent();
            this._Id = Id;
        }

        private void frmReporteContrato_Load(object sender, EventArgs e)
        {
            cargaListadoReportes();
            if (_Id != 0)
                cargaReporteInicial();
        }

        private void cargaListadoReportes()
        {
            List<ContratoEntity> clientes = new List<ContratoEntity>();
            ResponseModel<List<ContratoEntity>> response = ContratoModel.Obtener();
            clientes = response.Data;

            this.cmbContratos.DataSource = clientes;
            this.cmbContratos.DisplayMember = "Id";
            this.cmbContratos.ValueMember = "Id";
        }

        private void cargaReporteInicial()
        {
            ReportDocument reporte = new ReportDocument();
            reporte.Load("Contrato.rpt");
            reporte.SetDatabaseLogon("sa", "EC1admin");
            reporte.SetParameterValue("@ContratoId", _Id);
            this.crvReporte.ReportSource = reporte;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            reporte.Load("Contrato.rpt");
            reporte.SetDatabaseLogon("sa", "EC1admin");
            reporte.SetParameterValue("@ContratoId", this.cmbContratos.SelectedValue.ToString());
            this.crvReporte.ReportSource = reporte;
        }
    }
}
