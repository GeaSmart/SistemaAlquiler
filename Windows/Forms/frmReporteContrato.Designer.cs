
namespace Windows.Forms
{
    partial class frmReporteContrato
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
            this.crvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbContratos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvReporte
            // 
            this.crvReporte.ActiveViewIndex = -1;
            this.crvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte.Location = new System.Drawing.Point(22, 211);
            this.crvReporte.Name = "crvReporte";
            this.crvReporte.Size = new System.Drawing.Size(1356, 825);
            this.crvReporte.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un contrato";
            // 
            // cmbContratos
            // 
            this.cmbContratos.FormattingEnabled = true;
            this.cmbContratos.Location = new System.Drawing.Point(367, 74);
            this.cmbContratos.Name = "cmbContratos";
            this.cmbContratos.Size = new System.Drawing.Size(350, 45);
            this.cmbContratos.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbContratos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1356, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de contratos";
            // 
            // frmReporteContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 1060);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crvReporte);
            this.DoubleBuffered = true;
            this.Name = "frmReporteContrato";
            this.Text = "Contrato";
            this.Load += new System.EventHandler(this.frmReporteContrato_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbContratos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}