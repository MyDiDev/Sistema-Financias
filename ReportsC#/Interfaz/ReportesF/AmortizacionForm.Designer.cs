namespace ReportsC_.Interfaz.ReportesF
{
    partial class AmortizacionForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.financiasDataSet = new ReportsC_.FinanciasDataSet();
            this.amortiacionesFiltroIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amortiacionesFiltroIdTableAdapter = new ReportsC_.FinanciasDataSetTableAdapters.AmortiacionesFiltroIdTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.financiasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortiacionesFiltroIdBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(63, 32);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(383, 24);
            this.idComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(193)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.amortiacionesFiltroIdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsC_.Reportes.Amortizacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(928, 547);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // financiasDataSet
            // 
            this.financiasDataSet.DataSetName = "FinanciasDataSet";
            this.financiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amortiacionesFiltroIdBindingSource
            // 
            this.amortiacionesFiltroIdBindingSource.DataMember = "AmortiacionesFiltroId";
            this.amortiacionesFiltroIdBindingSource.DataSource = this.financiasDataSet;
            // 
            // amortiacionesFiltroIdTableAdapter
            // 
            this.amortiacionesFiltroIdTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 83);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AmortizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(928, 630);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "AmortizacionForm";
            this.Text = "AmortizacionForm";
            this.Load += new System.EventHandler(this.AmortizacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financiasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortiacionesFiltroIdBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource amortiacionesFiltroIdBindingSource;
        private FinanciasDataSet financiasDataSet;
        private FinanciasDataSetTableAdapters.AmortiacionesFiltroIdTableAdapter amortiacionesFiltroIdTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}