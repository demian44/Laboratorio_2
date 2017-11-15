namespace PreParcialLabo_II
{
    partial class Form1
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(12, 20);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(364, 222);
            this.btnLanzar.TabIndex = 0;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(12, 255);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(364, 38);
            this.btnBitacora.TabIndex = 1;
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 308);
            this.Controls.Add(this.btnBitacora);
            this.Controls.Add(this.btnLanzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Button btnBitacora;
    }
}

