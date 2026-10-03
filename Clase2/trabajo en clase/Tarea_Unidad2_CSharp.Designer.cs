namespace Clase2.trabajo_en_clase
{
    partial class Tarea_Unidad2_CSharp
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
            this.components = new System.ComponentModel.Container();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.listBoxColores = new System.Windows.Forms.ListBox();
            this.contextMenuStripFondo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cambiarColorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogFondo = new System.Windows.Forms.ColorDialog();
            this.contextMenuStripFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(104, 44);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(104, 97);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(30, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(68, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Número uno:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(30, 100);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(67, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Número dos:";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(116, 151);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(30, 206);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(45, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Colores:";
            // 
            // listBoxColores
            // 
            this.listBoxColores.FormattingEnabled = true;
            this.listBoxColores.Location = new System.Drawing.Point(33, 234);
            this.listBoxColores.Name = "listBoxColores";
            this.listBoxColores.Size = new System.Drawing.Size(120, 95);
            this.listBoxColores.TabIndex = 6;
            this.listBoxColores.SelectedIndexChanged += new System.EventHandler(this.listBoxColores_SelectedIndexChanged);
            // 
            // contextMenuStripFondo
            // 
            this.contextMenuStripFondo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarColorDeFondoToolStripMenuItem});
            this.contextMenuStripFondo.Name = "contextMenuStripFondo";
            this.contextMenuStripFondo.Size = new System.Drawing.Size(201, 26);
            // 
            // cambiarColorDeFondoToolStripMenuItem
            // 
            this.cambiarColorDeFondoToolStripMenuItem.Name = "cambiarColorDeFondoToolStripMenuItem";
            this.cambiarColorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cambiarColorDeFondoToolStripMenuItem.Text = "Cambiar color de fondo";
            this.cambiarColorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorDeFondoToolStripMenuItem_Click);
            // 
            // Tarea_Unidad2_CSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 351);
            this.ContextMenuStrip = this.contextMenuStripFondo;
            this.Controls.Add(this.listBoxColores);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "Tarea_Unidad2_CSharp";
            this.Text = "Tarea_Unidad2_CSharp";
            this.Load += new System.EventHandler(this.Tarea_Unidad2_CSharp_Load);
            this.contextMenuStripFondo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ListBox listBoxColores;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFondo;
        private System.Windows.Forms.ToolStripMenuItem cambiarColorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogFondo;
    }
}