using Actividad1.Data;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly PanaderiaContext _context;

        public Form1(PanaderiaContext context)
        {
            _context = context;
            InitializeComponent(); 
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                var producto = new Producto
                {
                    Nombre = tbNombre.Text,
                    Precio = decimal.Parse(tbPrecio.Text),
                    Stock = int.Parse(tbStock.Text)
                };

                _context.Productos.Add(producto);
                _context.SaveChanges();

                MessageBox.Show("Producto guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbNombre.Clear();
                tbPrecio.Clear();
                tbStock.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btvisualizar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _context.Productos.ToList();
        }
    }
}
