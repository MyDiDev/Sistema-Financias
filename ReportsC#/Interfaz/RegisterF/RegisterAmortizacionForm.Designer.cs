namespace ReportsC_.Interfaz.RegisterF
{
    partial class RegisterAmortizacionForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.clientEmail = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mora = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.NumericUpDown();
            this.intMora = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.sueldoAnterior = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.sueldoActual = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.monthsLeft = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(552, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Correo del cliente:";
            // 
            // clientEmail
            // 
            this.clientEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.clientEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientEmail.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.clientEmail.Location = new System.Drawing.Point(556, 179);
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(293, 20);
            this.clientEmail.TabIndex = 23;
            this.clientEmail.TextChanged += new System.EventHandler(this.clientEmail_TextChanged);
            // 
            // clientName
            // 
            this.clientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientName.AutoSize = true;
            this.clientName.BackColor = System.Drawing.Color.Transparent;
            this.clientName.Font = new System.Drawing.Font("Segoe UI Variable Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientName.Location = new System.Drawing.Point(105, 28);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(529, 57);
            this.clientName.TabIndex = 22;
            this.clientName.Text = "Amortizacion Del Cliente";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(120, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Deposito:";
            // 
            // mora
            // 
            this.mora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.mora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mora.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mora.ForeColor = System.Drawing.SystemColors.Window;
            this.mora.Location = new System.Drawing.Point(124, 280);
            this.mora.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.mora.Name = "mora";
            this.mora.ReadOnly = true;
            this.mora.Size = new System.Drawing.Size(293, 23);
            this.mora.TabIndex = 28;
            this.mora.ThousandsSeparator = true;
            this.mora.ValueChanged += new System.EventHandler(this.mora_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(120, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mora:";
            // 
            // deposit
            // 
            this.deposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.deposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deposit.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.SystemColors.Window;
            this.deposit.Location = new System.Drawing.Point(124, 180);
            this.deposit.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.deposit.Name = "deposit";
            this.deposit.ReadOnly = true;
            this.deposit.Size = new System.Drawing.Size(293, 23);
            this.deposit.TabIndex = 29;
            this.deposit.ThousandsSeparator = true;
            // 
            // intMora
            // 
            this.intMora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.intMora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.intMora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intMora.Enabled = false;
            this.intMora.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intMora.ForeColor = System.Drawing.SystemColors.Window;
            this.intMora.Location = new System.Drawing.Point(556, 280);
            this.intMora.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.intMora.Name = "intMora";
            this.intMora.ReadOnly = true;
            this.intMora.Size = new System.Drawing.Size(293, 23);
            this.intMora.TabIndex = 31;
            this.intMora.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(552, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Interes Mora:";
            // 
            // sueldoAnterior
            // 
            this.sueldoAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sueldoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.sueldoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sueldoAnterior.Enabled = false;
            this.sueldoAnterior.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoAnterior.ForeColor = System.Drawing.SystemColors.Window;
            this.sueldoAnterior.Location = new System.Drawing.Point(124, 384);
            this.sueldoAnterior.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.sueldoAnterior.Name = "sueldoAnterior";
            this.sueldoAnterior.ReadOnly = true;
            this.sueldoAnterior.Size = new System.Drawing.Size(293, 23);
            this.sueldoAnterior.TabIndex = 33;
            this.sueldoAnterior.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(120, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Sueldo Anterior:";
            // 
            // sueldoActual
            // 
            this.sueldoActual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sueldoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.sueldoActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sueldoActual.Enabled = false;
            this.sueldoActual.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoActual.ForeColor = System.Drawing.SystemColors.Window;
            this.sueldoActual.Location = new System.Drawing.Point(556, 384);
            this.sueldoActual.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.sueldoActual.Name = "sueldoActual";
            this.sueldoActual.ReadOnly = true;
            this.sueldoActual.Size = new System.Drawing.Size(293, 23);
            this.sueldoActual.TabIndex = 35;
            this.sueldoActual.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(552, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Sueldo Actual:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(5)))), ((int)(((byte)(209)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(116, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(733, 52);
            this.button1.TabIndex = 36;
            this.button1.Text = "Calcular Amortizaciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // month
            // 
            this.month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.month.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.ForeColor = System.Drawing.SystemColors.Window;
            this.month.Location = new System.Drawing.Point(124, 495);
            this.month.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Size = new System.Drawing.Size(293, 23);
            this.month.TabIndex = 38;
            this.month.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(120, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mes que no Pago:";
            // 
            // monthsLeft
            // 
            this.monthsLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthsLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.monthsLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monthsLeft.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.monthsLeft.Location = new System.Drawing.Point(556, 495);
            this.monthsLeft.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.monthsLeft.Name = "monthsLeft";
            this.monthsLeft.ReadOnly = true;
            this.monthsLeft.Size = new System.Drawing.Size(293, 23);
            this.monthsLeft.TabIndex = 40;
            this.monthsLeft.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(552, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Meses Restantes:";
            // 
            // RegisterAmortizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(961, 641);
            this.Controls.Add(this.monthsLeft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sueldoActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sueldoAnterior);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.intMora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.mora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientEmail);
            this.Controls.Add(this.clientName);
            this.Name = "RegisterAmortizacionForm";
            this.Text = "RegisterAmortizacionForm";
            this.Load += new System.EventHandler(this.RegisterAmortizacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown intMora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sueldoAnterior;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sueldoActual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox clientEmail;
        public System.Windows.Forms.NumericUpDown deposit;
        public System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown monthsLeft;
        private System.Windows.Forms.Label label8;
    }
}