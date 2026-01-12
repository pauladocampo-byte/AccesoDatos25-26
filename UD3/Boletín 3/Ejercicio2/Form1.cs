using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        BindingList<string> listaProductos;
        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection(@"server=DESKTOP-S65ABNK\BD_MONTECASTELO; database=tienda; integrated security=true");
            conexion.Open();
            listaProductos = new BindingList<string>();
            listBox1.DataSource = listaProductos;
            mostrarProductos();
        }

        public void mostrarProductos()
        {
            string info, consulta;

            consulta = "SELECT CONCAT(codigo,' | ',nombre,' | ',precio,' | ', codigo_fabricante) as INFO FROM producto";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                info = registros["INFO"].ToString();
                if (!listaProductos.Contains(info))
                {
                    listaProductos.Add(info);
                }
            }

            registros.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
