namespace Actividad4
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
            button1 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            tbPrecio.Location = new Point(1040, 741);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(150, 31);
            tbPrecio.TabIndex = 1;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(1040, 819);
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
            label2.Location = new Point(939, 747);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(939, 825);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 5;
            label3.Text = "Stock";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(43, 242);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(559, 408);
            dgvProductos.TabIndex = 7;
            // 
            // btvisualizar
            // 
            btvisualizar.Location = new Point(182, 688);
            btvisualizar.Name = "btvisualizar";
            btvisualizar.Size = new Size(112, 34);
            btvisualizar.TabIndex = 8;
            btvisualizar.Text = "Visualizar";
            btvisualizar.UseVisualStyleBackColor = true;
            btvisualizar.Click += btvisualizar_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(136, 177);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(112, 34);
            btGuardar.TabIndex = 9;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(878, 177);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(924, 688);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "Visualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(785, 242);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(559, 408);
            dataGridView2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(785, 118);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 11;
            label4.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(886, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 978);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Button button1;
        private Button button2;
        private DataGridView dataGridView2;
        private Label label4;
        private TextBox textBox1;
    }
}
