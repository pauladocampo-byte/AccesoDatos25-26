namespace Actividad6.UI
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
            tabControl = new TabControl();
            tabProductos = new TabPage();
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            btnGuardarProducto = new Button();
            dgvProductos = new DataGridView();
            tabPanaderias = new TabPage();
            lblNombrePanaderia = new Label();
            txtNombrePanaderia = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnGuardarPanaderia = new Button();
            dgvPanaderias = new DataGridView();
            tabRelaciones = new TabPage();
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
            tabControl.SuspendLayout();
            tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabPanaderias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanaderias).BeginInit();
            tabRelaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelaciones).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabProductos);
            tabControl.Controls.Add(tabPanaderias);
            tabControl.Controls.Add(tabRelaciones);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1121, 748);
            tabControl.TabIndex = 1;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(lblNombreProducto);
            tabProductos.Controls.Add(txtNombreProducto);
            tabProductos.Controls.Add(btnGuardarProducto);
            tabProductos.Controls.Add(dgvProductos);
            tabProductos.Location = new Point(4, 34);
            tabProductos.Margin = new Padding(4);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(12);
            tabProductos.Size = new Size(1113, 710);
            tabProductos.TabIndex = 0;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(37, 50);
            lblNombreProducto.Margin = new Padding(4, 0, 4, 0);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(82, 25);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(125, 34);
            txtNombreProducto.Margin = new Padding(4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(224, 31);
            txtNombreProducto.TabIndex = 1;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(125, 88);
            btnGuardarProducto.Margin = new Padding(4);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(225, 44);
            btnGuardarProducto.TabIndex = 2;
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(400, 25);
            dgvProductos.Margin = new Padding(4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(688, 600);
            dgvProductos.TabIndex = 3;
            // 
            // tabPanaderias
            // 
            tabPanaderias.Controls.Add(lblNombrePanaderia);
            tabPanaderias.Controls.Add(txtNombrePanaderia);
            tabPanaderias.Controls.Add(lblDireccion);
            tabPanaderias.Controls.Add(txtDireccion);
            tabPanaderias.Controls.Add(lblTelefono);
            tabPanaderias.Controls.Add(txtTelefono);
            tabPanaderias.Controls.Add(btnGuardarPanaderia);
            tabPanaderias.Controls.Add(dgvPanaderias);
            tabPanaderias.Location = new Point(4, 34);
            tabPanaderias.Margin = new Padding(4);
            tabPanaderias.Name = "tabPanaderias";
            tabPanaderias.Padding = new Padding(12);
            tabPanaderias.Size = new Size(1113, 710);
            tabPanaderias.TabIndex = 1;
            tabPanaderias.Text = "Panaderías";
            tabPanaderias.UseVisualStyleBackColor = true;
            // 
            // lblNombrePanaderia
            // 
            lblNombrePanaderia.AutoSize = true;
            lblNombrePanaderia.Location = new Point(37, 50);
            lblNombrePanaderia.Margin = new Padding(4, 0, 4, 0);
            lblNombrePanaderia.Name = "lblNombrePanaderia";
            lblNombrePanaderia.Size = new Size(82, 25);
            lblNombrePanaderia.TabIndex = 0;
            lblNombrePanaderia.Text = "Nombre:";
            // 
            // txtNombrePanaderia
            // 
            txtNombrePanaderia.Location = new Point(125, 34);
            txtNombrePanaderia.Margin = new Padding(4);
            txtNombrePanaderia.Name = "txtNombrePanaderia";
            txtNombrePanaderia.Size = new Size(224, 31);
            txtNombrePanaderia.TabIndex = 1;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(37, 100);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 25);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(125, 84);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(224, 31);
            txtDireccion.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(37, 150);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(125, 134);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(224, 31);
            txtTelefono.TabIndex = 5;
            // 
            // btnGuardarPanaderia
            // 
            btnGuardarPanaderia.Location = new Point(125, 188);
            btnGuardarPanaderia.Margin = new Padding(4);
            btnGuardarPanaderia.Name = "btnGuardarPanaderia";
            btnGuardarPanaderia.Size = new Size(225, 44);
            btnGuardarPanaderia.TabIndex = 6;
            btnGuardarPanaderia.Text = "Guardar Panadería";
            btnGuardarPanaderia.UseVisualStyleBackColor = true;
            btnGuardarPanaderia.Click += btnGuardarPanaderia_Click;
            // 
            // dgvPanaderias
            // 
            dgvPanaderias.AllowUserToAddRows = false;
            dgvPanaderias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPanaderias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanaderias.Location = new Point(400, 25);
            dgvPanaderias.Margin = new Padding(4);
            dgvPanaderias.Name = "dgvPanaderias";
            dgvPanaderias.ReadOnly = true;
            dgvPanaderias.RowHeadersWidth = 51;
            dgvPanaderias.Size = new Size(688, 600);
            dgvPanaderias.TabIndex = 7;
            // 
            // tabRelaciones
            // 
            tabRelaciones.Controls.Add(lblPanaderia);
            tabRelaciones.Controls.Add(cmbPanaderia);
            tabRelaciones.Controls.Add(lblProducto);
            tabRelaciones.Controls.Add(cmbProducto);
            tabRelaciones.Controls.Add(lblPrecioRelacion);
            tabRelaciones.Controls.Add(txtPrecioRelacion);
            tabRelaciones.Controls.Add(lblStockRelacion);
            tabRelaciones.Controls.Add(txtStockRelacion);
            tabRelaciones.Controls.Add(btnAsociar);
            tabRelaciones.Controls.Add(dgvRelaciones);
            tabRelaciones.Location = new Point(4, 34);
            tabRelaciones.Margin = new Padding(4);
            tabRelaciones.Name = "tabRelaciones";
            tabRelaciones.Padding = new Padding(12);
            tabRelaciones.Size = new Size(1113, 710);
            tabRelaciones.TabIndex = 2;
            tabRelaciones.Text = "Relaciones";
            tabRelaciones.UseVisualStyleBackColor = true;
            // 
            // lblPanaderia
            // 
            lblPanaderia.AutoSize = true;
            lblPanaderia.Location = new Point(37, 50);
            lblPanaderia.Margin = new Padding(4, 0, 4, 0);
            lblPanaderia.Name = "lblPanaderia";
            lblPanaderia.Size = new Size(92, 25);
            lblPanaderia.TabIndex = 0;
            lblPanaderia.Text = "Panadería:";
            // 
            // cmbPanaderia
            // 
            cmbPanaderia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPanaderia.Location = new Point(138, 34);
            cmbPanaderia.Margin = new Padding(4);
            cmbPanaderia.Name = "cmbPanaderia";
            cmbPanaderia.Size = new Size(224, 33);
            cmbPanaderia.TabIndex = 1;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(37, 100);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(89, 25);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Location = new Point(138, 84);
            cmbProducto.Margin = new Padding(4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(224, 33);
            cmbProducto.TabIndex = 3;
            // 
            // lblPrecioRelacion
            // 
            lblPrecioRelacion.AutoSize = true;
            lblPrecioRelacion.Location = new Point(37, 150);
            lblPrecioRelacion.Margin = new Padding(4, 0, 4, 0);
            lblPrecioRelacion.Name = "lblPrecioRelacion";
            lblPrecioRelacion.Size = new Size(64, 25);
            lblPrecioRelacion.TabIndex = 4;
            lblPrecioRelacion.Text = "Precio:";
            // 
            // txtPrecioRelacion
            // 
            txtPrecioRelacion.Location = new Point(138, 134);
            txtPrecioRelacion.Margin = new Padding(4);
            txtPrecioRelacion.Name = "txtPrecioRelacion";
            txtPrecioRelacion.Size = new Size(224, 31);
            txtPrecioRelacion.TabIndex = 5;
            // 
            // lblStockRelacion
            // 
            lblStockRelacion.AutoSize = true;
            lblStockRelacion.Location = new Point(37, 200);
            lblStockRelacion.Margin = new Padding(4, 0, 4, 0);
            lblStockRelacion.Name = "lblStockRelacion";
            lblStockRelacion.Size = new Size(59, 25);
            lblStockRelacion.TabIndex = 6;
            lblStockRelacion.Text = "Stock:";
            // 
            // txtStockRelacion
            // 
            txtStockRelacion.Location = new Point(138, 184);
            txtStockRelacion.Margin = new Padding(4);
            txtStockRelacion.Name = "txtStockRelacion";
            txtStockRelacion.Size = new Size(224, 31);
            txtStockRelacion.TabIndex = 7;
            // 
            // btnAsociar
            // 
            btnAsociar.Location = new Point(138, 238);
            btnAsociar.Margin = new Padding(4);
            btnAsociar.Name = "btnAsociar";
            btnAsociar.Size = new Size(225, 44);
            btnAsociar.TabIndex = 8;
            btnAsociar.Text = "Asociar";
            btnAsociar.UseVisualStyleBackColor = true;
            btnAsociar.Click += btnAsociar_Click;
            // 
            // dgvRelaciones
            // 
            dgvRelaciones.AllowUserToAddRows = false;
            dgvRelaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelaciones.Location = new Point(400, 25);
            dgvRelaciones.Margin = new Padding(4);
            dgvRelaciones.Name = "dgvRelaciones";
            dgvRelaciones.ReadOnly = true;
            dgvRelaciones.RowHeadersWidth = 51;
            dgvRelaciones.Size = new Size(688, 600);
            dgvRelaciones.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 748);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabProductos.ResumeLayout(false);
            tabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabPanaderias.ResumeLayout(false);
            tabPanaderias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanaderias).EndInit();
            tabRelaciones.ResumeLayout(false);
            tabRelaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabProductos;
        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private Button btnGuardarProducto;
        private DataGridView dgvProductos;
        private TabPage tabPanaderias;
        private Label lblNombrePanaderia;
        private TextBox txtNombrePanaderia;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnGuardarPanaderia;
        private DataGridView dgvPanaderias;
        private TabPage tabRelaciones;
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
    }
}
