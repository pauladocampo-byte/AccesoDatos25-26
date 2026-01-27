namespace Actividad3
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
            lbEquipos = new ListBox();
            label1 = new Label();
            lbFutbolistas = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbEquipos
            // 
            lbEquipos.FormattingEnabled = true;
            lbEquipos.ItemHeight = 25;
            lbEquipos.Location = new Point(58, 142);
            lbEquipos.Name = "lbEquipos";
            lbEquipos.Size = new Size(248, 304);
            lbEquipos.TabIndex = 0;
            lbEquipos.DoubleClick += lbEquipos_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 96);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 1;
            label1.Text = "Equipos";
            // 
            // lbFutbolistas
            // 
            lbFutbolistas.FormattingEnabled = true;
            lbFutbolistas.ItemHeight = 25;
            lbFutbolistas.Location = new Point(354, 142);
            lbFutbolistas.Name = "lbFutbolistas";
            lbFutbolistas.Size = new Size(248, 304);
            lbFutbolistas.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 96);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 3;
            label2.Text = "Futbolistas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 795);
            Controls.Add(label2);
            Controls.Add(lbFutbolistas);
            Controls.Add(label1);
            Controls.Add(lbEquipos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbEquipos;
        private Label label1;
        private ListBox lbFutbolistas;
        private Label label2;
    }
}
