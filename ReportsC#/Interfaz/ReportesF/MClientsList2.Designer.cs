namespace ReportsC_.Interfaz
{
    partial class MClientsList2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.financiasDataSet = new ReportsC_.FinanciasDataSet();
            this.clientesMorososBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesMorososTableAdapter = new ReportsC_.FinanciasDataSetTableAdapters.ClientesMorososTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.financiasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesMorososBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(193)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.clientesMorososBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ReportsC_.Reportes.MClients2.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(946, 677);
            this.reportViewer.TabIndex = 4;
            // 
            // financiasDataSet
            // 
            this.financiasDataSet.DataSetName = "FinanciasDataSet";
            this.financiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesMorososBindingSource
            // 
            this.clientesMorososBindingSource.DataMember = "ClientesMorosos";
            this.clientesMorososBindingSource.DataSource = this.financiasDataSet;
            // 
            // clientesMorososTableAdapter
            // 
            this.clientesMorososTableAdapter.ClearBeforeFill = true;
            // 
            // MClientsList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 677);
            this.Controls.Add(this.reportViewer);
            this.Name = "MClientsList2";
            this.Text = "MClientsList2";
            this.Load += new System.EventHandler(this.MClientsList2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financiasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesMorososBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private FinanciasDataSet financiasDataSet;
        private System.Windows.Forms.BindingSource clientesMorososBindingSource;
        private FinanciasDataSetTableAdapters.ClientesMorososTableAdapter clientesMorososTableAdapter;
    }
}