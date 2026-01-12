using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad6
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
            string cadConex = ConfigurationManager.ConnectionStrings["Actividad6.Properties.Settings.tiendaConnectionString"].ConnectionString;
            conexion = new SqlConnection(cadConex);
            conexion.Open();
            RellenaListaProductos();
            RellenaListaEquipos();
        }

        public void RellenaListaProductos()
        {
            //Creo la consulta
            string consulta = "SELECT * FROM producto";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            RellenarListaConAdapter(lstProductos, adapter, "Codigo", "Nombre");
        }

        public void RellenaListaEquipos()
        {
            //Creo la consulta
            string consulta = "SELECT * FROM fabricante";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter1 = new SqlDataAdapter(comando);
            SqlDataAdapter adapter2 = new SqlDataAdapter(comando);
            using (adapter1)
            {
                DataTable datatable = new DataTable();
                adapter1.Fill(datatable);

                cbFutbolistaEquipo.ValueMember = "Codigo"; //La clave asociada a cada futbolista
                cbFutbolistaEquipo.DisplayMember = "Nombre"; //El nombre asociado a cada futbolista
                cbFutbolistaEquipo.DataSource = datatable;
            }
            //RellenarListaConAdapter(lstEquipos, adapter2, "Codigo", "Nombre");
        }


        //Metodo escalable. Puedo rellenar cualquier ListBox con cualquier SQLDataAdapter
        public void RellenarListaConAdapter(ListBox listaParaRellenar, SqlDataAdapter adaptadorARellenar, string campoIdentificador, string campoAMostrar)
        {
            using (adaptadorARellenar)
            {
                DataTable datatable = new DataTable();
                adaptadorARellenar.Fill(datatable);

                listaParaRellenar.ValueMember = campoIdentificador; //La clave asociada a cada futbolista
                listaParaRellenar.DisplayMember = campoAMostrar; //El nombre asociado a cada futbolista
                listaParaRellenar.DataSource = datatable;
            }
        }

        private void btnInsertarFutbolista_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO producto (Codigo, Nombre, Precio, Codigo_fabricante) VALUES (@Codigo, @Nombre, @Precio, @Codigo_fabricante)";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Codigo", txtCodigoFutbolista.Text);
            comando.Parameters.AddWithValue("@Nombre", txtNombreFutbolista.Text);
            comando.Parameters.AddWithValue("@Precio", Convert.ToSingle(textBox1.Text));
            comando.Parameters.AddWithValue("@Codigo_fabricante", cbFutbolistaEquipo.SelectedValue);
            comando.ExecuteNonQuery();

            txtCodigoFutbolista.Clear();
            txtNombreFutbolista.Clear();
        }

        private void btnBorrarFutbolista_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM producto WHERE Codigo = @Codigo";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Codigo", lstProductos.SelectedValue);
            comando.ExecuteNonQuery();

            RellenaListaProductos();
        }
    }
}
