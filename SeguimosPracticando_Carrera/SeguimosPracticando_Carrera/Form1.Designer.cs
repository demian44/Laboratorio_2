namespace SeguimosPracticando_Carrera
{
    partial class Form1
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
            this.btnCorran = new System.Windows.Forms.Button();
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.btnAtentado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCorran
            // 
            this.btnCorran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorran.Location = new System.Drawing.Point(135, 146);
            this.btnCorran.Name = "btnCorran";
            this.btnCorran.Size = new System.Drawing.Size(501, 104);
            this.btnCorran.TabIndex = 0;
            this.btnCorran.Text = "Corran Wachos Forros!";
            this.btnCorran.UseVisualStyleBackColor = true;
            this.btnCorran.Click += new System.EventHandler(this.btnCorran_Click);
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(135, 37);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(501, 33);
            this.pgbCarril1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carril 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carril 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(135, 90);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(501, 32);
            this.pgbCarril2.TabIndex = 3;
            // 
            // btnAtentado
            // 
            this.btnAtentado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtentado.Location = new System.Drawing.Point(12, 146);
            this.btnAtentado.Name = "btnAtentado";
            this.btnAtentado.Size = new System.Drawing.Size(110, 104);
            this.btnAtentado.TabIndex = 5;
            this.btnAtentado.Text = "Atentado Taliban :v";
            this.btnAtentado.UseVisualStyleBackColor = true;
            this.btnAtentado.Click += new System.EventHandler(this.btnAtentado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 262);
            this.Controls.Add(this.btnAtentado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbCarril1);
            this.Controls.Add(this.btnCorran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCorran;
        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pgbCarril2;
        private System.Windows.Forms.Button btnAtentado;
    }
}

