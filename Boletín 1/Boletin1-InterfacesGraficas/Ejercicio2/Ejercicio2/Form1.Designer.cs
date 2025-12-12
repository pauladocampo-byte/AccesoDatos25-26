namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFrases = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarEnFichero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutaFichero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFrases
            // 
            this.txtFrases.Location = new System.Drawing.Point(387, 123);
            this.txtFrases.Name = "txtFrases";
            this.txtFrases.Size = new System.Drawing.Size(256, 27);
            this.txtFrases.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frases que el usuario teclea";
            // 
            // btnGuardarEnFichero
            // 
            this.btnGuardarEnFichero.Location = new System.Drawing.Point(271, 192);
            this.btnGuardarEnFichero.Name = "btnGuardarEnFichero";
            this.btnGuardarEnFichero.Size = new System.Drawing.Size(200, 62);
            this.btnGuardarEnFichero.TabIndex = 2;
            this.btnGuardarEnFichero.Text = "Guardar en fichero";
            this.btnGuardarEnFichero.UseVisualStyleBackColor = true;
            this.btnGuardarEnFichero.Click += new System.EventHandler(this.btnGuardarEnFichero_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta del fichero:";
            // 
            // txtRutaFichero
            // 
            this.txtRutaFichero.Location = new System.Drawing.Point(387, 301);
            this.txtRutaFichero.Multiline = true;
            this.txtRutaFichero.Name = "txtRutaFichero";
            this.txtRutaFichero.Size = new System.Drawing.Size(256, 108);
            this.txtRutaFichero.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRutaFichero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarEnFichero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrases);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFrases;
        private Label label1;
        private Button btnGuardarEnFichero;
        private Label label2;
        private TextBox txtRutaFichero;
    }
}