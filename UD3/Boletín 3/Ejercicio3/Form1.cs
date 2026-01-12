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

namespace Ejercicio3
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, consulta;
            int codigo = 0, numFilasAfectadas;
            bool correcto = false;

            correcto = int.TryParse(textBox1.Text, out codigo);

            if (correcto)
            {
                consulta = "SELECT nombre, precio from producto WHERE codigo=@codigo";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@codigo", SqlDbType.Int);
                comando.Parameters["@codigo"].Value = codigo;

                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    lblNombre.Text = registros["nombre"].ToString();
                    lblPrecio.Text = registros["precio"].ToString();
                }

                registros.Close(); 
            }
        }
    }
}
