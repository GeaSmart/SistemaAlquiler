﻿using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmReporteContrato : DevComponents.DotNetBar.Metro.MetroForm
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
            //reporte.DataSourceConnections[0].IntegratedSecurity = true;
            reporte.SetDatabaseLogon("sa", "EC1admin", ".", "Alquiler"); reporte.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            reporte.SetParameterValue("@ContratoId", _Id);
            this.crvReporte.ReportSource = reporte;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            reporte.Load("Contrato.rpt");
            //reporte.DataSourceConnections[0].IntegratedSecurity = true;            
            reporte.SetDatabaseLogon("sa", "EC1admin",".","Alquiler");
            reporte.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            reporte.SetParameterValue("@ContratoId", this.cmbContratos.SelectedValue.ToString());
            this.crvReporte.ReportSource = reporte;
        }
    }
}
