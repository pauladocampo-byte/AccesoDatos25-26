namespace WinFormsApp1
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
            tbNombre = new TextBox();
            tbPrecio = new TextBox();
            tbStock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvProductos = new DataGridView();
            btvisualizar = new Button();
            btGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(144, 115);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(150, 31);
            tbNombre.TabIndex = 0;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(144, 189);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(150, 31);
            tbPrecio.TabIndex = 1;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(144, 267);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(150, 31);
            tbStock.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 118);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 195);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 273);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 5;
            label3.Text = "Stock";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(328, 24);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(559, 408);
            dgvProductos.TabIndex = 7;
            // 
            // btvisualizar
            // 
            btvisualizar.Location = new Point(537, 455);
            btvisualizar.Name = "btvisualizar";
            btvisualizar.Size = new Size(112, 34);
            btvisualizar.TabIndex = 8;
            btvisualizar.Text = "Visualizar";
            btvisualizar.UseVisualStyleBackColor = true;
            btvisualizar.Click += btvisualizar_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(136, 342);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(112, 34);
            btGuardar.TabIndex = 9;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 526);
            Controls.Add(btGuardar);
            Controls.Add(btvisualizar);
            Controls.Add(dgvProductos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbStock);
            Controls.Add(tbPrecio);
            Controls.Add(tbNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbPrecio;
        private TextBox tbStock;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btvisualizar;
        private Button btGuardar;
        private DataGridView dgvProductos;
    }
}
