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
    public partial class frmContratos : Form
    {
        public frmContratos()
        {
            InitializeComponent();
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }
        private void cargarClientes()
        {
            List<ClienteEntity> clientes = new List<ClienteEntity>();
            ResponseModel<List<ClienteEntity>> response = ClienteModel.Obtener();
            clientes = response.Data;

            this.cmbCliente.DataSource = clientes;
            this.cmbCliente.DisplayMember = "NombreCompleto";
            this.cmbCliente.ValueMember = "Id";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int id = this.txtId.Text.Length > 0 ? Convert.ToInt32(this.txtId.Text) : 0;

            var listaDetalle = new List<DetalleContratoEntity>();

            var contrato = new ContratoEntity
            {
                ClienteId = 1,
                DireccionObra = this.txtDireccionObra.Text,
                Referencia = this.txtReferencia.Text,
                Observaciones = this.txtObservaciones.Text,
                IsCombustible = this.chkIsCombustible.Checked,
                IsTransporte = this.chkIsTransporte.Checked,
                ConceptoAdicional = this.txtConceptoAdicional.Text,
                MontoAdicional = this.nudAdicional.Value,
                Detalles = listaDetalle

            };
                        

            foreach(DataGridViewRow fila in this.dataGridView1.Rows)
            {
                var detalle = new DetalleContratoEntity()
                {
                    Contrato = contrato,
                    EquipoId = Convert.ToInt32(fila.Cells["EquipoId"].Value.ToString()),
                    FechaInicio = Convert.ToDateTime(fila.Cells["FechaInicio"].Value.ToString()),
                    FechaFin = Convert.ToDateTime(fila.Cells["FechaFin"].Value.ToString()),
                    Monto = Convert.ToDecimal(fila.Cells["Monto"].Value.ToString())
                };
                listaDetalle.Add(detalle);
            }

            var response = ContratoModel.Guardar(contrato);
            if (response.Response)
            {
                MessageBox.Show("El registro fue guardado");
                //this.btnNuevo.PerformClick();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmBusquedaEquipo busqueda = new frmBusquedaEquipo();

            var result = busqueda.ShowDialog();
            if (result == DialogResult.OK)
            {
                int val = busqueda.Id;
                cargarEquipo(val);
                //this.btnGuardar.Text = "Actualizar";
                //this.btnGuardar.Enabled = true;                
            }

            //frmContratosAddDetalle frm = new frmContratosAddDetalle();
            //var result = frm.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    DetalleContratoEntity detalle = frm.detalle;
            //    cargarEquipo(detalle);
            //}
        }

        private void cargarEquipo(int idEquipo)
        {
            ResponseModel<EquipoEntity> response = EquipoModel.Obtener(idEquipo);

            var equipo = response.Data;

            var rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];

            row.Cells["Codigo"].Value = equipo.Codigo;
            row.Cells["EquipoId"].Value = idEquipo;
            row.Cells["Equipo"].Value = equipo.Descripcion;
            row.Cells["Monto"].Value = "1.0";

        }

        private void cargarLineaDetalle(DetalleContratoEntity detalle)
        {
            this.dataGridView1.Rows.Add("", detalle.EquipoId.ToString(), detalle.Equipo.Descripcion, detalle.FechaInicio, detalle.FechaFin, detalle.Monto);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {            
           ReportDocument reporte = new ReportDocument();
            reporte.Load("CrystalReport1.rpt");
            reporte.SetDatabaseLogon("sa", "EC1admin");
            reporte.SetParameterValue("@ContratoId", "7");
            //reporte.RecordSelectionFormula = "{vwu_FacturaElectronica.DocEntry} = " + factura.DocEntry;
            this.crvContrato.ReportSource = reporte;
        }
    }
}
