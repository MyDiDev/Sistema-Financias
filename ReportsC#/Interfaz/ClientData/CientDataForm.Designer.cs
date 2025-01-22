namespace ReportsC_.Interfaz.ClientData
{
    partial class CientDataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.clientEmail = new System.Windows.Forms.ComboBox();
            this.mailClientLabel = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.NumericUpDown();
            this.depositLabel = new System.Windows.Forms.Label();
            this.mora = new System.Windows.Forms.NumericUpDown();
            this.moraLabel = new System.Windows.Forms.Label();
            this.intMora = new System.Windows.Forms.NumericUpDown();
            this.intMoraLabel = new System.Windows.Forms.Label();
            this.sueldoAnterior = new System.Windows.Forms.NumericUpDown();
            this.sueldoALabel = new System.Windows.Forms.Label();
            this.sueldoActual = new System.Windows.Forms.NumericUpDown();
            this.sueldoActualLabel = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.mesNoLabel = new System.Windows.Forms.Label();
            this.monthsLeft = new System.Windows.Forms.NumericUpDown();
            this.mesLeftLabel = new System.Windows.Forms.Label();
            this.amortizarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(922, 69);
            this.title.TabIndex = 39;
            this.title.Text = "Prestamos";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(10)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(14)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.Location = new System.Drawing.Point(12, 134);
            this.data.Name = "data";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.data.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(923, 353);
            this.data.TabIndex = 40;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(12, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 24);
            this.nameLabel.TabIndex = 41;
            this.nameLabel.Text = "Nombre: ";
            // 
            // clientEmail
            // 
            this.clientEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.clientEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientEmail.ForeColor = System.Drawing.Color.White;
            this.clientEmail.FormattingEnabled = true;
            this.clientEmail.Location = new System.Drawing.Point(168, 522);
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(182, 24);
            this.clientEmail.TabIndex = 43;
            this.clientEmail.SelectedIndexChanged += new System.EventHandler(this.clientEmail_SelectedIndexChanged);
            // 
            // mailClientLabel
            // 
            this.mailClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mailClientLabel.AutoSize = true;
            this.mailClientLabel.BackColor = System.Drawing.Color.Transparent;
            this.mailClientLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailClientLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mailClientLabel.Location = new System.Drawing.Point(13, 520);
            this.mailClientLabel.Name = "mailClientLabel";
            this.mailClientLabel.Size = new System.Drawing.Size(149, 22);
            this.mailClientLabel.TabIndex = 42;
            this.mailClientLabel.Text = "Correo del cliente:";
            // 
            // deposit
            // 
            this.deposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.deposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deposit.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.SystemColors.Window;
            this.deposit.Location = new System.Drawing.Point(468, 526);
            this.deposit.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.deposit.Name = "deposit";
            this.deposit.ReadOnly = true;
            this.deposit.Size = new System.Drawing.Size(191, 23);
            this.deposit.TabIndex = 45;
            this.deposit.ThousandsSeparator = true;
            // 
            // depositLabel
            // 
            this.depositLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositLabel.AutoSize = true;
            this.depositLabel.BackColor = System.Drawing.Color.Transparent;
            this.depositLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.depositLabel.Location = new System.Drawing.Point(369, 523);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(82, 22);
            this.depositLabel.TabIndex = 44;
            this.depositLabel.Text = "Deposito:";
            // 
            // mora
            // 
            this.mora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.mora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mora.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mora.ForeColor = System.Drawing.SystemColors.Window;
            this.mora.Location = new System.Drawing.Point(741, 526);
            this.mora.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mora.Name = "mora";
            this.mora.ReadOnly = true;
            this.mora.Size = new System.Drawing.Size(194, 23);
            this.mora.TabIndex = 47;
            this.mora.ThousandsSeparator = true;
            this.mora.ValueChanged += new System.EventHandler(this.mora_ValueChanged);
            // 
            // moraLabel
            // 
            this.moraLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moraLabel.AutoSize = true;
            this.moraLabel.BackColor = System.Drawing.Color.Transparent;
            this.moraLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moraLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.moraLabel.Location = new System.Drawing.Point(681, 524);
            this.moraLabel.Name = "moraLabel";
            this.moraLabel.Size = new System.Drawing.Size(54, 22);
            this.moraLabel.TabIndex = 46;
            this.moraLabel.Text = "Mora:";
            // 
            // intMora
            // 
            this.intMora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.intMora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.intMora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intMora.Enabled = false;
            this.intMora.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intMora.ForeColor = System.Drawing.SystemColors.Window;
            this.intMora.Location = new System.Drawing.Point(130, 576);
            this.intMora.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.intMora.Name = "intMora";
            this.intMora.ReadOnly = true;
            this.intMora.Size = new System.Drawing.Size(149, 23);
            this.intMora.TabIndex = 49;
            this.intMora.ThousandsSeparator = true;
            // 
            // intMoraLabel
            // 
            this.intMoraLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.intMoraLabel.AutoSize = true;
            this.intMoraLabel.BackColor = System.Drawing.Color.Transparent;
            this.intMoraLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intMoraLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.intMoraLabel.Location = new System.Drawing.Point(13, 573);
            this.intMoraLabel.Name = "intMoraLabel";
            this.intMoraLabel.Size = new System.Drawing.Size(111, 22);
            this.intMoraLabel.TabIndex = 48;
            this.intMoraLabel.Text = "Interes Mora:";
            // 
            // sueldoAnterior
            // 
            this.sueldoAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sueldoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.sueldoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sueldoAnterior.Enabled = false;
            this.sueldoAnterior.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoAnterior.ForeColor = System.Drawing.SystemColors.Window;
            this.sueldoAnterior.Location = new System.Drawing.Point(444, 576);
            this.sueldoAnterior.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.sueldoAnterior.Name = "sueldoAnterior";
            this.sueldoAnterior.ReadOnly = true;
            this.sueldoAnterior.Size = new System.Drawing.Size(167, 23);
            this.sueldoAnterior.TabIndex = 51;
            this.sueldoAnterior.ThousandsSeparator = true;
            // 
            // sueldoALabel
            // 
            this.sueldoALabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sueldoALabel.AutoSize = true;
            this.sueldoALabel.BackColor = System.Drawing.Color.Transparent;
            this.sueldoALabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoALabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sueldoALabel.Location = new System.Drawing.Point(305, 573);
            this.sueldoALabel.Name = "sueldoALabel";
            this.sueldoALabel.Size = new System.Drawing.Size(133, 22);
            this.sueldoALabel.TabIndex = 50;
            this.sueldoALabel.Text = "Sueldo Anterior:";
            // 
            // sueldoActual
            // 
            this.sueldoActual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sueldoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.sueldoActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sueldoActual.Enabled = false;
            this.sueldoActual.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoActual.ForeColor = System.Drawing.SystemColors.Window;
            this.sueldoActual.Location = new System.Drawing.Point(758, 573);
            this.sueldoActual.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.sueldoActual.Name = "sueldoActual";
            this.sueldoActual.ReadOnly = true;
            this.sueldoActual.Size = new System.Drawing.Size(177, 23);
            this.sueldoActual.TabIndex = 53;
            this.sueldoActual.ThousandsSeparator = true;
            // 
            // sueldoActualLabel
            // 
            this.sueldoActualLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sueldoActualLabel.AutoSize = true;
            this.sueldoActualLabel.BackColor = System.Drawing.Color.Transparent;
            this.sueldoActualLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoActualLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sueldoActualLabel.Location = new System.Drawing.Point(633, 573);
            this.sueldoActualLabel.Name = "sueldoActualLabel";
            this.sueldoActualLabel.Size = new System.Drawing.Size(119, 22);
            this.sueldoActualLabel.TabIndex = 52;
            this.sueldoActualLabel.Text = "Sueldo Actual:";
            // 
            // month
            // 
            this.month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.month.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.ForeColor = System.Drawing.SystemColors.Window;
            this.month.Location = new System.Drawing.Point(168, 626);
            this.month.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Size = new System.Drawing.Size(158, 23);
            this.month.TabIndex = 55;
            this.month.ThousandsSeparator = true;
            // 
            // mesNoLabel
            // 
            this.mesNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mesNoLabel.AutoSize = true;
            this.mesNoLabel.BackColor = System.Drawing.Color.Transparent;
            this.mesNoLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesNoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mesNoLabel.Location = new System.Drawing.Point(8, 623);
            this.mesNoLabel.Name = "mesNoLabel";
            this.mesNoLabel.Size = new System.Drawing.Size(147, 22);
            this.mesNoLabel.TabIndex = 54;
            this.mesNoLabel.Text = "Mes que no Pago:";
            // 
            // monthsLeft
            // 
            this.monthsLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthsLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.monthsLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monthsLeft.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.monthsLeft.Location = new System.Drawing.Point(508, 626);
            this.monthsLeft.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.monthsLeft.Name = "monthsLeft";
            this.monthsLeft.ReadOnly = true;
            this.monthsLeft.Size = new System.Drawing.Size(175, 23);
            this.monthsLeft.TabIndex = 57;
            this.monthsLeft.ThousandsSeparator = true;
            // 
            // mesLeftLabel
            // 
            this.mesLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mesLeftLabel.AutoSize = true;
            this.mesLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.mesLeftLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesLeftLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mesLeftLabel.Location = new System.Drawing.Point(352, 627);
            this.mesLeftLabel.Name = "mesLeftLabel";
            this.mesLeftLabel.Size = new System.Drawing.Size(139, 22);
            this.mesLeftLabel.TabIndex = 56;
            this.mesLeftLabel.Text = "Meses Restantes:";
            // 
            // amortizarBtn
            // 
            this.amortizarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amortizarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(5)))), ((int)(((byte)(209)))));
            this.amortizarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.amortizarBtn.FlatAppearance.BorderSize = 0;
            this.amortizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amortizarBtn.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amortizarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.amortizarBtn.Location = new System.Drawing.Point(706, 623);
            this.amortizarBtn.Name = "amortizarBtn";
            this.amortizarBtn.Size = new System.Drawing.Size(229, 42);
            this.amortizarBtn.TabIndex = 58;
            this.amortizarBtn.Text = "Calcular";
            this.amortizarBtn.UseVisualStyleBackColor = false;
            this.amortizarBtn.Click += new System.EventHandler(this.amortizarBtn_Click);
            // 
            // CientDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(946, 677);
            this.Controls.Add(this.data);
            this.Controls.Add(this.amortizarBtn);
            this.Controls.Add(this.monthsLeft);
            this.Controls.Add(this.mesLeftLabel);
            this.Controls.Add(this.month);
            this.Controls.Add(this.mesNoLabel);
            this.Controls.Add(this.sueldoActual);
            this.Controls.Add(this.sueldoActualLabel);
            this.Controls.Add(this.sueldoAnterior);
            this.Controls.Add(this.sueldoALabel);
            this.Controls.Add(this.intMora);
            this.Controls.Add(this.intMoraLabel);
            this.Controls.Add(this.mora);
            this.Controls.Add(this.moraLabel);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.clientEmail);
            this.Controls.Add(this.mailClientLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.title);
            this.Name = "CientDataForm";
            this.Text = "CientDataForm";
            this.Load += new System.EventHandler(this.CientDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label title;
        public System.Windows.Forms.DataGridView data;
        public System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox clientEmail;
        private System.Windows.Forms.Label mailClientLabel;
        public System.Windows.Forms.NumericUpDown deposit;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.NumericUpDown mora;
        private System.Windows.Forms.Label moraLabel;
        private System.Windows.Forms.NumericUpDown intMora;
        private System.Windows.Forms.Label intMoraLabel;
        private System.Windows.Forms.NumericUpDown sueldoAnterior;
        private System.Windows.Forms.Label sueldoALabel;
        private System.Windows.Forms.NumericUpDown sueldoActual;
        private System.Windows.Forms.Label sueldoActualLabel;
        public System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.Label mesNoLabel;
        public System.Windows.Forms.NumericUpDown monthsLeft;
        private System.Windows.Forms.Label mesLeftLabel;
        private System.Windows.Forms.Button amortizarBtn;
    }
}