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

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        BindingList<string> listaFabricantes;
        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection(@"server=DESKTOP-S65ABNK\BD_MONTECASTELO; database=tienda; integrated security=true");
            conexion.Open();
            listaFabricantes = new BindingList<string>();
            listBox1.DataSource = listaFabricantes;
            actualizarFabricantes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, consulta;
            int codigo = 0, numFilasAfectadas;
            bool correcto = false;

            nombre = textBox1.Text;

            consulta = "SELECT MAX(codigo) AS codigo from fabricante";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                correcto = int.TryParse(registros["codigo"].ToString(), out codigo);
            }

            registros.Close();

            if (correcto)
            {
                consulta = "INSERT INTO fabricante VALUES (@codigo, @nombre)";

                comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@codigo", SqlDbType.Int);
                comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar);

                comando.Parameters["@codigo"].Value = codigo + 1;
                comando.Parameters["@nombre"].Value = nombre;

                numFilasAfectadas = comando.ExecuteNonQuery();

                if (numFilasAfectadas == 1)
                {
                    MessageBox.Show("La inserción fue un éxito");
                    actualizarFabricantes();
                }
                else
                {
                    MessageBox.Show("Algo no funciona");
                }
            }
        }

        public void actualizarFabricantes()
        {
            string nombre, consulta;

            consulta = "SELECT nombre from fabricante";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                nombre = registros["nombre"].ToString();
                if (!listaFabricantes.Contains(nombre))
                {
                    listaFabricantes.Add(nombre);
                }
            }

            registros.Close();
        }
    }
}
