namespace frmPrincipal
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
            this.listEstadoIngresado = new System.Windows.Forms.ListBox();
            this.listEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.listEstadoEntregado = new System.Windows.Forms.ListBox();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.lblEstados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listEstadoIngresado
            // 
            this.listEstadoIngresado.FormattingEnabled = true;
            this.listEstadoIngresado.Location = new System.Drawing.Point(15, 77);
            this.listEstadoIngresado.Name = "listEstadoIngresado";
            this.listEstadoIngresado.Size = new System.Drawing.Size(229, 238);
            this.listEstadoIngresado.TabIndex = 0;
            // 
            // listEstadoEnViaje
            // 
            this.listEstadoEnViaje.FormattingEnabled = true;
            this.listEstadoEnViaje.Location = new System.Drawing.Point(261, 77);
            this.listEstadoEnViaje.Name = "listEstadoEnViaje";
            this.listEstadoEnViaje.Size = new System.Drawing.Size(229, 238);
            this.listEstadoEnViaje.TabIndex = 1;
            // 
            // listEstadoEntregado
            // 
            this.listEstadoEntregado.FormattingEnabled = true;
            this.listEstadoEntregado.Location = new System.Drawing.Point(506, 77);
            this.listEstadoEntregado.Name = "listEstadoEntregado";
            this.listEstadoEntregado.Size = new System.Drawing.Size(229, 238);
            this.listEstadoEntregado.TabIndex = 2;
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(15, 50);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 3;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(258, 50);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoEnViaje.TabIndex = 4;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(512, 50);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEntregado.TabIndex = 5;
            this.lblEntregado.Text = "Entregado";
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Location = new System.Drawing.Point(7, 15);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(99, 13);
            this.lblEstados.TabIndex = 6;
            this.lblEstados.Text = "Estado del paquete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 406);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.lblEntregado);
            this.Controls.Add(this.lblEstadoEnViaje);
            this.Controls.Add(this.lblEstadoIngresado);
            this.Controls.Add(this.listEstadoEntregado);
            this.Controls.Add(this.listEstadoEnViaje);
            this.Controls.Add(this.listEstadoIngresado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listEstadoIngresado;
        private System.Windows.Forms.ListBox listEstadoEnViaje;
        private System.Windows.Forms.ListBox listEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.Label lblEstados;
    }
}

