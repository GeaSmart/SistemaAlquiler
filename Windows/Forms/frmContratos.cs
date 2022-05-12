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
        int Id = 0;
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
            string contenido = "El arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la renta";
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
                Contenido = contenido,
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
                Id = contrato.Id;
                MessageBox.Show($"El registro fue guardado con id {Id}");
                this.btnImprimir.Enabled = true;
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
            row.Cells["Monto"].Value = "";

            row.Cells["FechaInicio"].Value = "05/11/2022";
            row.Cells["FechaFin"].Value = "05/15/2022";
        }

        private void cargarLineaDetalle(DetalleContratoEntity detalle)
        {
            this.dataGridView1.Rows.Add("", detalle.EquipoId.ToString(), detalle.Equipo.Descripcion, detalle.FechaInicio, detalle.FechaFin, detalle.Monto);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmReporteContrato frm = new frmReporteContrato(Id);
            frm.ShowDialog();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            calcularSuma();
        }

        private void calcularSuma()
        {
            decimal sumatoria = 0;
            foreach(DataGridViewRow fila in this.dataGridView1.Rows)
            {
                //var num = fila.Cells["Monto"].ToString();
                decimal value;
                if (Decimal.TryParse(fila.Cells["Monto"].Value.ToString(), out value))
                    sumatoria += value;
            }
            this.lblSumatoria.Text = "S/ " + sumatoria.ToString();
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calcularSuma();
        }
    }
}
