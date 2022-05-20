
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.dgvDetalleContrato = new System.Windows.Forms.DataGridView();
            this.Opciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblExiste = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleContrato)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 37);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seleccione el cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDireccionObra);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1571, 168);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Alquiler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(297, 100);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(696, 43);
            this.txtReferencia.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dirección de la obra";
            // 
            // txtDireccionObra
            // 
            this.txtDireccionObra.Location = new System.Drawing.Point(297, 47);
            this.txtDireccionObra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionObra.Name = "txtDireccionObra";
            this.txtDireccionObra.Size = new System.Drawing.Size(696, 43);
            this.txtDireccionObra.TabIndex = 7;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Location = new System.Drawing.Point(1233, 47);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(292, 96);
            this.txtObservaciones.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1022, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 37);
            this.label13.TabIndex = 11;
            this.label13.Text = "Observaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblSumatoria);
            this.groupBox3.Controls.Add(this.nudAdicional);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtConceptoAdicional);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.dgvDetalleContrato);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 411);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1580, 590);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipos";
            // 
            // lblSumatoria
            // 
            this.lblSumatoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumatoria.Location = new System.Drawing.Point(1333, 437);
            this.lblSumatoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumatoria.Name = "lblSumatoria";
            this.lblSumatoria.Size = new System.Drawing.Size(201, 37);
            this.lblSumatoria.TabIndex = 19;
            this.lblSumatoria.Text = " S/";
            this.lblSumatoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAdicional
            // 
            this.nudAdicional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudAdicional.Location = new System.Drawing.Point(306, 512);
            this.nudAdicional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAdicional.Name = "nudAdicional";
            this.nudAdicional.Size = new System.Drawing.Size(122, 43);
            this.nudAdicional.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 514);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 37);
            this.label15.TabIndex = 17;
            this.label15.Text = "Monto adicional";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 462);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 37);
            this.label14.TabIndex = 16;
            this.label14.Text = "Concepto adicional";
            // 
            // txtConceptoAdicional
            // 
            this.txtConceptoAdicional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConceptoAdicional.Location = new System.Drawing.Point(306, 459);
            this.txtConceptoAdicional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConceptoAdicional.Name = "txtConceptoAdicional";
            this.txtConceptoAdicional.Size = new System.Drawing.Size(421, 43);
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
            // dgvDetalleContrato
            // 
            this.dgvDetalleContrato.AllowUserToAddRows = false;
            this.dgvDetalleContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleContrato.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvDetalleContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Opciones,
            this.EquipoId,
            this.Codigo,
            this.Equipo,
            this.FechaInicio,
            this.FechaFin,
            this.Dias,
            this.MontoDia,
            this.Monto});
            this.dgvDetalleContrato.Location = new System.Drawing.Point(122, 58);
            this.dgvDetalleContrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetalleContrato.Name = "dgvDetalleContrato";
            this.dgvDetalleContrato.RowHeadersWidth = 51;
            this.dgvDetalleContrato.RowTemplate.Height = 24;
            this.dgvDetalleContrato.Size = new System.Drawing.Size(1412, 369);
            this.dgvDetalleContrato.TabIndex = 0;
            this.dgvDetalleContrato.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dgvDetalleContrato.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dgvDetalleContrato.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetalleContrato_RowsAdded);
            this.dgvDetalleContrato.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalleContrato_RowsRemoved);
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
            this.Codigo.Width = 150;
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
            dataGridViewCellStyle4.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaInicio.HeaderText = "Fecha de inicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 238;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaFin.HeaderText = "Fecha fin";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 167;
            // 
            // Dias
            // 
            this.Dias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Dias.HeaderText = "Dias";
            this.Dias.MinimumWidth = 10;
            this.Dias.Name = "Dias";
            this.Dias.Width = 113;
            // 
            // MontoDia
            // 
            this.MontoDia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MontoDia.HeaderText = "MontoDia";
            this.MontoDia.MinimumWidth = 10;
            this.MontoDia.Name = "MontoDia";
            this.MontoDia.Width = 182;
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.Width = 142;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1244, 23);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(306, 56);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Guardar e Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1077, 23);
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
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1028);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1625, 102);
            this.panel1.TabIndex = 7;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "peru",
            "arg",
            "chile",
            "brasil",
            "parag"});
            this.cmbCliente.Location = new System.Drawing.Point(297, 117);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(594, 45);
            this.cmbCliente.TabIndex = 8;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(297, 56);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(594, 43);
            this.txtBuscarCliente.TabIndex = 15;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.lblExiste);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.txtBuscarCliente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1571, 191);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar cliente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(1250, 56);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(275, 103);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Crear nuevo cliente";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblExiste
            // 
            this.lblExiste.AutoSize = true;
            this.lblExiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExiste.ForeColor = System.Drawing.Color.Red;
            this.lblExiste.Location = new System.Drawing.Point(899, 127);
            this.lblExiste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExiste.Name = "lblExiste";
            this.lblExiste.Size = new System.Drawing.Size(19, 29);
            this.lblExiste.TabIndex = 18;
            this.lblExiste.Text = ".";
            this.lblExiste.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(49, 23);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(159, 56);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 1130);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(700, 800);
            this.Name = "frmContratos";
            this.Text = "Contratos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAlquileres_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleContrato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionObra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDetalleContrato;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudAdicional;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConceptoAdicional;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblSumatoria;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblExiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
    }
}