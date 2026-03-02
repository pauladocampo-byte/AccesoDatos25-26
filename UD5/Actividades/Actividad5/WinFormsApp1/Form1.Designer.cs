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
            tbPrecio = new TextBox();
            tbStock = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btvisualizar = new Button();
            tabPageStock = new TabPage();
            tabPagePanaderia = new TabPage();
            tabPageProductos = new TabPage();
            btGuardar = new Button();
            tbNombre = new TextBox();
            label1 = new Label();
            dgvProductos = new DataGridView();
            tabGestion = new TabControl();
            lblNombrePanaderia = new Label();
            txtNombrePanaderia = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnGuardarPanaderia = new Button();
            dgvPanaderias = new DataGridView();
            lblPanaderia = new Label();
            cmbPanaderia = new ComboBox();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblPrecioRelacion = new Label();
            txtPrecioRelacion = new TextBox();
            lblStockRelacion = new Label();
            txtStockRelacion = new TextBox();
            btnAsociar = new Button();
            dgvRelaciones = new DataGridView();
            tabPageStock.SuspendLayout();
            tabPagePanaderia.SuspendLayout();
            tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanaderias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelaciones).BeginInit();
            SuspendLayout();
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
            // tabPageStock
            // 
            tabPageStock.Controls.Add(lblPanaderia);
            tabPageStock.Controls.Add(cmbPanaderia);
            tabPageStock.Controls.Add(lblProducto);
            tabPageStock.Controls.Add(cmbProducto);
            tabPageStock.Controls.Add(lblPrecioRelacion);
            tabPageStock.Controls.Add(txtPrecioRelacion);
            tabPageStock.Controls.Add(lblStockRelacion);
            tabPageStock.Controls.Add(txtStockRelacion);
            tabPageStock.Controls.Add(btnAsociar);
            tabPageStock.Controls.Add(dgvRelaciones);
            tabPageStock.Location = new Point(4, 34);
            tabPageStock.Name = "tabPageStock";
            tabPageStock.Size = new Size(1314, 636);
            tabPageStock.TabIndex = 2;
            tabPageStock.Text = "Stock";
            tabPageStock.UseVisualStyleBackColor = true;
            // 
            // tabPagePanaderia
            // 
            tabPagePanaderia.Controls.Add(lblNombrePanaderia);
            tabPagePanaderia.Controls.Add(txtNombrePanaderia);
            tabPagePanaderia.Controls.Add(lblDireccion);
            tabPagePanaderia.Controls.Add(txtDireccion);
            tabPagePanaderia.Controls.Add(lblTelefono);
            tabPagePanaderia.Controls.Add(txtTelefono);
            tabPagePanaderia.Controls.Add(btnGuardarPanaderia);
            tabPagePanaderia.Controls.Add(dgvPanaderias);
            tabPagePanaderia.Location = new Point(4, 34);
            tabPagePanaderia.Name = "tabPagePanaderia";
            tabPagePanaderia.Padding = new Padding(3);
            tabPagePanaderia.Size = new Size(1314, 636);
            tabPagePanaderia.TabIndex = 1;
            tabPagePanaderia.Text = "Panaderia";
            tabPagePanaderia.UseVisualStyleBackColor = true;
            // 
            // tabPageProductos
            // 
            tabPageProductos.Controls.Add(dgvProductos);
            tabPageProductos.Controls.Add(label1);
            tabPageProductos.Controls.Add(tbNombre);
            tabPageProductos.Controls.Add(btGuardar);
            tabPageProductos.Location = new Point(4, 34);
            tabPageProductos.Name = "tabPageProductos";
            tabPageProductos.Padding = new Padding(3);
            tabPageProductos.Size = new Size(1314, 636);
            tabPageProductos.TabIndex = 0;
            tabPageProductos.Text = "Productos";
            tabPageProductos.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(27, 92);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(112, 34);
            btGuardar.TabIndex = 9;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(111, 16);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(150, 31);
            tbNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(486, 16);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(790, 614);
            dgvProductos.TabIndex = 7;
            // 
            // tabGestion
            // 
            tabGestion.Controls.Add(tabPageProductos);
            tabGestion.Controls.Add(tabPagePanaderia);
            tabGestion.Controls.Add(tabPageStock);
            tabGestion.Location = new Point(37, 48);
            tabGestion.Name = "tabGestion";
            tabGestion.SelectedIndex = 0;
            tabGestion.Size = new Size(1322, 674);
            tabGestion.TabIndex = 15;
            // 
            // lblNombrePanaderia
            // 
            lblNombrePanaderia.AutoSize = true;
            lblNombrePanaderia.Location = new Point(126, 31);
            lblNombrePanaderia.Margin = new Padding(4, 0, 4, 0);
            lblNombrePanaderia.Name = "lblNombrePanaderia";
            lblNombrePanaderia.Size = new Size(82, 25);
            lblNombrePanaderia.TabIndex = 8;
            lblNombrePanaderia.Text = "Nombre:";
            // 
            // txtNombrePanaderia
            // 
            txtNombrePanaderia.Location = new Point(226, 27);
            txtNombrePanaderia.Margin = new Padding(4);
            txtNombrePanaderia.Name = "txtNombrePanaderia";
            txtNombrePanaderia.Size = new Size(224, 31);
            txtNombrePanaderia.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(126, 81);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 25);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(226, 77);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(224, 31);
            txtDireccion.TabIndex = 11;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(126, 131);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(226, 127);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(224, 31);
            txtTelefono.TabIndex = 13;
            // 
            // btnGuardarPanaderia
            // 
            btnGuardarPanaderia.Location = new Point(226, 181);
            btnGuardarPanaderia.Margin = new Padding(4);
            btnGuardarPanaderia.Name = "btnGuardarPanaderia";
            btnGuardarPanaderia.Size = new Size(225, 44);
            btnGuardarPanaderia.TabIndex = 14;
            btnGuardarPanaderia.Text = "Guardar Panadería";
            btnGuardarPanaderia.UseVisualStyleBackColor = true;
            // 
            // dgvPanaderias
            // 
            dgvPanaderias.AllowUserToAddRows = false;
            dgvPanaderias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPanaderias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanaderias.Location = new Point(501, 18);
            dgvPanaderias.Margin = new Padding(4);
            dgvPanaderias.Name = "dgvPanaderias";
            dgvPanaderias.ReadOnly = true;
            dgvPanaderias.RowHeadersWidth = 51;
            dgvPanaderias.Size = new Size(688, 600);
            dgvPanaderias.TabIndex = 15;
            // 
            // lblPanaderia
            // 
            lblPanaderia.AutoSize = true;
            lblPanaderia.Location = new Point(126, 31);
            lblPanaderia.Margin = new Padding(4, 0, 4, 0);
            lblPanaderia.Name = "lblPanaderia";
            lblPanaderia.Size = new Size(92, 25);
            lblPanaderia.TabIndex = 10;
            lblPanaderia.Text = "Panadería:";
            // 
            // cmbPanaderia
            // 
            cmbPanaderia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPanaderia.Location = new Point(239, 27);
            cmbPanaderia.Margin = new Padding(4);
            cmbPanaderia.Name = "cmbPanaderia";
            cmbPanaderia.Size = new Size(224, 33);
            cmbPanaderia.TabIndex = 11;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(126, 81);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(89, 25);
            lblProducto.TabIndex = 12;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Location = new Point(239, 77);
            cmbProducto.Margin = new Padding(4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(224, 33);
            cmbProducto.TabIndex = 13;
            // 
            // lblPrecioRelacion
            // 
            lblPrecioRelacion.AutoSize = true;
            lblPrecioRelacion.Location = new Point(126, 131);
            lblPrecioRelacion.Margin = new Padding(4, 0, 4, 0);
            lblPrecioRelacion.Name = "lblPrecioRelacion";
            lblPrecioRelacion.Size = new Size(64, 25);
            lblPrecioRelacion.TabIndex = 14;
            lblPrecioRelacion.Text = "Precio:";
            // 
            // txtPrecioRelacion
            // 
            txtPrecioRelacion.Location = new Point(239, 127);
            txtPrecioRelacion.Margin = new Padding(4);
            txtPrecioRelacion.Name = "txtPrecioRelacion";
            txtPrecioRelacion.Size = new Size(224, 31);
            txtPrecioRelacion.TabIndex = 15;
            // 
            // lblStockRelacion
            // 
            lblStockRelacion.AutoSize = true;
            lblStockRelacion.Location = new Point(126, 181);
            lblStockRelacion.Margin = new Padding(4, 0, 4, 0);
            lblStockRelacion.Name = "lblStockRelacion";
            lblStockRelacion.Size = new Size(59, 25);
            lblStockRelacion.TabIndex = 16;
            lblStockRelacion.Text = "Stock:";
            // 
            // txtStockRelacion
            // 
            txtStockRelacion.Location = new Point(239, 177);
            txtStockRelacion.Margin = new Padding(4);
            txtStockRelacion.Name = "txtStockRelacion";
            txtStockRelacion.Size = new Size(224, 31);
            txtStockRelacion.TabIndex = 17;
            // 
            // btnAsociar
            // 
            btnAsociar.Location = new Point(239, 231);
            btnAsociar.Margin = new Padding(4);
            btnAsociar.Name = "btnAsociar";
            btnAsociar.Size = new Size(225, 44);
            btnAsociar.TabIndex = 18;
            btnAsociar.Text = "Asociar";
            btnAsociar.UseVisualStyleBackColor = true;
            // 
            // dgvRelaciones
            // 
            dgvRelaciones.AllowUserToAddRows = false;
            dgvRelaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelaciones.Location = new Point(501, 18);
            dgvRelaciones.Margin = new Padding(4);
            dgvRelaciones.Name = "dgvRelaciones";
            dgvRelaciones.ReadOnly = true;
            dgvRelaciones.RowHeadersWidth = 51;
            dgvRelaciones.Size = new Size(688, 600);
            dgvRelaciones.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 978);
            Controls.Add(tabGestion);
            Controls.Add(btvisualizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbStock);
            Controls.Add(tbPrecio);
            Name = "Form1";
            Text = "Form1";
            tabPageStock.ResumeLayout(false);
            tabPageStock.PerformLayout();
            tabPagePanaderia.ResumeLayout(false);
            tabPagePanaderia.PerformLayout();
            tabPageProductos.ResumeLayout(false);
            tabPageProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabGestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPanaderias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbPrecio;
        private TextBox tbStock;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btvisualizar;
        private TabPage tabPageStock;
        private Label lblPanaderia;
        private ComboBox cmbPanaderia;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblPrecioRelacion;
        private TextBox txtPrecioRelacion;
        private Label lblStockRelacion;
        private TextBox txtStockRelacion;
        private Button btnAsociar;
        private DataGridView dgvRelaciones;
        private TabPage tabPagePanaderia;
        private Label lblNombrePanaderia;
        private TextBox txtNombrePanaderia;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnGuardarPanaderia;
        private DataGridView dgvPanaderias;
        private TabPage tabPageProductos;
        private DataGridView dgvProductos;
        private Label label1;
        private TextBox tbNombre;
        private Button btGuardar;
        private TabControl tabGestion;
    }
}
