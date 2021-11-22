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
            AddRows();
        }

        private void AddRows()
        {
            //this.dataGridView1.Rows.Add("", "TAB001", "TABLERO CUADRADO PINO PRENSADO 2X2M", "05/01/2021", "07/01/2021", "34.00");
            //this.dataGridView1.Rows.Add("", "MES001", "MESA CUADRADO PINO PRENSADO", "05/01/2021", "07/01/2021", "45.00");
            //this.dataGridView1.Rows.Add("", "AND002", "ANDAMIO METAL 3M", "05/01/2021", "08/01/2021", "22.50");
            //this.dataGridView1.Rows.Add("", "AND003", "ANDAMIO METAL 3 CUERPOS", "05/01/2021", "08/01/2021", "27.30");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int id = this.txtId.Text.Length > 0 ? Convert.ToInt32(this.txtId.Text) : 0;

            var contrato = new ContratoEntity
            {
                ClienteId = 1,
                DireccionObra = this.txtDireccionObra.Text,
                Referencia = this.txtReferencia.Text,
                Observaciones = this.txtObservaciones.Text,
                IsCombustible = this.chkIsCombustible.Checked,
                IsTransporte = this.chkIsTransporte.Checked,
                ConceptoAdicional = this.txtConceptoAdicional.Text,
                MontoAdicional = this.nudAdicional.Value
            };

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
            //frmBusquedaEquipo busqueda = new frmBusquedaEquipo();

            //var result = busqueda.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    int val = busqueda.Id;
            //    CargarEquipo(val);
            //    this.btnGuardar.Text = "Actualizar";
            //    this.btnGuardar.Enabled = true;
            //    this.btnEliminar.Enabled = true;
            //}

            frmContratosAddDetalle frm = new frmContratosAddDetalle();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DetalleContratoEntity detalle = frm.detalle;
                cargarLineaDetalle(detalle);
            }
        }

        private void cargarLineaDetalle(DetalleContratoEntity detalle)
        {
            this.dataGridView1.Rows.Add("", detalle.EquipoId.ToString(), detalle.Equipo.Descripcion, detalle.FechaInicio, detalle.FechaFin, detalle.Monto);
        }


    }
}
