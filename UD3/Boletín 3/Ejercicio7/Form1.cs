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

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection(@"server=DESKTOP-S65ABNK\BD_MONTECASTELO; database=tienda; integrated security=true");
            conexion.Open();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadena;
            int codigo;
            SqlCommand comando;
            SqlDataReader registros;

            txtNombre.Text = "";
            txtPrecio.Text = "";

            cadena = "SELECT Nombre, Precio FROM producto WHERE Codigo=@Codigo";
            int.TryParse(txtCodigo.Text, out codigo);

            comando = new SqlCommand(cadena, conexion);

            comando.Parameters.AddWithValue("Codigo", codigo);

            registros = comando.ExecuteReader();

            if (!registros.HasRows)
            {
                MessageBox.Show("No hay resultados");
            }
            else
            {
                while (registros.Read())
                {
                    txtNombre.Text = registros["Nombre"].ToString();
                    txtPrecio.Text = registros["Precio"].ToString();
                }
            }

            registros.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cadena;
            int codigo, filasAfectadas;
            SqlCommand comando;

            cadena = "UPDATE producto SET Nombre = @Nombre, Precio = @Precio WHERE Codigo = @Codigo";
            int.TryParse(txtCodigo.Text, out codigo);

            comando = new SqlCommand(cadena, conexion);

            comando.Parameters.AddWithValue("Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("Precio", txtPrecio.Text);
            comando.Parameters.AddWithValue("Codigo", codigo);

            filasAfectadas = comando.ExecuteNonQuery();

            if (filasAfectadas == 0)
            {
                MessageBox.Show("No se han realizado cambios");
            }
            else
            {
                MessageBox.Show("Se han actualizado las filas correctamente");
            }
        }
    }
}
