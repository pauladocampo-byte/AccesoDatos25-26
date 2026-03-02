using Actividad4.Data;


namespace Actividad4
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
