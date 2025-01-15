namespace ReportsC_.Interfaz
{
    partial class MClientList
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
            this.totalMorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financiasDataSet = new ReportsC_.FinanciasDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.totalMorasTableAdapter = new ReportsC_.FinanciasDataSetTableAdapters.TotalMorasTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.totalMorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financiasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // totalMorasBindingSource
            // 
            this.totalMorasBindingSource.DataMember = "TotalMoras";
            this.totalMorasBindingSource.DataSource = this.financiasDataSet;
            // 
            // financiasDataSet
            // 
            this.financiasDataSet.DataSetName = "FinanciasDataSet";
            this.financiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(193)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.totalMorasBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ReportsC_.Reportes.MClients.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(946, 677);
            this.reportViewer.TabIndex = 2;
            // 
            // totalMorasTableAdapter
            // 
            this.totalMorasTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 677);
            this.panel1.TabIndex = 3;
            // 
            // MClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 677);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panel1);
            this.Name = "MClientList";
            this.Text = "MClientList";
            this.Load += new System.EventHandler(this.MClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalMorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financiasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private FinanciasDataSet financiasDataSet;
        private System.Windows.Forms.BindingSource totalMorasBindingSource;
        private FinanciasDataSetTableAdapters.TotalMorasTableAdapter totalMorasTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}