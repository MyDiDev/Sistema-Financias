namespace ReportsC_.Interfaz.RegisterF
{
    partial class RegisterPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPrestamos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.months = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.TextBox();
            this.interesType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errMsg = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.warrantyValue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.months)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, -106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 922);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registra un Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto del prestamo:";
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.SystemColors.Window;
            this.amount.Location = new System.Drawing.Point(38, 365);
            this.amount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(448, 23);
            this.amount.TabIndex = 14;
            // 
            // months
            // 
            this.months.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.months.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.months.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.months.ForeColor = System.Drawing.SystemColors.Window;
            this.months.Location = new System.Drawing.Point(38, 457);
            this.months.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.months.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(448, 23);
            this.months.TabIndex = 16;
            this.months.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(34, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Meses:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(5)))), ((int)(((byte)(209)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(38, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(34, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre del cliente:";
            // 
            // nameClient
            // 
            this.nameClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.nameClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameClient.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameClient.ForeColor = System.Drawing.SystemColors.Window;
            this.nameClient.Location = new System.Drawing.Point(38, 163);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(448, 20);
            this.nameClient.TabIndex = 20;
            // 
            // interesType
            // 
            this.interesType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.interesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interesType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interesType.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F);
            this.interesType.ForeColor = System.Drawing.Color.White;
            this.interesType.FormattingEnabled = true;
            this.interesType.Items.AddRange(new object[] {
            "simple",
            "compuesto"});
            this.interesType.Location = new System.Drawing.Point(38, 261);
            this.interesType.Name = "interesType";
            this.interesType.Size = new System.Drawing.Size(448, 28);
            this.interesType.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(34, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tipo de Interes:";
            // 
            // errMsg
            // 
            this.errMsg.LinkColor = System.Drawing.Color.Red;
            this.errMsg.Location = new System.Drawing.Point(35, 584);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(451, 28);
            this.errMsg.TabIndex = 24;
            this.errMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(34, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Garantia:";
            // 
            // warrantyValue
            // 
            this.warrantyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.warrantyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warrantyValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warrantyValue.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F);
            this.warrantyValue.ForeColor = System.Drawing.Color.White;
            this.warrantyValue.FormattingEnabled = true;
            this.warrantyValue.Items.AddRange(new object[] {
            "si",
            "no"});
            this.warrantyValue.Location = new System.Drawing.Point(38, 544);
            this.warrantyValue.Name = "warrantyValue";
            this.warrantyValue.Size = new System.Drawing.Size(448, 28);
            this.warrantyValue.TabIndex = 25;
            // 
            // RegisterPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(979, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.warrantyValue);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.interesType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.months);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegisterPrestamos";
            this.Text = "RegisterPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.months)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.NumericUpDown months;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameClient;
        private System.Windows.Forms.ComboBox interesType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel errMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox warrantyValue;
    }
}