namespace Ultima_practica
{
    partial class lblWachin1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCorranMierdas = new System.Windows.Forms.Button();
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCorranMierdas
            // 
            this.btnCorranMierdas.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorranMierdas.Location = new System.Drawing.Point(467, 228);
            this.btnCorranMierdas.Name = "btnCorranMierdas";
            this.btnCorranMierdas.Size = new System.Drawing.Size(95, 66);
            this.btnCorranMierdas.TabIndex = 0;
            this.btnCorranMierdas.Text = "Corran Mierdas";
            this.btnCorranMierdas.UseVisualStyleBackColor = true;
            this.btnCorranMierdas.Click += new System.EventHandler(this.btnCorranMierdas_Click);
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(104, 40);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(458, 48);
            this.pgbCarril1.TabIndex = 1;
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(104, 122);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(458, 48);
            this.pgbCarril2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wachin 1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wachin 2";
            // 
            // lblWachin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.pgbCarril1);
            this.Controls.Add(this.btnCorranMierdas);
            this.Name = "lblWachin1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lblWachin1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCorranMierdas;
        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.ProgressBar pgbCarril2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

