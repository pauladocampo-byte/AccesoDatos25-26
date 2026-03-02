using Actividad5.Data;
using Actividad5.Core;
using Microsoft.EntityFrameworkCore;

namespace Actividad5.UI
{
    public partial class FormGestion : Form
    {
        private readonly PanaderiaContext _context;

        public FormGestion(PanaderiaContext context)
        {
            _context = context;
            InitializeComponent();
            CargarDatos();
        }

        #region Carga de datos

        private void CargarDatos()
        {
            CargarProductos();
            CargarPanaderias();
            CargarRelaciones();
            CargarCombos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = _context.Productos.ToList();
        }

        private void CargarPanaderias()
        {
            dgvPanaderias.DataSource = _context.Panaderias.ToList();
        }

        private void CargarRelaciones()
        {
            // Cargar relaciones con nombres en lugar de IDs
            var relaciones = _context.PanaderiaProductos
                .Include(pp => pp.Panaderia)
                .Include(pp => pp.Producto)
                .Select(pp => new
                {
                    Panaderia = pp.Panaderia.Nombre,
                    Producto = pp.Producto.Nombre,
                    pp.Precio,
                    pp.Stock
                })
                .ToList();

            dgvRelaciones.DataSource = relaciones;
        }

        private void CargarCombos()
        {
            // Combo de panaderías
            cmbPanaderia.DataSource = _context.Panaderias.ToList();
            cmbPanaderia.DisplayMember = "Nombre";
            cmbPanaderia.ValueMember = "Id";

            // Combo de productos
            cmbProducto.DataSource = _context.Productos.ToList();
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
        }

        #endregion

        #region Productos

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var producto = new Producto
                {
                    Nombre = txtNombreProducto.Text
                };

                _context.Productos.Add(producto);
                _context.SaveChanges();

                MessageBox.Show("Producto guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposProducto();
                CargarProductos();
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposProducto()
        {
            txtNombreProducto.Clear();
        }

        #endregion

        #region Panaderías

        private void btnGuardarPanaderia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombrePanaderia.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var panaderia = new Panaderia
                {
                    Nombre = txtNombrePanaderia.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text
                };

                _context.Panaderias.Add(panaderia);
                _context.SaveChanges();

                MessageBox.Show("Panadería guardada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposPanaderia();
                CargarPanaderias();
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposPanaderia()
        {
            txtNombrePanaderia.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        #endregion

        #region Relaciones

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPanaderia.SelectedValue == null || cmbProducto.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona una panadería y un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int panaderiaId = (int)cmbPanaderia.SelectedValue;
                int productoId = (int)cmbProducto.SelectedValue;

                // Verificar si ya existe la relación
                var existe = _context.PanaderiaProductos
                    .Any(pp => pp.PanaderiaId == panaderiaId && pp.ProductoId == productoId);

                if (existe)
                {
                    MessageBox.Show("Esta relación ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var relacion = new PanaderiaProducto
                {
                    PanaderiaId = panaderiaId,
                    ProductoId = productoId,
                    Precio = decimal.Parse(txtPrecioRelacion.Text),
                    Stock = int.Parse(txtStockRelacion.Text)
                };

                _context.PanaderiaProductos.Add(relacion);
                _context.SaveChanges();

                MessageBox.Show("Relación creada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposRelacion();
                CargarRelaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposRelacion()
        {
            txtPrecioRelacion.Clear();
            txtStockRelacion.Clear();
        }

        #endregion
    }
}
