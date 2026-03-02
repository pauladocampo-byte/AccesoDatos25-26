using Actividad5.Core;
using Actividad5.Services;

namespace Actividad5.UI
{
    public partial class Form1 : Form
    {
        private readonly IProductoService? _productService;
        private readonly IPanaderiaService? _panaderiaService;
        private readonly IPanaderiaProductoService _panaderiaProductoService;

        public Form1(IProductoService? productService, IPanaderiaService? panaderiaService, IPanaderiaProductoService panaderiaProductoService)
        {
            InitializeComponent();
            _productService = productService;
            _panaderiaService = panaderiaService;
            _panaderiaProductoService = panaderiaProductoService;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            RefrescarObtenerProductos();
            RefrescarObtenerPanaderias();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Nombre = txtNombreProducto.Text
            };
            _productService.Crear(producto);
            RefrescarObtenerProductos();


        }

        public void RefrescarObtenerProductos()
        {
            var productos = _productService.ObtenerTodos();

            dgvProductos.DataSource = productos;
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            if (productos.Count > 0)
                cmbProducto.SelectedIndex = 0;


        }

        private void btnGuardarPanaderia_Click(object sender, EventArgs e)
        {
            var panaderia = new Panaderia
            {
                Nombre = txtNombrePanaderia.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };
            _panaderiaService.Crear(panaderia);
            RefrescarObtenerPanaderias();
        }

        public void RefrescarObtenerPanaderias()
        {
            var panaderias = _panaderiaService.ObtenerTodas();

            dgvPanaderias.DataSource = panaderias;
            cmbPanaderia.DataSource = panaderias;
            cmbPanaderia.DisplayMember = "Nombre";
            cmbPanaderia.ValueMember = "Id";
            if (panaderias.Count > 0)
                cmbPanaderia.SelectedIndex = 0;

        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            var panaderiaProducto = new PanaderiaProducto
            {
                PanaderiaId = (int)cmbPanaderia.SelectedValue,
                ProductoId = (int)cmbProducto.SelectedValue,
                Stock = int.Parse(txtStockRelacion.Text),
                Precio = decimal.Parse(txtPrecioRelacion.Text)
            };

            _panaderiaProductoService.Crear(panaderiaProducto);
            RefreshObtenerPanaderiaProductos();
        }

        public void RefreshObtenerPanaderiaProductos()
        {
            var panaderiaProductos = _panaderiaProductoService!.ObtenerTodas()
                .Select(pp => new
                {
                    Panaderia = pp.Panaderia?.Nombre ?? "N/A",
                    Producto = pp.Producto?.Nombre ?? "N/A",
                    Precio = pp.Precio,
                    Stock = pp.Stock
                })
                .ToList();

            dgvRelaciones.DataSource = null;
            dgvRelaciones.DataSource = panaderiaProductos;
        }
    }
}
