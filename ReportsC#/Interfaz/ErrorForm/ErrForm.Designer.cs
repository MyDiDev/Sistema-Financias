namespace ReportsC_.Interfaz.ErrorForm
{
    partial class ErrForm_cs
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
            this.errMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errMsg
            // 
            this.errMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errMsg.AutoSize = true;
            this.errMsg.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsg.ForeColor = System.Drawing.Color.Red;
            this.errMsg.Location = new System.Drawing.Point(367, 339);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(143, 22);
            this.errMsg.TabIndex = 16;
            this.errMsg.Text = "Registrar Listados";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 85);
            this.label1.TabIndex = 15;
            this.label1.Text = "ERROR OCURRIDO :(";
            // 
            // ErrForm_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(910, 583);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.label1);
            this.Name = "ErrForm_cs";
            this.Text = "ErrForm_cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label errMsg;
    }
}