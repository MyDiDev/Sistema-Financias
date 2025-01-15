namespace ReportsC_.Interfaz.Login
{
    partial class RegisterForm
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
            this.warranty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.salaryClient = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.direcClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.TextBox();
            this.errMsg = new System.Windows.Forms.LinkLabel();
            this.title = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaryClient)).BeginInit();
            this.SuspendLayout();
            // 
            // warranty
            // 
            this.warranty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.warranty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warranty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warranty.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F);
            this.warranty.ForeColor = System.Drawing.Color.White;
            this.warranty.FormattingEnabled = true;
            this.warranty.Items.AddRange(new object[] {
            "Garantía de fábrica (auto)",
            "Garantía extendida (auto)",
            "Garantía de reparación (auto)",
            "Garantía de constructor (casa)",
            "Garantía hipotecaria (casa)",
            "Garantía de mantenimiento (casa)",
            "Garantía de devolución de dinero",
            "Garantía de satisfacción",
            "Garantía de reemplazo",
            "Garantía de servicio",
            "Garantía de calidad",
            "Garantía de vicios ocultos (inmuebles)",
            "Garantía de seguro",
            "Garantía bancaria (fianza)",
            "Garantía de contenido",
            "Garantía de responsabilidad civil",
            "Garantía de producto defectuoso",
            "Garantía de pago",
            "Garantía de cumplimiento",
            "Garantía de interés",
            "Garantía de calidad de servicio",
            "Garantía de fabricación",
            "Garantía de provisión",
            "Garantía de protección de datos",
            "Garantía de no competencia",
            "Garantía de mantenimiento preventivo",
            "Garantía de no uso de materiales reciclados",
            "Garantía de reparación extendida",
            "Garantía de cobertura total",
            "Garantía de desempeño",
            "Garantía de instalación",
            "Garantía de ajustabilidad",
            "Garantía de entrega puntual",
            "Garantía de originalidad",
            "Garantía de soporte técnico",
            "Garantía de actualización de software",
            "Garantía de no evasión de impuestos",
            "Garantía de rentabilidad",
            "Garantía de sustitución de partes",
            "Garantía de revisión periódica",
            "Garantía de no alteración de producto",
            "Garantía de confiabilidad"});
            this.warranty.Location = new System.Drawing.Point(511, 446);
            this.warranty.Name = "warranty";
            this.warranty.Size = new System.Drawing.Size(282, 28);
            this.warranty.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(507, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Garantia del Cliente:";
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(5)))), ((int)(((byte)(209)))));
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn.Location = new System.Drawing.Point(141, 560);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(652, 52);
            this.btn.TabIndex = 34;
            this.btn.Text = "Registrar";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // salaryClient
            // 
            this.salaryClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salaryClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.salaryClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salaryClient.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryClient.ForeColor = System.Drawing.SystemColors.Window;
            this.salaryClient.Location = new System.Drawing.Point(147, 446);
            this.salaryClient.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.salaryClient.Name = "salaryClient";
            this.salaryClient.Size = new System.Drawing.Size(282, 23);
            this.salaryClient.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(143, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Sueldo del Cliente:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(507, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Direccion del Cliente:";
            // 
            // direcClient
            // 
            this.direcClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.direcClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.direcClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direcClient.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcClient.ForeColor = System.Drawing.SystemColors.Window;
            this.direcClient.Location = new System.Drawing.Point(511, 345);
            this.direcClient.Name = "direcClient";
            this.direcClient.Size = new System.Drawing.Size(285, 20);
            this.direcClient.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(510, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Telefono del Cliente:";
            // 
            // phoneClient
            // 
            this.phoneClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.phoneClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneClient.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneClient.ForeColor = System.Drawing.SystemColors.Window;
            this.phoneClient.Location = new System.Drawing.Point(511, 250);
            this.phoneClient.Name = "phoneClient";
            this.phoneClient.Size = new System.Drawing.Size(285, 20);
            this.phoneClient.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(140, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Correo Electronico del cliente:";
            // 
            // mailClient
            // 
            this.mailClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mailClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.mailClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailClient.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailClient.ForeColor = System.Drawing.SystemColors.Window;
            this.mailClient.Location = new System.Drawing.Point(144, 345);
            this.mailClient.Name = "mailClient";
            this.mailClient.Size = new System.Drawing.Size(285, 20);
            this.mailClient.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(137, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre del cliente:";
            // 
            // nameClient
            // 
            this.nameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(127)))));
            this.nameClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameClient.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameClient.ForeColor = System.Drawing.SystemColors.Window;
            this.nameClient.Location = new System.Drawing.Point(141, 250);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(285, 20);
            this.nameClient.TabIndex = 24;
            // 
            // errMsg
            // 
            this.errMsg.LinkColor = System.Drawing.Color.Red;
            this.errMsg.Location = new System.Drawing.Point(147, 496);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(646, 36);
            this.errMsg.TabIndex = 37;
            this.errMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(100, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(433, 85);
            this.title.TabIndex = 38;
            this.title.Text = "Registrate";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(147, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "asegurate de llenar el formulario con el formato correcto";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(946, 635);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.title);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.warranty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.salaryClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direcClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mailClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel errMsg;
        public System.Windows.Forms.ComboBox warranty;
        public System.Windows.Forms.NumericUpDown salaryClient;
        public System.Windows.Forms.TextBox direcClient;
        public System.Windows.Forms.TextBox phoneClient;
        public System.Windows.Forms.TextBox mailClient;
        public System.Windows.Forms.TextBox nameClient;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btn;
    }
}