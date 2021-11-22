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
    public partial class frmContratosAddDetalle : Form
    {
        public DetalleContratoEntity detalle { get; set; }
        public frmContratosAddDetalle()
        {
            InitializeComponent();
        }

        private void frmContratosAddDetalle_Load(object sender, EventArgs e)
        {
            List<EquipoEntity> equipos = new List<EquipoEntity>();
            ResponseModel<List<EquipoEntity>> response = EquipoModel.Obtener();
            equipos = response.Data;

            this.cmbEquipo.DataSource = equipos;
            this.cmbEquipo.DisplayMember = "Descripcion";
            this.cmbEquipo.ValueMember = "Id";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ResponseModel<EquipoEntity> response = EquipoModel.Obtener(Convert.ToInt32(this.cmbEquipo.SelectedValue.ToString()));

            var detalle = new DetalleContratoEntity();
            detalle.Equipo = response.Data;
            detalle.EquipoId = Convert.ToInt32(this.cmbEquipo.SelectedValue.ToString());
            detalle.FechaInicio = this.dtpInicio.Value;
            detalle.FechaFin = this.dtpFin.Value;
            detalle.Monto = this.nudMonto.Value;

            this.detalle = detalle;
            this.Close();
            
        }
    }
}
