using Actividad3.Models;

namespace Actividad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Panaderia2DbContext())
                {
                    // Crear un nuevo producto basado en los valores de los TextBox
                    var producto = new Producto
                    {
                        Nombre = tbNombre.Text,
                        Precio = decimal.Parse(tbPrecio.Text),
                        Stock = int.Parse(tbStock.Text)
                    };

                    // Agregar y guardar el producto en la base de datos
                    context.Productos.Add(producto);
                    context.SaveChanges();

                    MessageBox.Show("Producto guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Limpiar los campos
                tbNombre.Clear();
                tbPrecio.Clear();
                tbStock.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            using (var context = new Panaderia2DbContext())
            {
                dgvProductos.DataSource = context.Productos.ToList();
            }
        }
    }
}
