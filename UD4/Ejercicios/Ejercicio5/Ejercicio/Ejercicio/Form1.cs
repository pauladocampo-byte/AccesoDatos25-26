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

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Initial Catalog = tienda; Data Source = localhost; user=sa; password=montecastelo";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                int codigo;
                int.TryParse(textBox1.Text, out codigo);

                var consulta = $@"SELECT * FROM producto WHERE codigo = {codigo}";

                //Ejecucion de la consulta
                Producto producto = (Producto) conexion.Query<Producto>(consulta).FirstOrDefault();
                if (producto == null)
                {
                    textBox2.Text = "No hay ese producto";
                    textBox3.Text = "No hay ese producto";
                }
                else
                {
                    textBox2.Text = producto.Nombre;
                    textBox3.Text = producto.Precio.ToString("0.00");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                int codigo;
                string nombre;
                Single precio;

                int.TryParse(textBox1.Text, out codigo);
                nombre = textBox2.Text;
                Single.TryParse(textBox3.Text, out precio);

                var consulta = $"UPDATE Producto SET Nombre = '{nombre}', Precio = TRY_CAST( REPLACE( '{precio}', ',', '.') AS FLOAT) WHERE Codigo = {codigo}";

                //Ejecucion de la consulta
                conexion.Execute(consulta);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
