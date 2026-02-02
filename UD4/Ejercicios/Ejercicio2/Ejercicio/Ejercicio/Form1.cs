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

        private void button1_Click(object sender, EventArgs e)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM producto";

                //Ejecucion de la consulta
                List<Producto> Productos = (List<Producto>)conexion.Query<Producto>(consulta);
                listBox1.DataSource = Productos;
            }
        }
    }
}
