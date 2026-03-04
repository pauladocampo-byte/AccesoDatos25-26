namespace Actividad6.Frontend
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
            this.tabControl1 = new TabControl();
            this.tabPageProductos = new TabPage();
            this.tabPagePanaderias = new TabPage();
            this.tabPagePanaderiasProductos = new TabPage();
            
            // Productos Tab
            this.lblNombre = new Label();
            this.tbNombre = new TextBox();
            this.btGuardar = new Button();
            this.dgvProductos = new DataGridView();
            
            // Panaderias Tab
            this.lblNombrePanaderia = new Label();
            this.tbNombrePanaderia = new TextBox();
            this.lblDireccion = new Label();
            this.tbDireccion = new TextBox();
            this.lblTelefono = new Label();
            this.tbTelefono = new TextBox();
            this.btGuardarPanaderia = new Button();
            this.dgvPanaderia = new DataGridView();
            
            // PanaderiasProductos Tab
            this.lblPanaderia = new Label();
            this.cbPanaderia = new ComboBox();
            this.lblProducto = new Label();
            this.cbProducto = new ComboBox();
            this.lblStock = new Label();
            this.tbStock = new TextBox();
            this.lblPrecio = new Label();
            this.tbPrecio = new TextBox();
            this.btGuardarProductoPanaderia = new Button();
            this.dgvPanaderiaProductos = new DataGridView();

            // TabControl
            this.tabControl1.SuspendLayout();
            this.tabPageProductos.SuspendLayout();
            this.tabPagePanaderias.SuspendLayout();
            this.tabPagePanaderiasProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanaderia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanaderiaProductos)).BeginInit();
            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabPageProductos);
            this.tabControl1.Controls.Add(this.tabPagePanaderias);
            this.tabControl1.Controls.Add(this.tabPagePanaderiasProductos);
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(800, 500);
            this.tabControl1.TabIndex = 0;

            // ========== TAB PRODUCTOS ==========
            this.tabPageProductos.Text = "Productos";
            this.tabPageProductos.Padding = new Padding(10);
            
            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new Point(20, 20);
            this.lblNombre.Text = "Nombre:";
            this.tabPageProductos.Controls.Add(this.lblNombre);

            // tbNombre
            this.tbNombre.Location = new Point(100, 17);
            this.tbNombre.Size = new Size(200, 23);
            this.tabPageProductos.Controls.Add(this.tbNombre);

            // btGuardar
            this.btGuardar.Location = new Point(320, 16);
            this.btGuardar.Size = new Size(100, 25);
            this.btGuardar.Text = "Guardar";
            this.btGuardar.Click += new EventHandler(this.btGuardar_Click);
            this.tabPageProductos.Controls.Add(this.btGuardar);

            // dgvProductos
            this.dgvProductos.Location = new Point(20, 60);
            this.dgvProductos.Size = new Size(740, 380);
            this.dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.AllowUserToAddRows = false;
            this.tabPageProductos.Controls.Add(this.dgvProductos);

            // ========== TAB PANADERIAS ==========
            this.tabPagePanaderias.Text = "Panaderías";
            this.tabPagePanaderias.Padding = new Padding(10);

            // lblNombrePanaderia
            this.lblNombrePanaderia.AutoSize = true;
            this.lblNombrePanaderia.Location = new Point(20, 20);
            this.lblNombrePanaderia.Text = "Nombre:";
            this.tabPagePanaderias.Controls.Add(this.lblNombrePanaderia);

            // tbNombrePanaderia
            this.tbNombrePanaderia.Location = new Point(100, 17);
            this.tbNombrePanaderia.Size = new Size(200, 23);
            this.tabPagePanaderias.Controls.Add(this.tbNombrePanaderia);

            // lblDireccion
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new Point(320, 20);
            this.lblDireccion.Text = "Dirección:";
            this.tabPagePanaderias.Controls.Add(this.lblDireccion);

            // tbDireccion
            this.tbDireccion.Location = new Point(400, 17);
            this.tbDireccion.Size = new Size(200, 23);
            this.tabPagePanaderias.Controls.Add(this.tbDireccion);

            // lblTelefono
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new Point(20, 55);
            this.lblTelefono.Text = "Teléfono:";
            this.tabPagePanaderias.Controls.Add(this.lblTelefono);

            // tbTelefono
            this.tbTelefono.Location = new Point(100, 52);
            this.tbTelefono.Size = new Size(200, 23);
            this.tabPagePanaderias.Controls.Add(this.tbTelefono);

            // btGuardarPanaderia
            this.btGuardarPanaderia.Location = new Point(320, 51);
            this.btGuardarPanaderia.Size = new Size(100, 25);
            this.btGuardarPanaderia.Text = "Guardar";
            this.btGuardarPanaderia.Click += new EventHandler(this.btGuardarPanaderia_Click);
            this.tabPagePanaderias.Controls.Add(this.btGuardarPanaderia);

            // dgvPanaderia
            this.dgvPanaderia.Location = new Point(20, 95);
            this.dgvPanaderia.Size = new Size(740, 345);
            this.dgvPanaderia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPanaderia.ReadOnly = true;
            this.dgvPanaderia.AllowUserToAddRows = false;
            this.tabPagePanaderias.Controls.Add(this.dgvPanaderia);

            // ========== TAB PANADERIAS-PRODUCTOS ==========
            this.tabPagePanaderiasProductos.Text = "Panaderías-Productos";
            this.tabPagePanaderiasProductos.Padding = new Padding(10);

            // lblPanaderia
            this.lblPanaderia.AutoSize = true;
            this.lblPanaderia.Location = new Point(20, 20);
            this.lblPanaderia.Text = "Panadería:";
            this.tabPagePanaderiasProductos.Controls.Add(this.lblPanaderia);

            // cbPanaderia
            this.cbPanaderia.Location = new Point(100, 17);
            this.cbPanaderia.Size = new Size(200, 23);
            this.cbPanaderia.DropDownStyle = ComboBoxStyle.DropDownList;
            this.tabPagePanaderiasProductos.Controls.Add(this.cbPanaderia);

            // lblProducto
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new Point(320, 20);
            this.lblProducto.Text = "Producto:";
            this.tabPagePanaderiasProductos.Controls.Add(this.lblProducto);

            // cbProducto
            this.cbProducto.Location = new Point(400, 17);
            this.cbProducto.Size = new Size(200, 23);
            this.cbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.tabPagePanaderiasProductos.Controls.Add(this.cbProducto);

            // lblStock
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new Point(20, 55);
            this.lblStock.Text = "Stock:";
            this.tabPagePanaderiasProductos.Controls.Add(this.lblStock);

            // tbStock
            this.tbStock.Location = new Point(100, 52);
            this.tbStock.Size = new Size(100, 23);
            this.tabPagePanaderiasProductos.Controls.Add(this.tbStock);

            // lblPrecio
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new Point(220, 55);
            this.lblPrecio.Text = "Precio:";
            this.tabPagePanaderiasProductos.Controls.Add(this.lblPrecio);

            // tbPrecio
            this.tbPrecio.Location = new Point(280, 52);
            this.tbPrecio.Size = new Size(100, 23);
            this.tabPagePanaderiasProductos.Controls.Add(this.tbPrecio);

            // btGuardarProductoPanaderia
            this.btGuardarProductoPanaderia.Location = new Point(400, 51);
            this.btGuardarProductoPanaderia.Size = new Size(100, 25);
            this.btGuardarProductoPanaderia.Text = "Guardar";
            this.btGuardarProductoPanaderia.Click += new EventHandler(this.btGuardarProductoPanaderia_Click);
            this.tabPagePanaderiasProductos.Controls.Add(this.btGuardarProductoPanaderia);

            // dgvPanaderiaProductos
            this.dgvPanaderiaProductos.Location = new Point(20, 95);
            this.dgvPanaderiaProductos.Size = new Size(740, 345);
            this.dgvPanaderiaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPanaderiaProductos.ReadOnly = true;
            this.dgvPanaderiaProductos.AllowUserToAddRows = false;
            this.tabPagePanaderiasProductos.Controls.Add(this.dgvPanaderiaProductos);

            // Form1
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestión de Panadería - API Client";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.tabControl1.ResumeLayout(false);
            this.tabPageProductos.ResumeLayout(false);
            this.tabPageProductos.PerformLayout();
            this.tabPagePanaderias.ResumeLayout(false);
            this.tabPagePanaderias.PerformLayout();
            this.tabPagePanaderiasProductos.ResumeLayout(false);
            this.tabPagePanaderiasProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanaderia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanaderiaProductos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageProductos;
        private TabPage tabPagePanaderias;
        private TabPage tabPagePanaderiasProductos;
        
        // Productos
        private Label lblNombre;
        private TextBox tbNombre;
        private Button btGuardar;
        private DataGridView dgvProductos;
        
        // Panaderias
        private Label lblNombrePanaderia;
        private TextBox tbNombrePanaderia;
        private Label lblDireccion;
        private TextBox tbDireccion;
        private Label lblTelefono;
        private TextBox tbTelefono;
        private Button btGuardarPanaderia;
        private DataGridView dgvPanaderia;
        
        // PanaderiasProductos
        private Label lblPanaderia;
        private ComboBox cbPanaderia;
        private Label lblProducto;
        private ComboBox cbProducto;
        private Label lblStock;
        private TextBox tbStock;
        private Label lblPrecio;
        private TextBox tbPrecio;
        private Button btGuardarProductoPanaderia;
        private DataGridView dgvPanaderiaProductos;
    }
}
