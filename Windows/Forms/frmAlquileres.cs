using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Forms
{
    public partial class frmAlquileres : Form
    {
        public frmAlquileres()
        {
            InitializeComponent();
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {
            AddRows();
        }

        private void AddRows()
        {
            this.dataGridView1.Rows.Add("", "TAB001", "TABLERO CUADRADO PINO PRENSADO 2X2M", "05/01/2021", "07/01/2021", "34.00");
            this.dataGridView1.Rows.Add("", "MES001", "MESA CUADRADO PINO PRENSADO", "05/01/2021", "07/01/2021", "45.00");
            this.dataGridView1.Rows.Add("", "AND002", "ANDAMIO METAL 3M", "05/01/2021", "08/01/2021", "22.50");
            this.dataGridView1.Rows.Add("", "AND003", "ANDAMIO METAL 3 CUERPOS", "05/01/2021", "08/01/2021", "27.30");

        }
    }
}
