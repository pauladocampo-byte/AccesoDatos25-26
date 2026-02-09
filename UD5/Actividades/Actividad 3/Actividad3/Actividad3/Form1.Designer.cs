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
            dgvProductos = new DataGridView();
            btGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombre = new TextBox();
            tbPrecio = new TextBox();
            tbStock = new TextBox();
            btVisualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(412, 25);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(602, 397);
            dgvProductos.TabIndex = 0;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(138, 287);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(112, 34);
            btGuardar.TabIndex = 1;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 85);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 140);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 3;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 201);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 4;
            label3.Text = "Stock";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(128, 70);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(150, 31);
            tbNombre.TabIndex = 5;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(128, 134);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(150, 31);
            tbPrecio.TabIndex = 6;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(128, 201);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(150, 31);
            tbStock.TabIndex = 7;
            // 
            // btVisualizar
            // 
            btVisualizar.Location = new Point(647, 454);
            btVisualizar.Name = "btVisualizar";
            btVisualizar.Size = new Size(112, 34);
            btVisualizar.TabIndex = 8;
            btVisualizar.Text = "Visualizar";
            btVisualizar.UseVisualStyleBackColor = true;
            btVisualizar.Click += btVisualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 500);
            Controls.Add(btVisualizar);
            Controls.Add(tbStock);
            Controls.Add(tbPrecio);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btGuardar);
            Controls.Add(dgvProductos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNombre;
        private TextBox tbPrecio;
        private TextBox tbStock;
        private Button btVisualizar;
    }
}
