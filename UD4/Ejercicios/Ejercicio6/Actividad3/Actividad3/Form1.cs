using Dapper;
using Ejercicio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Initial Catalog = tienda; Data Source = localhost; user=sa; password=montecastelo";

        enum TIPO_OPERACION
        {
            INSERT, 
            UPDATE, 
            DELETE
        };

        TIPO_OPERACION tipoOperacionProducto = TIPO_OPERACION.INSERT;
        TIPO_OPERACION tipoOperacionFabricante = TIPO_OPERACION.INSERT;

        public Form1()
        {
            InitializeComponent();
        }

        private void lstProductos_DoubleClick(object sender, EventArgs e)
        {
            string nombreProducto = lstProductos.SelectedItem.ToString();

            ShowListaFabricantesProductoTodosParametros(nombreProducto);
        }

        public void ShowListaFabricantesProductoTodosParametros(string Fabricante)
        {
            List<Producto> Productos = ObtenerListaProductosFabricante(Fabricante);
            lstProductos.DataSource = Productos;
        }

        public List<Producto> ObtenerListaProductosFabricante(string Fabricante)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"SELECT F.* FROM Fabricante F INNER JOIN Producto P ON P.Codigo_Fabricante = F.Codigo WHERE F.Nombre LIKE '{Fabricante}'";

                //Ejecucion de la consulta
                List<Producto> Productos = (List<Producto>)conexion.Query<Producto>(consulta);
                return Productos;
            }
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            int codigo;
            float precio;
            Fabricante fabSeleccionado;

            int.TryParse(txtCodigo.Text, out codigo);
            float.TryParse(txtPrecio.Text, out precio);
            fabSeleccionado = (Fabricante)cbFabricanteSeleccionado.SelectedItem;

            Producto producto = new Producto(codigo, txtNombre.Text, precio, fabSeleccionado.Codigo);

            if (tipoOperacionProducto == TIPO_OPERACION.INSERT)
            {
                InsertarProducto(producto);
            }
            else
            {
                EditarProducto(producto);
            }
            ActualizarListaProductos();
        }

        private void btnInsertarFabricante_Click(object sender, EventArgs e)
        {
            int codigo;

            int.TryParse(txtCodigoFabricante.Text, out codigo);
            Fabricante fabricante = new Fabricante(codigo, txtNombreFabricante.Text);

            if (tipoOperacionFabricante == TIPO_OPERACION.INSERT)
            {
                InsertarFabricante(fabricante);
            }
            else
            {
                EditarFabricante(fabricante);
            }
            ActualizarListaFabricantes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListaProductos();
            ActualizarListaFabricantes();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            lblInsertarActualizarProductos.Text = "Editar Producto";
            btnInsertarActualizarProducto.Text = "Editar Producto";

            Producto ProductoSeleccionado = (Producto) lstProductos.SelectedItem;

            txtCodigo.Text = ProductoSeleccionado.Codigo.ToString();
            txtCodigo.Enabled = false;
            txtNombre.Text = ProductoSeleccionado.Nombre;
            txtPrecio.Text = ProductoSeleccionado.Precio.ToString();
            cbFabricanteSeleccionado.SelectedItem = ProductoSeleccionado.Codigo_fabricante;

            tipoOperacionProducto = TIPO_OPERACION.UPDATE;

        }

        private void btnEditarFabricante_Click(object sender, EventArgs e)
        {
            lblInsertarActualizarFabricantes.Text = "Editar Fabricante";
            btnInsertarActualizarFabricante.Text = "Editar Fabricante";

            Fabricante FabricanteSeleccionado = (Fabricante)lstFabricantes.SelectedItem;

            txtCodigoFabricante.Text = FabricanteSeleccionado.Codigo.ToString();
            txtCodigoFabricante.Enabled = false;
            txtNombreFabricante.Text = FabricanteSeleccionado.Nombre;

            tipoOperacionFabricante = TIPO_OPERACION.UPDATE;
        }

        private void btnBorrarFabricante_Click(object sender, EventArgs e)
        {
            Fabricante FabricanteABorrar = lstFabricantes.SelectedItem as Fabricante;

            List<Producto> ProductosDeFabricante = ObtenerListaProductosFabricante(FabricanteABorrar.Nombre);

            if (ProductosDeFabricante.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("El fabricante que desea borrar tiene productos asociados, ¿Desea borrarlos?", "ADVERTENCIA", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    foreach (Producto producto in ProductosDeFabricante)
                    {
                        BorrarProducto(producto);
                    }
                    BorrarFabricante(FabricanteABorrar);
                }
                else
                {
                    MessageBox.Show("No se ha borrado el fabricante");
                }
            }
            else
            {
                BorrarFabricante(FabricanteABorrar);
            }
            ActualizarListaFabricantes();
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            Producto ProductoABorrar = lstProductos.SelectedItem as Producto;
            BorrarProducto(ProductoABorrar);
            ActualizarListaProductos();
        }

        //Métodos públicos
        public void InsertarProducto(Producto producto)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"INSERT INTO Producto (Codigo, Nombre, Precio, Codigo_Fabricante) VALUES (@Codigo, @Nombre, @Precio, @Codigo_Fabricante)";

                //Ejecucion de la consulta
                conexion.Execute(consulta, producto);
            }
        }
        public void InsertarFabricante(Fabricante fabricante)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"INSERT INTO Fabricante (Codigo, Nombre) VALUES (@Codigo, @Nombre)";

                //Ejecucion de la consulta
                conexion.Execute(consulta, fabricante);
            }
        }
        public void EditarProducto(Producto producto)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = 
                    $@"UPDATE Producto SET Codigo = @Codigo, 
                    Nombre = @Nombre, Precio = @Precio, Codigo_Fabricante = @Codigo_Fabricante 
                    WHERE Codigo = @Codigo";

                //Ejecucion de la consulta
                conexion.Execute(consulta, producto);
            }
        }
        public void EditarFabricante(Fabricante fabricante)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta =
                    $@"UPDATE Fabricante SET Codigo = @Codigo, 
                    Nombre = @Nombre
                    WHERE Codigo = @Codigo";

                //Ejecucion de la consulta
                conexion.Execute(consulta, fabricante);
            }
        }

        public void ActualizarListaProductos()
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Producto";

                //Ejecucion de la consulta
                List<Producto> Productos = (List<Producto>)conexion.Query<Producto>(consulta);
                lstProductos.DataSource = Productos;
            }
        }
        public void ActualizarListaFabricantes()
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"SELECT * FROM Fabricante";

                //Ejecucion de la consulta
                List<Fabricante> Fabricantes = (List<Fabricante>)conexion.Query<Fabricante>(consulta);
                lstFabricantes.DataSource = Fabricantes;
                cbFabricanteSeleccionado.DataSource = Fabricantes;
            }
        }

        public void BorrarFabricante(Fabricante Fabricante)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"DELETE FROM Fabricante WHERE Codigo = @Codigo;";

                //Ejecucion de la consulta
                conexion.Execute(consulta, Fabricante);
            }
        }

        public void BorrarProducto(Producto Producto)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"DELETE FROM Producto WHERE Codigo = @Codigo;";

                //Ejecucion de la consulta
                conexion.Execute(consulta, Producto);
            }
        }
    }
}
