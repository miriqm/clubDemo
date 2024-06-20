namespace Club_Demo
{
    partial class frmPago
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
            this.cmbTipoCuota = new System.Windows.Forms.ComboBox();
            this.lblTipoCuota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnPago = new System.Windows.Forms.Button();
            this.txtIdPers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelPago = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipoCuota
            // 
            this.cmbTipoCuota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCuota.FormattingEnabled = true;
            this.cmbTipoCuota.Items.AddRange(new object[] {
            "Mensual",
            "Diaria"});
            this.cmbTipoCuota.Location = new System.Drawing.Point(132, 166);
            this.cmbTipoCuota.Name = "cmbTipoCuota";
            this.cmbTipoCuota.Size = new System.Drawing.Size(85, 26);
            this.cmbTipoCuota.TabIndex = 0;
            // 
            // lblTipoCuota
            // 
            this.lblTipoCuota.AutoSize = true;
            this.lblTipoCuota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCuota.Location = new System.Drawing.Point(42, 169);
            this.lblTipoCuota.Name = "lblTipoCuota";
            this.lblTipoCuota.Size = new System.Drawing.Size(84, 18);
            this.lblTipoCuota.TabIndex = 1;
            this.lblTipoCuota.Text = "Tipo Cuota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(135, 240);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(82, 26);
            this.txtMonto.TabIndex = 3;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(78, 332);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(169, 43);
            this.btnPago.TabIndex = 4;
            this.btnPago.Text = "Realizar Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // txtIdPers
            // 
            this.txtIdPers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPers.Location = new System.Drawing.Point(132, 84);
            this.txtIdPers.Name = "txtIdPers";
            this.txtIdPers.Size = new System.Drawing.Size(82, 26);
            this.txtIdPers.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "IdPers";
            // 
            // btnCancelPago
            // 
            this.btnCancelPago.Location = new System.Drawing.Point(317, 332);
            this.btnCancelPago.Name = "btnCancelPago";
            this.btnCancelPago.Size = new System.Drawing.Size(169, 43);
            this.btnCancelPago.TabIndex = 7;
            this.btnCancelPago.Text = "Cancelar";
            this.btnCancelPago.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnVolver.Location = new System.Drawing.Point(692, 21);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 29);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPers);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoCuota);
            this.Controls.Add(this.cmbTipoCuota);
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoCuota;
        private System.Windows.Forms.Label lblTipoCuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.TextBox txtIdPers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelPago;
        private System.Windows.Forms.Button btnVolver;
    }
}