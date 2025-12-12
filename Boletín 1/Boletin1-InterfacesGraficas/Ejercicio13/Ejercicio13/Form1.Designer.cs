namespace Ejercicio13
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
            this.lstCarpetas = new System.Windows.Forms.ListBox();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.txtInfoFicheroCarpeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstCarpetas
            // 
            this.lstCarpetas.FormattingEnabled = true;
            this.lstCarpetas.ItemHeight = 20;
            this.lstCarpetas.Location = new System.Drawing.Point(62, 61);
            this.lstCarpetas.Name = "lstCarpetas";
            this.lstCarpetas.Size = new System.Drawing.Size(412, 404);
            this.lstCarpetas.TabIndex = 0;
            this.lstCarpetas.DoubleClick += new System.EventHandler(this.lstCarpetas_DoubleClick);
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.ItemHeight = 20;
            this.lstArchivos.Location = new System.Drawing.Point(601, 61);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(471, 404);
            this.lstArchivos.TabIndex = 1;
            this.lstArchivos.DoubleClick += new System.EventHandler(this.lstArchivos_DoubleClick);
            // 
            // txtInfoFicheroCarpeta
            // 
            this.txtInfoFicheroCarpeta.Location = new System.Drawing.Point(62, 500);
            this.txtInfoFicheroCarpeta.Multiline = true;
            this.txtInfoFicheroCarpeta.Name = "txtInfoFicheroCarpeta";
            this.txtInfoFicheroCarpeta.Size = new System.Drawing.Size(1010, 152);
            this.txtInfoFicheroCarpeta.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 688);
            this.Controls.Add(this.txtInfoFicheroCarpeta);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.lstCarpetas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstCarpetas;
        private ListBox lstArchivos;
        private TextBox txtInfoFicheroCarpeta;
    }
}