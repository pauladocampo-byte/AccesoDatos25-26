namespace Actividad5.UI
{
    partial class FormGestion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabProductos = new TabPage();
            tabPanaderias = new TabPage();
            tabRelaciones = new TabPage();

            // === TAB PRODUCTOS (solo Nombre) ===
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            btnGuardarProducto = new Button();
            dgvProductos = new DataGridView();

            // === TAB PANADERÍAS ===
            lblNombrePanaderia = new Label();
            txtNombrePanaderia = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnGuardarPanaderia = new Button();
            dgvPanaderias = new DataGridView();

            // === TAB RELACIONES (aquí van Precio y Stock) ===
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

            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPanaderias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelaciones).BeginInit();
            tabControl.SuspendLayout();
            tabProductos.SuspendLayout();
            tabPanaderias.SuspendLayout();
            tabRelaciones.SuspendLayout();
            SuspendLayout();

            // ========================================
            // TAB CONTROL
            // ========================================
            tabControl.Controls.Add(tabProductos);
            tabControl.Controls.Add(tabPanaderias);
            tabControl.Controls.Add(tabRelaciones);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(900, 550);
            tabControl.TabIndex = 0;

            // ========================================
            // TAB PRODUCTOS (simplificado: solo Nombre)
            // ========================================
            tabProductos.Controls.Add(lblNombreProducto);
            tabProductos.Controls.Add(txtNombreProducto);
            tabProductos.Controls.Add(btnGuardarProducto);
            tabProductos.Controls.Add(dgvProductos);
            tabProductos.Location = new Point(4, 29);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(10);
            tabProductos.Size = new Size(892, 517);
            tabProductos.TabIndex = 0;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;

            // Nombre Producto
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(20, 30);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(70, 20);
            lblNombreProducto.Text = "Nombre:";

            txtNombreProducto.Location = new Point(100, 27);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(180, 27);

            // Botón Guardar Producto
            btnGuardarProducto.Location = new Point(100, 70);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(180, 35);
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;

            // DataGridView Productos
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(320, 20);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(550, 480);
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ========================================
            // TAB PANADERÍAS
            // ========================================
            tabPanaderias.Controls.Add(lblNombrePanaderia);
            tabPanaderias.Controls.Add(txtNombrePanaderia);
            tabPanaderias.Controls.Add(lblDireccion);
            tabPanaderias.Controls.Add(txtDireccion);
            tabPanaderias.Controls.Add(lblTelefono);
            tabPanaderias.Controls.Add(txtTelefono);
            tabPanaderias.Controls.Add(btnGuardarPanaderia);
            tabPanaderias.Controls.Add(dgvPanaderias);
            tabPanaderias.Location = new Point(4, 29);
            tabPanaderias.Name = "tabPanaderias";
            tabPanaderias.Padding = new Padding(10);
            tabPanaderias.Size = new Size(892, 517);
            tabPanaderias.TabIndex = 1;
            tabPanaderias.Text = "Panaderías";
            tabPanaderias.UseVisualStyleBackColor = true;

            // Nombre Panadería
            lblNombrePanaderia.AutoSize = true;
            lblNombrePanaderia.Location = new Point(20, 30);
            lblNombrePanaderia.Name = "lblNombrePanaderia";
            lblNombrePanaderia.Size = new Size(70, 20);
            lblNombrePanaderia.Text = "Nombre:";

            txtNombrePanaderia.Location = new Point(100, 27);
            txtNombrePanaderia.Name = "txtNombrePanaderia";
            txtNombrePanaderia.Size = new Size(180, 27);

            // Dirección
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(20, 70);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.Text = "Dirección:";

            txtDireccion.Location = new Point(100, 67);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(180, 27);

            // Teléfono
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(20, 110);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.Text = "Teléfono:";

            txtTelefono.Location = new Point(100, 107);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 27);

            // Botón Guardar Panadería
            btnGuardarPanaderia.Location = new Point(100, 150);
            btnGuardarPanaderia.Name = "btnGuardarPanaderia";
            btnGuardarPanaderia.Size = new Size(180, 35);
            btnGuardarPanaderia.Text = "Guardar Panadería";
            btnGuardarPanaderia.UseVisualStyleBackColor = true;
            btnGuardarPanaderia.Click += btnGuardarPanaderia_Click;

            // DataGridView Panaderías
            dgvPanaderias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanaderias.Location = new Point(320, 20);
            dgvPanaderias.Name = "dgvPanaderias";
            dgvPanaderias.RowHeadersWidth = 51;
            dgvPanaderias.Size = new Size(550, 480);
            dgvPanaderias.ReadOnly = true;
            dgvPanaderias.AllowUserToAddRows = false;
            dgvPanaderias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ========================================
            // TAB RELACIONES (Precio y Stock van aquí)
            // ========================================
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
            tabRelaciones.Location = new Point(4, 29);
            tabRelaciones.Name = "tabRelaciones";
            tabRelaciones.Padding = new Padding(10);
            tabRelaciones.Size = new Size(892, 517);
            tabRelaciones.TabIndex = 2;
            tabRelaciones.Text = "Relaciones";
            tabRelaciones.UseVisualStyleBackColor = true;

            // Panadería (combo)
            lblPanaderia.AutoSize = true;
            lblPanaderia.Location = new Point(20, 30);
            lblPanaderia.Name = "lblPanaderia";
            lblPanaderia.Size = new Size(80, 20);
            lblPanaderia.Text = "Panadería:";

            cmbPanaderia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPanaderia.Location = new Point(110, 27);
            cmbPanaderia.Name = "cmbPanaderia";
            cmbPanaderia.Size = new Size(180, 28);

            // Producto (combo)
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(20, 70);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(75, 20);
            lblProducto.Text = "Producto:";

            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Location = new Point(110, 67);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(180, 28);

            // Precio Relación
            lblPrecioRelacion.AutoSize = true;
            lblPrecioRelacion.Location = new Point(20, 110);
            lblPrecioRelacion.Name = "lblPrecioRelacion";
            lblPrecioRelacion.Size = new Size(55, 20);
            lblPrecioRelacion.Text = "Precio:";

            txtPrecioRelacion.Location = new Point(110, 107);
            txtPrecioRelacion.Name = "txtPrecioRelacion";
            txtPrecioRelacion.Size = new Size(180, 27);

            // Stock Relación
            lblStockRelacion.AutoSize = true;
            lblStockRelacion.Location = new Point(20, 150);
            lblStockRelacion.Name = "lblStockRelacion";
            lblStockRelacion.Size = new Size(50, 20);
            lblStockRelacion.Text = "Stock:";

            txtStockRelacion.Location = new Point(110, 147);
            txtStockRelacion.Name = "txtStockRelacion";
            txtStockRelacion.Size = new Size(180, 27);

            // Botón Asociar
            btnAsociar.Location = new Point(110, 190);
            btnAsociar.Name = "btnAsociar";
            btnAsociar.Size = new Size(180, 35);
            btnAsociar.Text = "Asociar";
            btnAsociar.UseVisualStyleBackColor = true;
            btnAsociar.Click += btnAsociar_Click;

            // DataGridView Relaciones
            dgvRelaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelaciones.Location = new Point(320, 20);
            dgvRelaciones.Name = "dgvRelaciones";
            dgvRelaciones.RowHeadersWidth = 51;
            dgvRelaciones.Size = new Size(550, 480);
            dgvRelaciones.ReadOnly = true;
            dgvRelaciones.AllowUserToAddRows = false;
            dgvRelaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ========================================
            // FORM
            // ========================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(tabControl);
            Name = "FormGestion";
            Text = "Gestión Panadería - Productos y Relaciones";
            StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPanaderias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelaciones).EndInit();
            tabControl.ResumeLayout(false);
            tabProductos.ResumeLayout(false);
            tabProductos.PerformLayout();
            tabPanaderias.ResumeLayout(false);
            tabPanaderias.PerformLayout();
            tabRelaciones.ResumeLayout(false);
            tabRelaciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Tab Control
        private TabControl tabControl;
        private TabPage tabProductos;
        private TabPage tabPanaderias;
        private TabPage tabRelaciones;

        // Productos (solo Nombre)
        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private Button btnGuardarProducto;
        private DataGridView dgvProductos;

        // Panaderías
        private Label lblNombrePanaderia;
        private TextBox txtNombrePanaderia;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnGuardarPanaderia;
        private DataGridView dgvPanaderias;

        // Relaciones (Precio y Stock van aquí)
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
