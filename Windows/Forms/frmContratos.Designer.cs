
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIsTransporte = new System.Windows.Forms.CheckBox();
            this.chkIsCombustible = new System.Windows.Forms.CheckBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionObra = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudAdicional = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtConceptoAdicional = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Opciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTRATO N°";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(719, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seleccione el cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIsTransporte);
            this.groupBox2.Controls.Add(this.chkIsCombustible);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDireccionObra);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Alquiler";
            // 
            // chkIsTransporte
            // 
            this.chkIsTransporte.AutoSize = true;
            this.chkIsTransporte.Location = new System.Drawing.Point(345, 87);
            this.chkIsTransporte.Name = "chkIsTransporte";
            this.chkIsTransporte.Size = new System.Drawing.Size(122, 21);
            this.chkIsTransporte.TabIndex = 14;
            this.chkIsTransporte.Text = "Inc.Transporte";
            this.chkIsTransporte.UseVisualStyleBackColor = true;
            // 
            // chkIsCombustible
            // 
            this.chkIsCombustible.AutoSize = true;
            this.chkIsCombustible.Location = new System.Drawing.Point(191, 90);
            this.chkIsCombustible.Name = "chkIsCombustible";
            this.chkIsCombustible.Size = new System.Drawing.Size(129, 21);
            this.chkIsCombustible.TabIndex = 13;
            this.chkIsCombustible.Text = "Inc.Combustible";
            this.chkIsCombustible.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(667, 31);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(117, 50);
            this.txtObservaciones.TabIndex = 12;
            this.txtObservaciones.Text = "2 CDAS COLEGIO SAN LORENZO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(558, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Observaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(191, 59);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(356, 22);
            this.txtReferencia.TabIndex = 9;
            this.txtReferencia.Text = "2 CDAS COLEGIO SAN LORENZO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dirección de la obra";
            // 
            // txtDireccionObra
            // 
            this.txtDireccionObra.Location = new System.Drawing.Point(191, 31);
            this.txtDireccionObra.Name = "txtDireccionObra";
            this.txtDireccionObra.Size = new System.Drawing.Size(356, 22);
            this.txtDireccionObra.TabIndex = 7;
            this.txtDireccionObra.Text = "CALLE LAS GONDOLAS 234 PISO 3 INT B";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudAdicional);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtConceptoAdicional);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(809, 298);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipos";
            // 
            // nudAdicional
            // 
            this.nudAdicional.Location = new System.Drawing.Point(523, 251);
            this.nudAdicional.Name = "nudAdicional";
            this.nudAdicional.Size = new System.Drawing.Size(120, 22);
            this.nudAdicional.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(520, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Monto adicional";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Concepto adicional";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(689, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "S/";
            // 
            // txtConceptoAdicional
            // 
            this.txtConceptoAdicional.Location = new System.Drawing.Point(223, 253);
            this.txtConceptoAdicional.Name = "txtConceptoAdicional";
            this.txtConceptoAdicional.Size = new System.Drawing.Size(282, 22);
            this.txtConceptoAdicional.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(732, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "128.80";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(19, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 33);
            this.button8.TabIndex = 1;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Opciones,
            this.Codigo,
            this.Equipo,
            this.FechaInicio,
            this.FechaFin,
            this.Monto});
            this.dataGridView1.Location = new System.Drawing.Point(59, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // Opciones
            // 
            this.Opciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Opciones.HeaderText = "+";
            this.Opciones.MinimumWidth = 6;
            this.Opciones.Name = "Opciones";
            this.Opciones.ReadOnly = true;
            this.Opciones.Width = 45;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 81;
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
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 92;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaFin.HeaderText = "Fecha fin";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 88;
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 76;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(704, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "Imprimir";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(592, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 36);
            this.button7.TabIndex = 6;
            this.button7.Text = "Guardar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 761);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 71);
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
            this.cmbCliente.Location = new System.Drawing.Point(171, 87);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(346, 24);
            this.cmbCliente.TabIndex = 8;
            // 
            // frmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 832);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "frmContratos";
            this.Text = "Alquileres";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionObra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkIsTransporte;
        private System.Windows.Forms.CheckBox chkIsCombustible;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudAdicional;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConceptoAdicional;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}