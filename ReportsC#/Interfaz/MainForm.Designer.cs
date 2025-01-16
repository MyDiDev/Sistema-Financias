namespace ReportsC_.Interfaz
{
    partial class MainForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.clientAmInfoBtn = new System.Windows.Forms.Button();
            this.clientLoanInfoBtn = new System.Windows.Forms.Button();
            this.clientInfoBtn = new System.Windows.Forms.Button();
            this.isAdmin = new System.Windows.Forms.Label();
            this.registerAdminBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminBtnReport = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Black;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.btnPrestamo);
            this.panel1.Controls.Add(this.clientAmInfoBtn);
            this.panel1.Controls.Add(this.clientLoanInfoBtn);
            this.panel1.Controls.Add(this.clientInfoBtn);
            this.panel1.Controls.Add(this.isAdmin);
            this.panel1.Controls.Add(this.registerAdminBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.adminBtnReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 724);
            this.panel1.TabIndex = 0;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamo.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrestamo.Location = new System.Drawing.Point(0, 361);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(235, 74);
            this.btnPrestamo.TabIndex = 11;
            this.btnPrestamo.Text = "Realizar Prestamo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // clientAmInfoBtn
            // 
            this.clientAmInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.clientAmInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientAmInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientAmInfoBtn.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAmInfoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientAmInfoBtn.Location = new System.Drawing.Point(0, 292);
            this.clientAmInfoBtn.Name = "clientAmInfoBtn";
            this.clientAmInfoBtn.Size = new System.Drawing.Size(235, 74);
            this.clientAmInfoBtn.TabIndex = 10;
            this.clientAmInfoBtn.Text = "Amortizaciones";
            this.clientAmInfoBtn.UseVisualStyleBackColor = false;
            this.clientAmInfoBtn.Click += new System.EventHandler(this.clientAmInfoBtn_Click);
            // 
            // clientLoanInfoBtn
            // 
            this.clientLoanInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.clientLoanInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientLoanInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientLoanInfoBtn.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLoanInfoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientLoanInfoBtn.Location = new System.Drawing.Point(0, 221);
            this.clientLoanInfoBtn.Name = "clientLoanInfoBtn";
            this.clientLoanInfoBtn.Size = new System.Drawing.Size(235, 74);
            this.clientLoanInfoBtn.TabIndex = 9;
            this.clientLoanInfoBtn.Text = "Prestamos";
            this.clientLoanInfoBtn.UseVisualStyleBackColor = false;
            this.clientLoanInfoBtn.Click += new System.EventHandler(this.clientLoanInfoBtn_Click);
            // 
            // clientInfoBtn
            // 
            this.clientInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.clientInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientInfoBtn.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInfoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientInfoBtn.Location = new System.Drawing.Point(0, 151);
            this.clientInfoBtn.Name = "clientInfoBtn";
            this.clientInfoBtn.Size = new System.Drawing.Size(235, 74);
            this.clientInfoBtn.TabIndex = 8;
            this.clientInfoBtn.Text = "Informacion Personal";
            this.clientInfoBtn.UseVisualStyleBackColor = false;
            this.clientInfoBtn.Click += new System.EventHandler(this.clientInfoBtn_Click);
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.BackColor = System.Drawing.Color.Transparent;
            this.isAdmin.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.isAdmin.Location = new System.Drawing.Point(12, 690);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(23, 25);
            this.isAdmin.TabIndex = 7;
            this.isAdmin.Text = "A";
            // 
            // registerAdminBtn
            // 
            this.registerAdminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.registerAdminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerAdminBtn.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerAdminBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerAdminBtn.Location = new System.Drawing.Point(0, 221);
            this.registerAdminBtn.Name = "registerAdminBtn";
            this.registerAdminBtn.Size = new System.Drawing.Size(235, 74);
            this.registerAdminBtn.TabIndex = 6;
            this.registerAdminBtn.Text = "Registrar";
            this.registerAdminBtn.UseVisualStyleBackColor = false;
            this.registerAdminBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Finanzas";
            // 
            // adminBtnReport
            // 
            this.adminBtnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.adminBtnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtnReport.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminBtnReport.Location = new System.Drawing.Point(0, 151);
            this.adminBtnReport.Name = "adminBtnReport";
            this.adminBtnReport.Size = new System.Drawing.Size(235, 74);
            this.adminBtnReport.TabIndex = 0;
            this.adminBtnReport.Text = "Reportes";
            this.adminBtnReport.UseVisualStyleBackColor = false;
            this.adminBtnReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // formPanel
            // 
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(235, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(964, 724);
            this.formPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 724);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label isAdmin;
        public System.Windows.Forms.Button clientAmInfoBtn;
        public System.Windows.Forms.Button clientLoanInfoBtn;
        public System.Windows.Forms.Button clientInfoBtn;
        public System.Windows.Forms.Button adminBtnReport;
        public System.Windows.Forms.Button registerAdminBtn;
        public System.Windows.Forms.Button btnPrestamo;
    }
}