﻿namespace ReportsC_.Interfaz
{
    partial class TotalsListForm
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
            this.totalesPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totales_PTableAdapter = new ReportsC_.FinanciasDataSetTableAdapters.Totales_PTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.financiasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(193)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.totalesPBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ReportsC_.Reportes.Totals.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(946, 677);
            this.reportViewer.TabIndex = 3;
            // 
            // financiasDataSet
            // 
            this.financiasDataSet.DataSetName = "FinanciasDataSet";
            this.financiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalesPBindingSource
            // 
            this.totalesPBindingSource.DataMember = "Totales_P";
            this.totalesPBindingSource.DataSource = this.financiasDataSet;
            // 
            // totales_PTableAdapter
            // 
            this.totales_PTableAdapter.ClearBeforeFill = true;
            // 
            // TotalsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 677);
            this.Controls.Add(this.reportViewer);
            this.Name = "TotalsListForm";
            this.Text = "TotalsListForm";
            this.Load += new System.EventHandler(this.TotalsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financiasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private FinanciasDataSet financiasDataSet;
        private System.Windows.Forms.BindingSource totalesPBindingSource;
        private FinanciasDataSetTableAdapters.Totales_PTableAdapter totales_PTableAdapter;
    }
}