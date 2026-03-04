using Actividad6.ClienteApi;
using Actividad6.ClienteApi.Models;

namespace Actividad6.Frontend
{
    public partial class Form1 : Form
    {
        private readonly PanaderiaApiClient _apiClient;

        public Form1()
        {
            InitializeComponent();
            _apiClient = Program.ApiClient;
            
            // Cargar datos al iniciar
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            await RefreshAllDataAsync();
        }

        private async Task RefreshAllDataAsync()
        {
            try
            {
                await RefreshPanaderiasAsync();
                await RefreshProductosAsync();
                await RefreshPanaderiasProductosAsync();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error de conexión con la API: {ex.Message}\n\nAsegúrate de que la API está ejecutándose en {Program.ApiBaseUrl}", 
                    "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Panaderías

        private async Task RefreshPanaderiasAsync()
        {
            var panaderias = await _apiClient.ObtenerPanaderiasAsync();
            
            dgvPanaderia.DataSource = null;
            dgvPanaderia.DataSource = panaderias;

            cbPanaderia.DataSource = null;
            cbPanaderia.DataSource = panaderias.ToList(); // Nueva lista para evitar conflictos
            cbPanaderia.DisplayMember = "Nombre";
            cbPanaderia.ValueMember = "Id";
            cbPanaderia.SelectedIndex = panaderias.Count > 0 ? 0 : -1;
        }

        private async void btGuardarPanaderia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNombrePanaderia.Text))
                {
                    MessageBox.Show("El nombre de la panadería es obligatorio.", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var panaderia = new PanaderiaDto
                {
                    Nombre = tbNombrePanaderia.Text,
                    Direccion = tbDireccion.Text,
                    Telefono = tbTelefono.Text
                };

                await _apiClient.CrearPanaderiaAsync(panaderia);
                await RefreshPanaderiasAsync();
                
                MessageBox.Show("Panadería guardada con éxito.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                tbNombrePanaderia.Clear();
                tbDireccion.Clear();
                tbTelefono.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la panadería: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Productos

        private async Task RefreshProductosAsync()
        {
            var productos = await _apiClient.ObtenerProductosAsync();
            
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;

            cbProducto.DataSource = null;
            cbProducto.DataSource = productos.ToList(); // Nueva lista para evitar conflictos
            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "Id";
            cbProducto.SelectedIndex = productos.Count > 0 ? 0 : -1;
        }

        private async void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNombre.Text))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var producto = new ProductoDto { Nombre = tbNombre.Text };
                await _apiClient.CrearProductoAsync(producto);
                await RefreshProductosAsync();
                
                MessageBox.Show("Producto guardado con éxito.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                tbNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Panaderías-Productos

        private async Task RefreshPanaderiasProductosAsync()
        {
            var relaciones = await _apiClient.ObtenerRelacionesAsync();
            
            var dataSource = relaciones.Select(pp => new
            {
                Panaderia = pp.PanaderiaNombre,
                Producto = pp.ProductoNombre,
                pp.Precio,
                pp.Stock
            }).ToList();

            dgvPanaderiaProductos.DataSource = null;
            dgvPanaderiaProductos.DataSource = dataSource;
        }

        private async void btGuardarProductoPanaderia_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPanaderia.SelectedValue == null || cbProducto.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una panadería y un producto.", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbStock.Text, out int stock) || !decimal.TryParse(tbPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Stock y Precio deben ser valores numéricos válidos.", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var relacion = new PanaderiaProductoCreateDto
                {
                    PanaderiaId = (int)cbPanaderia.SelectedValue,
                    ProductoId = (int)cbProducto.SelectedValue,
                    Stock = stock,
                    Precio = precio
                };

                await _apiClient.CrearRelacionAsync(relacion);
                await RefreshPanaderiasProductosAsync();
                
                MessageBox.Show("Relación guardada con éxito.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbStock.Clear();
                tbPrecio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la relación: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
