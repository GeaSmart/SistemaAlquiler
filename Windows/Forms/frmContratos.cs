using AutoMapper;
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
using Windows.DTO;
using Windows.Entities;
using Windows.Model;

namespace Windows.Forms
{
    public partial class frmContratos : DevComponents.DotNetBar.Metro.MetroForm
    {
        int Id = 0;
        ApplicationDBContext context = new ApplicationDBContext();
        public frmContratos()
        {
            InitializeComponent();
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {
            //cargarClientes();
            this.txtBuscarCliente.Select();
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
            if (GuardarContrato())
                Limpiar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmBusquedaEquipo busqueda = new frmBusquedaEquipo();

            var result = busqueda.ShowDialog();
            if (result == DialogResult.OK)
            {
                int val = busqueda.Id;
                cargarEquipo(val);
                                
                calcularDias();
                calcularMonto();
                calcularSuma();
            }
        }

        private void cargarEquipo(int idEquipo)
        {
            ResponseModel<EquipoEntity> response = EquipoModel.Obtener(idEquipo);

            var equipo = response.Data;

            var rowId = dgvDetalleContrato.Rows.Add();
            DataGridViewRow row = dgvDetalleContrato.Rows[rowId];

            row.Cells["Codigo"].Value = equipo.Codigo;
            row.Cells["EquipoId"].Value = idEquipo;
            row.Cells["Equipo"].Value = equipo.Descripcion;
            row.Cells["Monto"].Value = "";

            row.Cells["FechaInicio"].Value = DateTime.Now.ToShortDateString();
            row.Cells["FechaFin"].Value = DateTime.Now.ToShortDateString();
            row.Cells["MontoDia"].Value = equipo.PrecioBaseDia.ToString();
        }

        private void cargarLineaDetalle(DetalleContratoEntity detalle)
        {
            this.dgvDetalleContrato.Rows.Add("", detalle.EquipoId.ToString(), detalle.Equipo.Descripcion, detalle.FechaInicio, detalle.FechaFin, detalle.Monto);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (GuardarContrato())
            {
                frmReporteContrato frm = new frmReporteContrato(Id);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                Limpiar();
            }            
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            calcularSuma();
            calcularDias();
            calcularMonto();
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calcularSuma();
            calcularDias();
            calcularMonto();
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BusquedaClientes();
        }

        private void calcularSuma()
        {
            decimal sumatoria = 0;
            foreach (DataGridViewRow fila in this.dgvDetalleContrato.Rows)
            {
                //var num = fila.Cells["Monto"].ToString();
                decimal value;
                if (fila.Cells["Monto"].Value != null)
                {
                    if (Decimal.TryParse(fila.Cells["Monto"].Value.ToString(), out value))
                        sumatoria += value;
                }
            }
            this.lblSumatoria.Text = "S/ " + sumatoria.ToString();
        }

        private void calcularDias()
        {
            foreach (DataGridViewRow fila in this.dgvDetalleContrato.Rows)
            {
                //var num = fila.Cells["Monto"].ToString();
                DateTime fechaInicio;
                DateTime fechaFin;
                int dias = 0;

                if (DateTime.TryParse(fila.Cells["FechaInicio"].Value.ToString(), out fechaInicio) &&
                    DateTime.TryParse(fila.Cells["FechaFin"].Value.ToString(), out fechaFin))
                    dias = (int)(fechaFin - fechaInicio).TotalDays + 1;

                fila.Cells["Dias"].Value = dias.ToString();
            }            
        }

        private void calcularMonto()
        {
            foreach (DataGridViewRow fila in this.dgvDetalleContrato.Rows)
            {                               
                int dias = 0;
                decimal monto = 0;
                decimal montoMultiplicado = 0;

                if (int.TryParse(fila.Cells["Dias"].Value.ToString(), out dias) &&
                    Decimal.TryParse(fila.Cells["MontoDia"].Value.ToString(), out monto))
                    montoMultiplicado = dias * monto;

                fila.Cells["Monto"].Value = montoMultiplicado.ToString();
            }
        }
        private void BusquedaClientes()
        {
                var listado = context.Clientes.Where(
                    x => x.NombreCompleto.Contains(this.txtBuscarCliente.Text) ||
                        x.Documento.Contains(this.txtBuscarCliente.Text)
                ).ToList();

            var clientesDTO = Mapper.Map<List<ClienteDTO>>(listado);

            if (listado.Count > 0 && this.txtBuscarCliente.Text.Length > 0)
            {
                this.cmbCliente.DataSource = clientesDTO;
                this.cmbCliente.DisplayMember = "DocumentoNombreCompleto";
                this.cmbCliente.ValueMember = "Id";

                this.lblExiste.Text = "";
                this.lblExiste.Visible = false;
                this.btnNuevo.Visible = false;
            }
            else
            {
                this.cmbCliente.DataSource = null;
                this.cmbCliente.SelectedIndex = -1;

                this.lblExiste.Text = "No se encontraron clientes";
                this.lblExiste.Visible = true;
                this.btnNuevo.Visible = true;
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCliente.SelectedValue != null)
            {
                int id = 0;
                if (int.TryParse(this.cmbCliente.SelectedValue.ToString(), out id))
                    cargarUltimaDireccionObra(id);
            }
            else
            {
                this.txtDireccionObra.Text = "";
            }
        }

        private void cargarUltimaDireccionObra(int clienteId)
        {
            var ultimoContrato = context.Contratos.Where(x => x.ClienteId == clienteId).OrderByDescending(x => x.Id).FirstOrDefault();
            if (ultimoContrato != null)
            {
                this.txtDireccionObra.Text = ultimoContrato.DireccionObra;
            }
            else
            {
                this.txtDireccionObra.Text = "";
            }
                
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            Id = 0;
            this.txtBuscarCliente.Text = "";

            this.cmbCliente.DataSource = null;
            this.cmbCliente.SelectedIndex = -1;

            this.lblExiste.Text = "No se encontraron clientes";
            this.lblExiste.Visible = false;
            this.btnNuevo.Visible = false;

            this.txtDireccionObra.Text = "";
            this.txtReferencia.Text = "";

            this.dgvDetalleContrato.Rows.Clear();

            this.txtConceptoAdicional.Text = "";
            this.nudAdicional.Value = 0;

            this.txtObservaciones.Text = "";

            this.lblSumatoria.Text = "";

            this.txtBuscarCliente.Select();
        }

        private bool GuardarContrato()
        {
            bool flag = false;
            string contenido = "El arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la rentaEl arrendamiento se da cuando el propietario de un bien cede temporalmente su uso y disfrute a otra persona a cambio del pago de una renta. Popularmente se conoce como alquiler, y se formaliza en un contrato. Se llama arrendador al propietario que cede la posesión del bien y arrendatario a quien la adquiere a cambio del pago de la renta";
            var listaDetalle = new List<DetalleContratoEntity>();

            int clienteId = this.cmbCliente.SelectedValue != null ? Convert.ToInt32(this.cmbCliente.SelectedValue.ToString()) : 0;
            var contrato = new ContratoEntity
            {
                ClienteId = clienteId,
                DireccionObra = this.txtDireccionObra.Text,
                Referencia = this.txtReferencia.Text,
                Observaciones = this.txtObservaciones.Text,
                ConceptoAdicional = this.txtConceptoAdicional.Text,
                MontoAdicional = this.nudAdicional.Value,
                Contenido = contenido,
                Detalles = listaDetalle

            };

            foreach (DataGridViewRow fila in this.dgvDetalleContrato.Rows)
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

            try
            {
                if (contrato.ClienteId > 0 && contrato.Detalles.Count > 0)
                {
                    var response = ContratoModel.Guardar(contrato);

                    if (response.Response)
                    {
                        Id = contrato.Id;
                        MessageBox.Show($"El registro fue guardado con id {Id}");                                                
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show(response.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Asegúrese que tiene seleccionado un cliente y que añadió al menos 1 equipo");
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return flag;
        }

        private void dgvDetalleContrato_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularSuma();
        }

        private void dgvDetalleContrato_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calcularSuma();
        }

        private void nudAdicional_Enter(object sender, EventArgs e)
        {
            this.nudAdicional.Select(0, this.nudAdicional.Text.Length);
        }
    }
}
