namespace Semana_4.trabajo_en_clase
{
    partial class Tarea
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnMostrarDia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(89, 38);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 0;
            // 
            // btnMostrarDia
            // 
            this.btnMostrarDia.Location = new System.Drawing.Point(25, 77);
            this.btnMostrarDia.Name = "btnMostrarDia";
            this.btnMostrarDia.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarDia.TabIndex = 1;
            this.btnMostrarDia.Text = "Mostrar Día";
            this.btnMostrarDia.UseVisualStyleBackColor = true;
            this.btnMostrarDia.Click += new System.EventHandler(this.btnMostrarDia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(173, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 148);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDia);
            this.Controls.Add(this.txtDia);
            this.Name = "Tarea";
            this.Text = "Tarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button btnMostrarDia;
        private System.Windows.Forms.Button btnSalir;
    }
}