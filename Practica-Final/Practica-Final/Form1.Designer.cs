namespace Practica_Final
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
            this.btnMedicoEspecialista = new System.Windows.Forms.Button();
            this.btnMedicoGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedicoEspecialista
            // 
            this.btnMedicoEspecialista.Location = new System.Drawing.Point(28, 154);
            this.btnMedicoEspecialista.Name = "btnMedicoEspecialista";
            this.btnMedicoEspecialista.Size = new System.Drawing.Size(574, 88);
            this.btnMedicoEspecialista.TabIndex = 0;
            this.btnMedicoEspecialista.Text = "Atender Medico Especialista";
            this.btnMedicoEspecialista.UseVisualStyleBackColor = true;
            this.btnMedicoEspecialista.Click += new System.EventHandler(this.btnMedicoEspecialista_Click);
            // 
            // btnMedicoGeneral
            // 
            this.btnMedicoGeneral.Location = new System.Drawing.Point(28, 35);
            this.btnMedicoGeneral.Name = "btnMedicoGeneral";
            this.btnMedicoGeneral.Size = new System.Drawing.Size(574, 86);
            this.btnMedicoGeneral.TabIndex = 1;
            this.btnMedicoGeneral.Text = "Atender Medico General";
            this.btnMedicoGeneral.UseVisualStyleBackColor = true;
            this.btnMedicoGeneral.Click += new System.EventHandler(this.btnMedicoGeneral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 262);
            this.Controls.Add(this.btnMedicoGeneral);
            this.Controls.Add(this.btnMedicoEspecialista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedicoEspecialista;
        private System.Windows.Forms.Button btnMedicoGeneral;
    }
}

