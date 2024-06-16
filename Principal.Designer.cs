namespace Club_Demo
{
    partial class Principal
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
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInscribir
            // 
            this.btnInscribir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnInscribir.Location = new System.Drawing.Point(120, 93);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(194, 71);
            this.btnInscribir.TabIndex = 0;
            this.btnInscribir.Text = "Inscribir Postulante";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPagar.Location = new System.Drawing.Point(120, 251);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(194, 71);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Pagar Cuota";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnSocios
            // 
            this.btnSocios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocios.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSocios.Location = new System.Drawing.Point(466, 93);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(194, 71);
            this.btnSocios.TabIndex = 2;
            this.btnSocios.Text = "Socios";
            this.btnSocios.UseVisualStyleBackColor = true;
            // 
            // btnListado
            // 
            this.btnListado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnListado.Location = new System.Drawing.Point(466, 251);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(194, 71);
            this.btnListado.TabIndex = 3;
            this.btnListado.Text = "Emitir Listado Socios";
            this.btnListado.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Location = new System.Drawing.Point(692, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 29);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(12, 12);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(0, 13);
            this.lblIngreso.TabIndex = 5;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnSocios);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnInscribir);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblIngreso;
    }
}