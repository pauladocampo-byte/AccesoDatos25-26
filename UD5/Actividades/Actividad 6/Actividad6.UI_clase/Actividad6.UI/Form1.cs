using Actividad6.ClienteApi;
using Actividad6.ClienteApi.Dto;
using System.Threading.Tasks;

namespace Actividad6.UI
{
    public partial class Form1 : Form
    {
        private readonly PanaderiaApiClient _panaderiaApiClient = null!;
        public Form1(PanaderiaApiClient panaderiaApiClient)
        {
            InitializeComponent();

            _panaderiaApiClient = panaderiaApiClient;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            RefrescarObtenerProductos();
            RefrescarObtenerPanaderias();
            RefreshObtenerPanaderiaProductos();
        }

        private async void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            var producto = new ProductoDto
            {
                Nombre = txtNombreProducto.Text
            };
            await _panaderiaApiClient.CrearProductoAsync(producto);
            await RefrescarObtenerProductos();


        }

        public async Task RefrescarObtenerProductos()
        {
            var productos = await _panaderiaApiClient.ObtenerProductosAsync();

            dgvProductos.DataSource = productos;
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            if (productos.Count > 0)
                cmbProducto.SelectedIndex = 0;


        }

        private async void btnGuardarPanaderia_Click(object sender, EventArgs e)
        {
            var panaderia = new PanaderiaDto
            {
                Nombre = txtNombrePanaderia.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };
            await _panaderiaApiClient.CrearPanaderiaAsync(panaderia);
            RefrescarObtenerPanaderias();
        }

        public async Task RefrescarObtenerPanaderias()
        {
            var panaderias = await _panaderiaApiClient.ObtenerPanaderiasAsync();

            dgvPanaderias.DataSource = panaderias;
            cmbPanaderia.DataSource = panaderias;
            cmbPanaderia.DisplayMember = "Nombre";
            cmbPanaderia.ValueMember = "Id";
            if (panaderias.Count > 0)
                cmbPanaderia.SelectedIndex = 0;

        }

        private async void btnAsociar_Click(object sender, EventArgs e)
        {
            var panaderiaProducto = new PanaderiaProductoDto
            {
                PanaderiaId = (int)cmbPanaderia.SelectedValue,
                ProductoId = (int)cmbProducto.SelectedValue,
                Stock = int.Parse(txtStockRelacion.Text),
                Precio = decimal.Parse(txtPrecioRelacion.Text)
            };

            await _panaderiaApiClient.CrearRelacionAsync(panaderiaProducto);
            await RefreshObtenerPanaderiaProductos();
        }

        public async Task RefreshObtenerPanaderiaProductos()
        {
            var panaderiaProductos = await _panaderiaApiClient!.ObtenerRelacionesAsync();
            panaderiaProductos
                .Select(pp => new
                {
                    Panaderia = pp.PanaderiaNombre ?? "N/A",
                    Producto = pp.ProductoNombre ?? "N/A",
                    Precio = pp.Precio,
                    Stock = pp.Stock
                })
                .ToList();

            dgvRelaciones.DataSource = null;
            dgvRelaciones.DataSource = panaderiaProductos;
        }
    }
}
