
namespace Windows.Forms
{
    partial class frmContratos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContratos));
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIsTransporte = new System.Windows.Forms.CheckBox();
            this.chkIsCombustible = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionObra = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSumatoria = new System.Windows.Forms.Label();
            this.nudAdicional = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtConceptoAdicional = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Opciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seleccione el cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIsTransporte);
            this.groupBox2.Controls.Add(this.chkIsCombustible);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDireccionObra);
            this.groupBox2.Location = new System.Drawing.Point(16, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1210, 191);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Alquiler";
            // 
            // chkIsTransporte
            // 
            this.chkIsTransporte.AutoSize = true;
            this.chkIsTransporte.Location = new System.Drawing.Point(518, 136);
            this.chkIsTransporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsTransporte.Name = "chkIsTransporte";
            this.chkIsTransporte.Size = new System.Drawing.Size(182, 29);
            this.chkIsTransporte.TabIndex = 14;
            this.chkIsTransporte.Text = "Inc.Transporte";
            this.chkIsTransporte.UseVisualStyleBackColor = true;
            // 
            // chkIsCombustible
            // 
            this.chkIsCombustible.AutoSize = true;
            this.chkIsCombustible.Location = new System.Drawing.Point(286, 141);
            this.chkIsCombustible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsCombustible.Name = "chkIsCombustible";
            this.chkIsCombustible.Size = new System.Drawing.Size(197, 29);
            this.chkIsCombustible.TabIndex = 13;
            this.chkIsCombustible.Text = "Inc.Combustible";
            this.chkIsCombustible.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(286, 92);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(532, 31);
            this.txtReferencia.TabIndex = 9;
            this.txtReferencia.Text = "2 CDAS COLEGIO SAN LORENZO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dirección de la obra";
            // 
            // txtDireccionObra
            // 
            this.txtDireccionObra.Location = new System.Drawing.Point(286, 48);
            this.txtDireccionObra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionObra.Name = "txtDireccionObra";
            this.txtDireccionObra.Size = new System.Drawing.Size(532, 31);
            this.txtDireccionObra.TabIndex = 7;
            this.txtDireccionObra.Text = "CALLE LAS GONDOLAS 234 PISO 3 INT B";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(205, 772);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(582, 113);
            this.txtObservaciones.TabIndex = 12;
            this.txtObservaciones.Text = "2 CDAS COLEGIO SAN LORENZO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 775);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Observaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSumatoria);
            this.groupBox3.Controls.Add(this.nudAdicional);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtConceptoAdicional);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(16, 300);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1214, 446);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipos";
            // 
            // lblSumatoria
            // 
            this.lblSumatoria.AutoSize = true;
            this.lblSumatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumatoria.Location = new System.Drawing.Point(1034, 316);
            this.lblSumatoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumatoria.Name = "lblSumatoria";
            this.lblSumatoria.Size = new System.Drawing.Size(50, 31);
            this.lblSumatoria.TabIndex = 19;
            this.lblSumatoria.Text = " S/";
            // 
            // nudAdicional
            // 
            this.nudAdicional.Location = new System.Drawing.Point(1000, 374);
            this.nudAdicional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAdicional.Name = "nudAdicional";
            this.nudAdicional.Size = new System.Drawing.Size(180, 31);
            this.nudAdicional.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(828, 376);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 25);
            this.label15.TabIndex = 17;
            this.label15.Text = "Monto adicional";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 380);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Concepto adicional";
            // 
            // txtConceptoAdicional
            // 
            this.txtConceptoAdicional.Location = new System.Drawing.Point(340, 375);
            this.txtConceptoAdicional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConceptoAdicional.Name = "txtConceptoAdicional";
            this.txtConceptoAdicional.Size = new System.Drawing.Size(421, 31);
            this.txtConceptoAdicional.TabIndex = 15;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(28, 58);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 68);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Opciones,
            this.EquipoId,
            this.Codigo,
            this.Equipo,
            this.FechaInicio,
            this.FechaFin,
            this.Monto});
            this.dataGridView1.Location = new System.Drawing.Point(110, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 253);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // Opciones
            // 
            this.Opciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Opciones.HeaderText = "+";
            this.Opciones.MinimumWidth = 6;
            this.Opciones.Name = "Opciones";
            this.Opciones.ReadOnly = true;
            this.Opciones.Visible = false;
            this.Opciones.Width = 200;
            // 
            // EquipoId
            // 
            this.EquipoId.DataPropertyName = "EquipoId";
            this.EquipoId.HeaderText = "EquipoId";
            this.EquipoId.MinimumWidth = 10;
            this.EquipoId.Name = "EquipoId";
            this.EquipoId.ReadOnly = true;
            this.EquipoId.Visible = false;
            this.EquipoId.Width = 200;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Equipo
            // 
            this.Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.MinimumWidth = 6;
            this.Equipo.Name = "Equipo";
            this.Equipo.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaInicio.HeaderText = "Fecha de inicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 142;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaFin.HeaderText = "Fecha fin";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 135;
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.Width = 117;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(1056, 107);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(159, 56);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(888, 107);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 56);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 928);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 209);
            this.panel1.TabIndex = 7;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "peru",
            "arg",
            "chile",
            "brasil",
            "parag"});
            this.cmbCliente.Location = new System.Drawing.Point(256, 28);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(517, 33);
            this.cmbCliente.TabIndex = 8;
            // 
            // frmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 1137);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(700, 800);
            this.Name = "frmContratos";
            this.Text = "Alquileres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAlquileres_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionObra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox chkIsTransporte;
        private System.Windows.Forms.CheckBox chkIsCombustible;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudAdicional;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConceptoAdicional;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Label lblSumatoria;
    }
}